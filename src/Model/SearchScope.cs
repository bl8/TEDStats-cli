//
// Copyright 2020 Bertrand Lorentz
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System.Runtime.Serialization;

namespace TEDStats.Model
{
    /// <summary>
    /// Defines Fields
    /// </summary>
    public enum SearchScope
    {
        /// <summary>
        /// Latest Edition
        /// </summary>
        [EnumMember]
        LatestEdition = 1,

        /// <summary>
        /// Latest Edition
        /// </summary>
        [EnumMember]
        ActiveNotices = 2,

        /// <summary>
        /// Latest Edition
        /// </summary>
        [EnumMember]
        All = 3
    }
}