// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Single asset status in Alpaca REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetStatus
    {
        /// <summary>
        /// Active asset.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Inactive asset.
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// Delisted asset.
        /// </summary>
        [EnumMember(Value = "delisted")]
        Delisted
    }
}