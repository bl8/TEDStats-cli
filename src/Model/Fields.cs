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
    /// Defines Fields
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Fields
    {
        /// <summary>
        /// Enum AA for value: AA
        /// </summary>
        [EnumMember(Value = "AA")]
        AuthorityType = 1,

        /// <summary>
        /// Enum AC for value: AC
        /// </summary>
        [EnumMember(Value = "AC")]
        AwardCriteria = 2,

        /// <summary>
        /// Enum CY for value: CY
        /// </summary>
        [EnumMember(Value = "CY")]
        Country = 3,

        /// <summary>
        /// Enum DD for value: DD
        /// </summary>
        [EnumMember(Value = "DD")]
        Deadline = 4,

        /// <summary>
        /// Enum DI for value: DI
        /// </summary>
        [EnumMember(Value = "DI")]
        LegalBasis = 5,

        /// <summary>
        /// Enum DS for value: DS
        /// </summary>
        [EnumMember(Value = "DS")]
        DispatchDate = 6,

        /// <summary>
        /// Enum DT for value: DT
        /// </summary>
        [EnumMember(Value = "DT")]
        SubmissionDate = 7,

        /// <summary>
        /// Enum MA for value: MA
        /// </summary>
        [EnumMember(Value = "MA")]
        MainActivity = 8,

        /// <summary>
        /// Enum NC for value: NC
        /// </summary>
        [EnumMember(Value = "NC")]
        ContractType = 9,

        /// <summary>
        /// Enum ND for value: ND
        /// </summary>
        [EnumMember(Value = "ND")]
        DocumentNumber = 10,

        /// <summary>
        /// Enum OC for value: OC
        /// </summary>
        [EnumMember(Value = "OC")]
        OC = 11,

        /// <summary>
        /// Enum OJ for value: OJ
        /// </summary>
        [EnumMember(Value = "OJ")]
        EditionNumber = 12,

        /// <summary>
        /// Enum OL for value: OL
        /// </summary>
        [EnumMember(Value = "OL")]
        OriginalLanguage = 13,

        /// <summary>
        /// Enum OY for value: OY
        /// </summary>
        [EnumMember(Value = "OY")]
        OY = 14,

        /// <summary>
        /// Enum PC for value: PC
        /// </summary>
        [EnumMember(Value = "PC")]
        CpvCode = 15,

        /// <summary>
        /// Enum PD for value: PD
        /// </summary>
        [EnumMember(Value = "PD")]
        PublicationDate = 16,

        /// <summary>
        /// Enum PR for value: PR
        /// </summary>
        [EnumMember(Value = "PR")]
        ProcedureTYpe = 17,

        /// <summary>
        /// Enum RC for value: RC
        /// </summary>
        [EnumMember(Value = "RC")]
        NutsCode = 18,

        /// <summary>
        /// Enum RN for value: RN
        /// </summary>
        [EnumMember(Value = "RN")]
        PreviousNoticeReference = 19,

        /// <summary>
        /// Enum RP for value: RP
        /// </summary>
        [EnumMember(Value = "RP")]
        Regulation = 20,

        /// <summary>
        /// Enum TD for value: TD
        /// </summary>
        [EnumMember(Value = "TD")]
        DocumentType = 21,

        /// <summary>
        /// Enum TVH for value: TVH
        /// </summary>
        [EnumMember(Value = "TVH")]
        EstimatedTotalValue = 22,

        /// <summary>
        /// Enum TVL for value: TVL
        /// </summary>
        [EnumMember(Value = "TVL")]
        TVL = 23,

        /// <summary>
        /// Enum TY for value: TY
        /// </summary>
        [EnumMember(Value = "TY")]
        BidType = 24,

        /// <summary>
        /// Enum CONTENT for value: CONTENT
        /// </summary>
        [EnumMember(Value = "CONTENT")]
        Content = 25

    }
}
