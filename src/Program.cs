//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.TypeConversion;
using TEDStats.Api;
using TEDStats.Model;

namespace TEDStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a root command with some options
            var rootCommand = new RootCommand {
                new Option<string>(new string[] {"--query", "-q"}) {
                    Required = true,
                    Description = "Search query"
                },
                new Option<string>("--from") {
                    Required = true,
                    Description = "Start date, formatted as YYYY-MM-DD"
                },
                new Option<string>("--to", getDefaultValue: () => DateTime.UtcNow.ToString("yyyy-MM-dd")) {
                    Description = "End date, formatted as YYYY-MM-DD. Defaults to the current date"
                }
            };
            
            rootCommand.TreatUnmatchedTokensAsErrors = true;
            rootCommand.Handler = CommandHandler.Create<string, string, string>(GetStats);
            rootCommand.InvokeAsync(args).Wait();
        }

        public static async Task GetStats(string query, string from, string to)
        {
            var api = new SearchApi();

            var full_query = String.Format("({0}) AND PD=[{1} <> {2}]", query, from.Replace("-", ""), to.Replace("-", ""));
            var request = new SearchRequest(full_query) {
                Scope = SearchScope.All,
                Fields = new List<Fields>() { Fields.PublicationDate, Fields.EditionNumber },
                PageSize = 1
            };
            System.Console.WriteLine(request.ToJson());
            
            var results = new List<NoticeResult>();

            // One request to get the total number of results
            var res = await api.Search(request);
            System.Console.WriteLine("Results count: " + res.Total);

            request.PageSize = 100;
            int last_page = (int)Math.Ceiling((double)res.Total / request.PageSize);
            for (int i = 1; i < last_page + 1; i++)
            {
                request.PageNum = i;
                res = await api.Search(request);
                results.AddRange(res.Results);
            }

            var records = results.GroupBy(r => new Projection(r))
                .Select(gr => new { Key = gr.Key, Count = gr.Count()})
                .OrderBy(gr => gr.Key);

            using (var writer = new StreamWriter("output.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                var options = new TypeConverterOptions { Formats = new[] { "yyyy-MM-dd" } };
                csv.Configuration.TypeConverterOptionsCache.AddOptions<DateTime>(options);
                csv.WriteRecords(records);
            }
        }
    }

    internal class Projection : IComparable<Projection>
    {
        public DateTime PublicationDate { get; }
        public string? EditionNumber { get; }

        public Projection(NoticeResult notice)
        {
            PublicationDate = notice.PublicationDate;
            EditionNumber = notice.EditionNumber;
        }

        public override bool Equals(object? obj)
        {
            return obj is Projection other &&
                   PublicationDate == other.PublicationDate &&
                   EditionNumber == other.EditionNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PublicationDate, EditionNumber);
        }

        public int CompareTo(Projection? obj)
        {
            if (obj == null) {
                return 1;
            }

            return PublicationDate.CompareTo(obj.PublicationDate);
        }
    }
}
