//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TEDStats.Model
{
    /// <summary>
    /// SearchRequest
    /// </summary>
    [DataContract(Name = "SearchRestRequest")]
    public partial class SearchRequest :  IEquatable<SearchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="fields">fields.</param>
        /// <param name="pageNum">pageNum.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="query">q.</param>
        /// <param name="reverseOrder">reverseOrder.</param>
        /// <param name="scope">scope.</param>
        /// <param name="sortField">sortField.</param>
        public SearchRequest(string query, List<Fields>? fields = default, int pageNum = 1, int pageSize = 10, bool reverseOrder = false, SearchScope scope = SearchScope.LatestEdition, string sortField = "ND")
        {
            this.Fields = fields;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.Query = query;
            this.ReverseOrder = reverseOrder;
            this.Scope = scope;
            this.SortField = sortField;
        }


        /// <summary>
        /// Gets or Sets Q
        /// </summary>
        [DataMember(Name="q", EmitDefaultValue=false)]
        public string Query { get; set; }
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<Fields>? Fields { get; set; }

        /// <summary>
        /// Gets or Sets PageNum
        /// </summary>
        [DataMember(Name="pageNum", EmitDefaultValue=false)]
        public int PageNum { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets ReverseOrder
        /// </summary>
        [DataMember(Name="reverseOrder", EmitDefaultValue=false)]
        public bool ReverseOrder { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public SearchScope Scope { get; set; }

        /// <summary>
        /// Gets or Sets SortField
        /// </summary>
        [DataMember(Name="sortField", EmitDefaultValue=false)]
        public string SortField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchRestRequest {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  ReverseOrder: ").Append(ReverseOrder).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  SortField: ").Append(SortField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if SearchRestRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchRestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchRequest? input)
        {
            if (input == null) {
                return false;
            }

            return 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.ReverseOrder == input.ReverseOrder ||
                    this.ReverseOrder.Equals(input.ReverseOrder)
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
                ) && 
                (
                    this.SortField == input.SortField ||
                    (this.SortField != null &&
                    this.SortField.Equals(input.SortField))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                hashCode = hashCode * 59 + this.PageNum.GetHashCode();
                hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                hashCode = hashCode * 59 + this.ReverseOrder.GetHashCode();
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.SortField != null)
                    hashCode = hashCode * 59 + this.SortField.GetHashCode();
                return hashCode;
            }
        }
    }
}
