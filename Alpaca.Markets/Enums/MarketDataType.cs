// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Supported asset types in Polygon REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketDataType
    {
        /// <summary>
        /// Equities.
        /// </summary>
        [EnumMember(Value = "equities")]
        Equities,

        /// <summary>
        /// Indexes.
        /// </summary>
        [EnumMember(Value = "indecies")]
        Indexes,

        /// <summary>
        /// Currencies.
        /// </summary>
        [EnumMember(Value = "currencies")]
        Currencies
    }
}