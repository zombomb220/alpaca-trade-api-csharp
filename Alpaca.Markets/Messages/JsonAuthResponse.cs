// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal sealed class JsonAuthResponse
    {
        [JsonProperty(PropertyName = "action", Required = Required.Always)]
        public String Action { get; set; }

        [JsonProperty(PropertyName = "status", Required = Required.Always)]
        public AuthStatus Status { get; set; }
    }
}