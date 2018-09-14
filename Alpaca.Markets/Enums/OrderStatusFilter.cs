// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Order statuses filter for <see cref="RestClient.ListOrdersAsync"/> call from Alpaca REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderStatusFilter
    {
        /// <summary>
        /// Returns only open orders.
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Returns only closed orders.
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,

        /// <summary>
        /// Returns all orders.
        /// </summary>
        [EnumMember(Value = "all")]
        All
    }
}