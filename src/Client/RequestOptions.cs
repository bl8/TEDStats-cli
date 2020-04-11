//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace TEDStats.Client
{
    /// <summary>
    /// A container for generalized request inputs. This type allows consumers to extend the request functionality
    /// by abstracting away from the default (built-in) request framework (e.g. RestSharp).
    /// </summary>
    public class RequestOptions
    {
        /// <summary>
        /// Query parameters to be applied to the request.
        /// Keys may have 1 or more values associated.
        /// </summary>
        public Multimap<String, String> QueryParameters { get; set; }

        /// <summary>
        /// Header parameters to be applied to to the request.
        /// Keys may have 1 or more values associated.
        /// </summary>
        public Multimap<String, String> HeaderParameters { get; set; }

        /// <summary>
        /// Cookies to be sent along with the request.
        /// </summary>
        public List<Cookie> Cookies { get; set; }

        /// <summary>
        /// Constructs a new instance of <see cref="RequestOptions"/>
        /// </summary>
        public RequestOptions()
        {
            QueryParameters = new Multimap<string, string>();
            HeaderParameters = new Multimap<string, string>();
            Cookies = new List<Cookie>();
        }
    }
}