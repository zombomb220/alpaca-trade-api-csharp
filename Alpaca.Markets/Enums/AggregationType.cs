// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Historical data aggregation type in Alpaca REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AggregationType
    {
        /// <summary>
        /// Aggreagated data for single trading day.
        /// </summary>
        [EnumMember(Value = "daily")]
        Day,

        /// <summary>
        /// Aggregated data for single minute.
        /// </summary>
        [EnumMember(Value = "min")]
        Minute
    }
}