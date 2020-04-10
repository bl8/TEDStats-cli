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
using System.ComponentModel.DataAnnotations;

namespace TEDStats.Model
{
    /// <summary>
    /// SearchDataMapResponse
    /// </summary>
    [DataContract(Name = "SearchDataMapResponse")]
    public partial class SearchDataMapResponse :  IEquatable<SearchDataMapResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDataMapResponse" /> class.
        /// </summary>
        /// <param name="results">results.</param>
        /// <param name="took">took.</param>
        /// <param name="total">total.</param>
        public SearchDataMapResponse(Dictionary<string, long> results, long took, int total)
        {
            this.Results = results;
            this.Took = took;
            this.Total = total;
        }
        
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public Dictionary<string, long> Results { get; set; }

        /// <summary>
        /// Gets or Sets Took
        /// </summary>
        [DataMember(Name="took", EmitDefaultValue=false)]
        public long Took { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchDataMapResponse {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Took: ").Append(Took).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
        /// Returns true if SearchDataMapResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchDataMapResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchDataMapResponse? input)
        {
            if (input == null) {
                return false;
            }

            return 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.Took == input.Took ||
                    this.Took.Equals(input.Took)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                hashCode = hashCode * 59 + this.Took.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
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
