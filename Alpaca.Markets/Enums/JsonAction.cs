// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum JsonAction
    {
        [EnumMember(Value = "authenticate")]
        Authenticate,

        [EnumMember(Value = "listen")]
        Listen
    }
}