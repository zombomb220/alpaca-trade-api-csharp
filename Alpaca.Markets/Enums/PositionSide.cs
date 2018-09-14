// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Position side in Alpaca REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PositionSide
    {
        /// <summary>
        /// Long position.
        /// </summary>
        [EnumMember(Value = "long")]
        Long,

        /// <summary>
        /// Short position.
        /// </summary>
        [EnumMember(Value = "short")]
        Short
    }
}