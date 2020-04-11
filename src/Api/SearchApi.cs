//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using TEDStats.Client;
using TEDStats.Model;

namespace TEDStats.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchApi : ISearchApiAsync
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchControllerV2Api"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi()
        {
            Config = GlobalConfiguration.Instance;
            Client = new ApiClient();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(string basePath)
        {
            Config = Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            Client = new ApiClient(Config.BasePath);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchApi(Configuration configuration)
        {
            this.Config = Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ApiClient(this.Config.BasePath);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchControllerV2Api"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SearchApi(ApiClient client, IReadableConfiguration configuration)
        {
            Client = client;
            Config = configuration;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ApiClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return Config.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Config {get; }

        /// <summary>
        /// Search for notices for map Gets notices by nuts code for the browse by map feature
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API key (optional)</param>
        /// <param name="scope">Search scope. 1 for &#39;Last edition&#39;; 2 for &#39;Active&#39; (optional, default to 1)</param>
        /// <returns>Task of SearchDataMapResponse</returns>
        public async Task<SearchDataMapResponse> GetNoticesNutsCount (int? scope = 1)
        {
            RequestOptions opts = new RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                opts.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                opts.HeaderParameters.Add("Accept", _accept);
            
            if (scope != null)
            {
                opts.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "scope", scope));
            }

            // make the HTTP request
            return await this.Client.GetAsync<SearchDataMapResponse>("/api/v2.0/notices/attributes/nuts/count", opts, Config);
        }


        /// <summary>
        /// Search for notices using expert search query For more information in the query format or field names, please consult https://ted.europa.eu/TED/misc/helpPage.do?helpPageId&#x3D;expertSearch. If your URL length is too long, use the POST method.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search query</param>
        /// <param name="apiKey">API key (optional)</param>
        /// <param name="fields">The list of field names to return for each notice. CONTENT is the notice in XML encoded in base64. If a field indicated here has no value for a notice, it will be omitted in the response. (optional)</param>
        /// <param name="pageNum">Number of the current page (optional, default to 1)</param>
        /// <param name="pageSize">Number of results by page (optional)</param>
        /// <param name="reverseOrder">Display the result in reverse order (optional, default to false)</param>
        /// <param name="scope">Search scope. 1 for &#39;Last edition&#39;; 2 for &#39;Active notices&#39;; 3 for &#39;All&#39; (optional, default to 1)</param>
        /// <param name="sortField">Field for sorting of search results (optional, default to ND)</param>
        /// <returns>Task of SearchResponseV2</returns>
        public async Task<SearchResponse> Search (string query, List<string>? fields = default, int pageNum = 1, int pageSize = 10, bool reverseOrder = false, int scope = 1, string sortField = "ND")
        {
            // verify the required parameter 'q' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'q' when calling SearchCApi->Search");


            var req = new SearchRequest(query) {
                //Fields = fields,
                PageNum = pageNum,
                PageSize = pageSize,
                ReverseOrder = reverseOrder,
                Scope = scope,
                SortField = sortField
            };

            return await Search(req);
        }

        /// <summary>
        /// Search for notices using expert search query Search for notices
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRestRequest">searchRestRequest (optional)</param>
        /// <returns>Task of SearchResponseV2</returns>
        public async Task<SearchResponse> Search (SearchRequest searchRequest)
        {
            RequestOptions opts = new RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                opts.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                opts.HeaderParameters.Add("Accept", _accept);
            

            // make the HTTP request
            return await Client.PostAsync<SearchResponse>("/api/v2.0/notices/search", searchRequest, opts, this.Config);
        }

    }
}
