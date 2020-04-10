//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Threading.Tasks;
using TEDStats.Api;

namespace TEDStats
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var api = new SearchApi();
            var res = await api.Search("ND=[170115-2020]");
            System.Console.WriteLine("Results count: " + res.Total);
            System.Console.WriteLine(res.Results[0].ToString());
        }
    }
}
