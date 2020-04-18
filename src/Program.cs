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
                new Option<string>("--to",
                        getDefaultValue: () => DateTime.UtcNow.ToString("yyyy-MM-dd")) {
                    Description = "End date, formatted as YYYY-MM-DD. Defaults to the current date"
                },
                new Option<FileInfo>(new string[] {"--output", "-o"},
                        getDefaultValue: () => new FileInfo("output.csv")) {
                    Description = "The name of the output file. Defaults to 'output.csv'"
                },
            };
            
            rootCommand.TreatUnmatchedTokensAsErrors = true;
            rootCommand.Handler = CommandHandler.Create<string, string, string, FileInfo>(Run);
            rootCommand.InvokeAsync(args).Wait();
        }

        public static async Task Run(string query, string from, string to, FileInfo output)
        {
            var results = await Function.GetStats(query, from, to);

            using (var writer = output.CreateText()) {
                writer.WriteLine(results);
            }
        }
    }
}
