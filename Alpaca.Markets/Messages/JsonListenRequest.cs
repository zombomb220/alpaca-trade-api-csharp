// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal sealed class JsonListenRequest
    {
        internal sealed class JsonData
        {
            [JsonProperty(PropertyName = "streams", Required = Required.Always)]
            public List<String> Streams { get; set; }
        }

        [JsonProperty(PropertyName = "action", Required = Required.Always)]
        public JsonAction Action { get; set; }

        [JsonProperty(PropertyName = "data", Required = Required.Always)]
        public JsonData Data { get; set; }
    }
}