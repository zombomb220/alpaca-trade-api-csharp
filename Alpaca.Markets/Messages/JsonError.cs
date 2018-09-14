// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal sealed class JsonError
    {
        [JsonProperty(PropertyName = "code", Required = Required.Always)]
        public Int32 Code { get; set; }

        [JsonProperty(PropertyName = "message", Required = Required.Always)]
        public String Message { get; set; }

    }
}
