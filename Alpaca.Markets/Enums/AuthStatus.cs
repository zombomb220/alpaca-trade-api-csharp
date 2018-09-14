// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Authorization status for Alpaca streaming API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthStatus
    {
        /// <summary>
        /// Client successfully authorized.
        /// </summary>
        [EnumMember(Value = "authorized")]
        Authorized,

        /// <summary>
        /// Client does not authorized.
        /// </summary>
        [EnumMember(Value = "unauthorized")]
        Unauthorized
    }
}