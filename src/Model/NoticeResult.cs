//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using DateConverter = TEDStats.Client.DateConverter;

namespace TEDStats.Model
{
    /// <summary>
    /// RestNoticeResultV2
    /// </summary>
    [DataContract(Name = "RestNoticeResultV2")]
    public partial class NoticeResult :  IEquatable<NoticeResult>, IValidatableObject
    {        
        /// <summary>
        /// Gets or Sets AA
        /// </summary>
        [DataMember(Name="AA", EmitDefaultValue=false)]
        public string? AuthorityType { get; set; }

        /// <summary>
        /// Gets or Sets AC
        /// </summary>
        [DataMember(Name="AC", EmitDefaultValue=false)]
        public string? AwardCriteria { get; set; }

        /// <summary>
        /// Gets or Sets BI
        /// </summary>
        [DataMember(Name="BI", EmitDefaultValue=false)]
        public List<string>? BI { get; set; }

        /// <summary>
        /// Gets or Sets CY
        /// </summary>
        [DataMember(Name="CY", EmitDefaultValue=false)]
        public string? Country { get; set; }

        /// <summary>
        /// Gets or Sets DD
        /// </summary>
        [DataMember(Name="DD", EmitDefaultValue=false)]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? DD { get; set; }

        /// <summary>
        /// Gets or Sets DI
        /// </summary>
        [DataMember(Name="DI", EmitDefaultValue=false)]
        public string? LegalBasis { get; set; }

        /// <summary>
        /// Gets or Sets DS
        /// </summary>
        [DataMember(Name="DS", EmitDefaultValue=false)]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? DispatchDate { get; set; }

        /// <summary>
        /// Gets or Sets DT
        /// </summary>
        [DataMember(Name="DT", EmitDefaultValue=false)]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? SubmissionDate { get; set; }

        /// <summary>
        /// Gets or Sets MA
        /// </summary>
        [DataMember(Name="MA", EmitDefaultValue=false)]
        public string? MainActivity { get; set; }

        /// <summary>
        /// Gets or Sets NC
        /// </summary>
        [DataMember(Name="NC", EmitDefaultValue=false)]
        public string? ContractType { get; set; }

        /// <summary>
        /// Gets or Sets ND
        /// </summary>
        [DataMember(Name="ND", EmitDefaultValue=false)]
        public string? DocumentNumber { get; set; }

        /// <summary>
        /// Gets or Sets NL
        /// </summary>
        [DataMember(Name="NL", EmitDefaultValue=false)]
        public long NL { get; set; }

        /// <summary>
        /// Gets or Sets OC
        /// </summary>
        [DataMember(Name="OC", EmitDefaultValue=false)]
        public List<string>? OC { get; set; }

        /// <summary>
        /// Gets or Sets OJ
        /// </summary>
        [DataMember(Name="OJ", EmitDefaultValue=false)]
        public string? EditionNumber { get; set; }

        /// <summary>
        /// Gets or Sets OL
        /// </summary>
        [DataMember(Name="OL", EmitDefaultValue=false)]
        public string? OriginalLanguage { get; set; }

        /// <summary>
        /// Gets or Sets OY
        /// </summary>
        [DataMember(Name="OY", EmitDefaultValue=false)]
        public List<string>? OY { get; set; }

        /// <summary>
        /// Gets or Sets PC
        /// </summary>
        [DataMember(Name="PC", EmitDefaultValue=false)]
        public List<string>? CpvCode { get; set; }

        /// <summary>
        /// Gets or Sets PD
        /// </summary>
        [DataMember(Name="PD", EmitDefaultValue=false)]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? PublicationDate { get; set; }

        /// <summary>
        /// Gets or Sets PR
        /// </summary>
        [DataMember(Name="PR", EmitDefaultValue=false)]
        public string? ProcedureType { get; set; }

        /// <summary>
        /// Gets or Sets RC
        /// </summary>
        [DataMember(Name="RC", EmitDefaultValue=false)]
        public List<string>? NutsCode { get; set; }

        /// <summary>
        /// Gets or Sets RN
        /// </summary>
        [DataMember(Name="RN", EmitDefaultValue=false)]
        public int RN { get; set; }

        /// <summary>
        /// Gets or Sets RP
        /// </summary>
        [DataMember(Name="RP", EmitDefaultValue=false)]
        public string? Regulation { get; set; }

        /// <summary>
        /// Gets or Sets TD
        /// </summary>
        [DataMember(Name="TD", EmitDefaultValue=false)]
        public string? DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets TVH
        /// </summary>
        [DataMember(Name="TVH", EmitDefaultValue=false)]
        public string? TVH { get; set; }

        /// <summary>
        /// Gets or Sets TVL
        /// </summary>
        [DataMember(Name="TVL", EmitDefaultValue=false)]
        public string? TVL { get; set; }

        /// <summary>
        /// Gets or Sets TY
        /// </summary>
        [DataMember(Name="TY", EmitDefaultValue=false)]
        public string? BidType { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public byte[]? Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestNoticeResultV2 {\n");
            sb.Append("  AA: ").Append(AuthorityType).Append("\n");
            sb.Append("  AC: ").Append(AwardCriteria).Append("\n");
            sb.Append("  BI: ").Append(BI).Append("\n");
            sb.Append("  CY: ").Append(Country).Append("\n");
            sb.Append("  DD: ").Append(DD).Append("\n");
            sb.Append("  DI: ").Append(LegalBasis).Append("\n");
            sb.Append("  DS: ").Append(DispatchDate).Append("\n");
            sb.Append("  DT: ").Append(SubmissionDate).Append("\n");
            sb.Append("  MA: ").Append(MainActivity).Append("\n");
            sb.Append("  NC: ").Append(ContractType).Append("\n");
            sb.Append("  ND: ").Append(DocumentNumber).Append("\n");
            sb.Append("  NL: ").Append(NL).Append("\n");
            sb.Append("  OC: ").Append(OC).Append("\n");
            sb.Append("  OJ: ").Append(EditionNumber).Append("\n");
            sb.Append("  OL: ").Append(OriginalLanguage).Append("\n");
            sb.Append("  OY: ").Append(OY).Append("\n");
            sb.Append("  PC: ").Append(CpvCode).Append("\n");
            sb.Append("  PD: ").Append(PublicationDate).Append("\n");
            sb.Append("  PR: ").Append(ProcedureType).Append("\n");
            sb.Append("  RC: ").Append(NutsCode).Append("\n");
            sb.Append("  RN: ").Append(RN).Append("\n");
            sb.Append("  RP: ").Append(Regulation).Append("\n");
            sb.Append("  TD: ").Append(DocumentType).Append("\n");
            sb.Append("  TVH: ").Append(TVH).Append("\n");
            sb.Append("  TVL: ").Append(TVL).Append("\n");
            sb.Append("  TY: ").Append(BidType).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
        /// Returns true if RestNoticeResultV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of RestNoticeResultV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoticeResult? input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorityType == input.AuthorityType ||
                    (this.AuthorityType != null &&
                    this.AuthorityType.Equals(input.AuthorityType))
                ) && 
                (
                    this.AwardCriteria == input.AwardCriteria ||
                    (this.AwardCriteria != null &&
                    this.AwardCriteria.Equals(input.AwardCriteria))
                ) && 
                (
                    this.BI == input.BI ||
                    this.BI != null &&
                    input.BI != null &&
                    this.BI.SequenceEqual(input.BI)
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.DD == input.DD ||
                    (this.DD != null &&
                    this.DD.Equals(input.DD))
                ) && 
                (
                    this.LegalBasis == input.LegalBasis ||
                    (this.LegalBasis != null &&
                    this.LegalBasis.Equals(input.LegalBasis))
                ) && 
                (
                    this.DispatchDate == input.DispatchDate ||
                    (this.DispatchDate != null &&
                    this.DispatchDate.Equals(input.DispatchDate))
                ) && 
                (
                    this.SubmissionDate == input.SubmissionDate ||
                    (this.SubmissionDate != null &&
                    this.SubmissionDate.Equals(input.SubmissionDate))
                ) && 
                (
                    this.MainActivity == input.MainActivity ||
                    (this.MainActivity != null &&
                    this.MainActivity.Equals(input.MainActivity))
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.NL == input.NL ||
                    this.NL.Equals(input.NL)
                ) && 
                (
                    this.OC == input.OC ||
                    this.OC != null &&
                    input.OC != null &&
                    this.OC.SequenceEqual(input.OC)
                ) && 
                (
                    this.EditionNumber == input.EditionNumber ||
                    (this.EditionNumber != null &&
                    this.EditionNumber.Equals(input.EditionNumber))
                ) && 
                (
                    this.OriginalLanguage == input.OriginalLanguage ||
                    (this.OriginalLanguage != null &&
                    this.OriginalLanguage.Equals(input.OriginalLanguage))
                ) && 
                (
                    this.OY == input.OY ||
                    this.OY != null &&
                    input.OY != null &&
                    this.OY.SequenceEqual(input.OY)
                ) && 
                (
                    this.CpvCode == input.CpvCode ||
                    this.CpvCode != null &&
                    input.CpvCode != null &&
                    this.CpvCode.SequenceEqual(input.CpvCode)
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.ProcedureType == input.ProcedureType ||
                    (this.ProcedureType != null &&
                    this.ProcedureType.Equals(input.ProcedureType))
                ) && 
                (
                    this.NutsCode == input.NutsCode ||
                    this.NutsCode != null &&
                    input.NutsCode != null &&
                    this.NutsCode.SequenceEqual(input.NutsCode)
                ) && 
                (
                    this.RN == input.RN ||
                    this.RN.Equals(input.RN)
                ) && 
                (
                    this.Regulation == input.Regulation ||
                    (this.Regulation != null &&
                    this.Regulation.Equals(input.Regulation))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.TVH == input.TVH ||
                    (this.TVH != null &&
                    this.TVH.Equals(input.TVH))
                ) && 
                (
                    this.TVL == input.TVL ||
                    (this.TVL != null &&
                    this.TVL.Equals(input.TVL))
                ) && 
                (
                    this.BidType == input.BidType ||
                    (this.BidType != null &&
                    this.BidType.Equals(input.BidType))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.AuthorityType != null)
                    hashCode = hashCode * 59 + this.AuthorityType.GetHashCode();
                if (this.AwardCriteria != null)
                    hashCode = hashCode * 59 + this.AwardCriteria.GetHashCode();
                if (this.BI != null)
                    hashCode = hashCode * 59 + this.BI.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.DD != null)
                    hashCode = hashCode * 59 + this.DD.GetHashCode();
                if (this.LegalBasis != null)
                    hashCode = hashCode * 59 + this.LegalBasis.GetHashCode();
                if (this.DispatchDate != null)
                    hashCode = hashCode * 59 + this.DispatchDate.GetHashCode();
                if (this.SubmissionDate != null)
                    hashCode = hashCode * 59 + this.SubmissionDate.GetHashCode();
                if (this.MainActivity != null)
                    hashCode = hashCode * 59 + this.MainActivity.GetHashCode();
                if (this.ContractType != null)
                    hashCode = hashCode * 59 + this.ContractType.GetHashCode();
                if (this.DocumentNumber != null)
                    hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                hashCode = hashCode * 59 + this.NL.GetHashCode();
                if (this.OC != null)
                    hashCode = hashCode * 59 + this.OC.GetHashCode();
                if (this.EditionNumber != null)
                    hashCode = hashCode * 59 + this.EditionNumber.GetHashCode();
                if (this.OriginalLanguage != null)
                    hashCode = hashCode * 59 + this.OriginalLanguage.GetHashCode();
                if (this.OY != null)
                    hashCode = hashCode * 59 + this.OY.GetHashCode();
                if (this.CpvCode != null)
                    hashCode = hashCode * 59 + this.CpvCode.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.ProcedureType != null)
                    hashCode = hashCode * 59 + this.ProcedureType.GetHashCode();
                if (this.NutsCode != null)
                    hashCode = hashCode * 59 + this.NutsCode.GetHashCode();
                hashCode = hashCode * 59 + this.RN.GetHashCode();
                if (this.Regulation != null)
                    hashCode = hashCode * 59 + this.Regulation.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.TVH != null)
                    hashCode = hashCode * 59 + this.TVH.GetHashCode();
                if (this.TVL != null)
                    hashCode = hashCode * 59 + this.TVL.GetHashCode();
                if (this.BidType != null)
                    hashCode = hashCode * 59 + this.BidType.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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
