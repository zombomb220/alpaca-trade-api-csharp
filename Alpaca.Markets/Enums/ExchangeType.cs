// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Supported exchange types in Polygon REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExchangeType
    {
        /// <summary>
        /// Ordinal exchange.
        /// </summary>
        [EnumMember(Value = "exchange")]
        Exchange,

        /// <summary>
        /// Banking organization.
        /// </summary>
        [EnumMember(Value = "banking")]
        Banking,

        /// <summary>
        /// Trade reporting facility.
        /// </summary>
        [EnumMember(Value = "TRF")]
        TradeReportingFacility
    }
}