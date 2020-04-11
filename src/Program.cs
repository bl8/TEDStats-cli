//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
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
            var req = new SearchRequest(full_query) {
                Scope = 2
            };
            System.Console.WriteLine(req.ToJson());
            
            var res = await api.Search(req);
            System.Console.WriteLine("Results count: " + res.Total);
            //System.Console.WriteLine(res.Results[0].ToString());
        }
    }
}
