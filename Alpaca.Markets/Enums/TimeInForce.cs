// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Supported order durations in Alpaca REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeInForce
    {
        /// <summary>
        /// Daily order.
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Good-till-cancal order.
        /// </summary>
        [EnumMember(Value = "gtc")]
        Gtc,

        /// <summary>
        /// Market-on-open order.
        /// </summary>
        [EnumMember(Value = "opg")]
        Opg
    }
}