//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System.Collections.Generic;
using System.Threading.Tasks;
using TEDStats.Client;
using TEDStats.Model;


namespace TEDStats.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Search for notices for map
        /// </summary>
        /// <remarks>
        /// Gets notices by nuts code for the browse by map feature
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API key (optional)</param>
        /// <param name="scope">Search scope. 1 for &#39;Last edition&#39;; 2 for &#39;Active&#39; (optional, default to 1)</param>
        /// <returns>Task of SearchDataMapResponse</returns>
        Task<SearchDataMapResponse> GetNoticesNutsCount (int? scope = 1);

        /// <summary>
        /// Search for notices using expert search query
        /// </summary>
        /// <remarks>
        /// For more information in the query format or field names, please consult https://ted.europa.eu/TED/misc/helpPage.do?helpPageId&#x3D;expertSearch. If your URL length is too long, use the POST method.
        /// </remarks>
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
        Task<SearchResponse> Search (string query, List<string>? fields = default, int pageNum = 1, int pageSize = 10, bool reverseOrder = false, SearchScope scope = SearchScope.LatestEdition, string sortField = "ND");

        /// <summary>
        /// Search for notices using expert search query
        /// </summary>
        /// <remarks>
        /// Search for notices
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRestRequest">searchRestRequest (optional)</param>
        /// <returns>Task of SearchResponseV2</returns>
        Task<SearchResponse> Search (SearchRequest searchRestRequest);
        #endregion Asynchronous Operations
    }
}
