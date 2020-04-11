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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace TEDStats.Model
{
    /// <summary>
    /// SearchRequest
    /// </summary>
    [DataContract(Name = "SearchRestRequest")]
    public partial class SearchRequest :  IEquatable<SearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Fields
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldsEnum
        {
            /// <summary>
            /// Enum AA for value: AA
            /// </summary>
            [EnumMember(Value = "AA")]
            AA = 1,

            /// <summary>
            /// Enum AC for value: AC
            /// </summary>
            [EnumMember(Value = "AC")]
            AC = 2,

            /// <summary>
            /// Enum CY for value: CY
            /// </summary>
            [EnumMember(Value = "CY")]
            CY = 3,

            /// <summary>
            /// Enum DD for value: DD
            /// </summary>
            [EnumMember(Value = "DD")]
            DD = 4,

            /// <summary>
            /// Enum DI for value: DI
            /// </summary>
            [EnumMember(Value = "DI")]
            DI = 5,

            /// <summary>
            /// Enum DS for value: DS
            /// </summary>
            [EnumMember(Value = "DS")]
            DS = 6,

            /// <summary>
            /// Enum DT for value: DT
            /// </summary>
            [EnumMember(Value = "DT")]
            DT = 7,

            /// <summary>
            /// Enum MA for value: MA
            /// </summary>
            [EnumMember(Value = "MA")]
            MA = 8,

            /// <summary>
            /// Enum NC for value: NC
            /// </summary>
            [EnumMember(Value = "NC")]
            NC = 9,

            /// <summary>
            /// Enum ND for value: ND
            /// </summary>
            [EnumMember(Value = "ND")]
            ND = 10,

            /// <summary>
            /// Enum OC for value: OC
            /// </summary>
            [EnumMember(Value = "OC")]
            OC = 11,

            /// <summary>
            /// Enum OJ for value: OJ
            /// </summary>
            [EnumMember(Value = "OJ")]
            OJ = 12,

            /// <summary>
            /// Enum OL for value: OL
            /// </summary>
            [EnumMember(Value = "OL")]
            OL = 13,

            /// <summary>
            /// Enum OY for value: OY
            /// </summary>
            [EnumMember(Value = "OY")]
            OY = 14,

            /// <summary>
            /// Enum PC for value: PC
            /// </summary>
            [EnumMember(Value = "PC")]
            PC = 15,

            /// <summary>
            /// Enum PD for value: PD
            /// </summary>
            [EnumMember(Value = "PD")]
            PD = 16,

            /// <summary>
            /// Enum PR for value: PR
            /// </summary>
            [EnumMember(Value = "PR")]
            PR = 17,

            /// <summary>
            /// Enum RC for value: RC
            /// </summary>
            [EnumMember(Value = "RC")]
            RC = 18,

            /// <summary>
            /// Enum RN for value: RN
            /// </summary>
            [EnumMember(Value = "RN")]
            RN = 19,

            /// <summary>
            /// Enum RP for value: RP
            /// </summary>
            [EnumMember(Value = "RP")]
            RP = 20,

            /// <summary>
            /// Enum TD for value: TD
            /// </summary>
            [EnumMember(Value = "TD")]
            TD = 21,

            /// <summary>
            /// Enum TVH for value: TVH
            /// </summary>
            [EnumMember(Value = "TVH")]
            TVH = 22,

            /// <summary>
            /// Enum TVL for value: TVL
            /// </summary>
            [EnumMember(Value = "TVL")]
            TVL = 23,

            /// <summary>
            /// Enum TY for value: TY
            /// </summary>
            [EnumMember(Value = "TY")]
            TY = 24,

            /// <summary>
            /// Enum CONTENT for value: CONTENT
            /// </summary>
            [EnumMember(Value = "CONTENT")]
            CONTENT = 25

        }


        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldsEnum>? Fields { get; set; }

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
        public SearchRequest(string query, List<FieldsEnum>? fields = default, int pageNum = 1, int pageSize = 10, bool reverseOrder = false, int scope = 1, string sortField = "ND")
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
        /// Gets or Sets Q
        /// </summary>
        [DataMember(Name="q", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets ReverseOrder
        /// </summary>
        [DataMember(Name="reverseOrder", EmitDefaultValue=false)]
        public bool ReverseOrder { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public int Scope { get; set; }

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

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
