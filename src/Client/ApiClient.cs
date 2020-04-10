//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace TEDStats.Client
{
    /// <summary>
    /// Provides a default implementation of an asynchronous Api client,
    /// encapsulating general REST accessor use cases.
    /// </summary>
    public partial class ApiClient
    {
        private readonly String _baseUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />, defaulting to the global configurations' base url.
        /// </summary>
        public ApiClient()
        {
            _baseUrl = GlobalConfiguration.Instance.BasePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        public ApiClient(String basePath)
        {
            if (string.IsNullOrEmpty(basePath))
                throw new ArgumentException("basePath cannot be empty");

            _baseUrl = basePath;
        }

        /// <summary>
        /// Provides all logic for constructing a new Url <see cref="RestRequest"/>.
        /// At this point, all information for querying the service is known.
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>[private] A new RestRequest instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private Url NewUrl(
            String path,
            RequestOptions options,
            IReadableConfiguration configuration)
        {
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");
            if (configuration == null) throw new ArgumentNullException("configuration");
            
            Url url = configuration.BasePath
                .AppendPathSegments(path);

            if (options.QueryParameters != null)
            {
                foreach (var queryParam in options.QueryParameters)
                {
                    foreach (var value in queryParam.Value)
                    {
                        url.SetQueryParam(queryParam.Key, value);
                    }
                }
            }

            if (configuration.DefaultHeaders != null)
            {
                foreach (var headerParam in configuration.DefaultHeaders)
                {
                    url.WithHeader(headerParam.Key, headerParam.Value);
                }
            }

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        url.WithHeader(headerParam.Key, value);
                    }
                }
            }

            if (configuration.UserAgent != null)
            {
                url.WithHeader("User-Agent", configuration.UserAgent);
            }

            if (options.Cookies != null && options.Cookies.Count > 0)
            {
                foreach (var cookie in options.Cookies)
                {
                    url.WithCookie(cookie.Name, cookie.Value);
                }
            }

            url.WithTimeout(configuration.Timeout);
            
            return url;
        }

        /// <summary>
        /// Make a HTTP GET request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing the API response</returns>
        public async Task<T> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration? configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            var url = NewUrl(path, options, config);

            return await url.GetJsonAsync<T>();
        }

        /// <summary>
        /// Make a HTTP POST request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object. It is assumed that any merge with
        /// GlobalConfiguration has been done before calling this method.</param>
        /// <returns>A Task containing the API response</returns>
        public async Task<T> PostAsync<T>(string path, RequestOptions options, IReadableConfiguration? configuration = null)
        {
            var config = configuration ?? GlobalConfiguration.Instance;
            var url = NewUrl(path, options, config);

            return await url.PostJsonAsync(options.Data).ReceiveJson<T>();
        }
    }
}
