// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal sealed class JsonAuthRequest
    {
        internal sealed class JsonData
        {
            [JsonProperty(PropertyName = "key_id", Required = Required.Always)]
            public String KeyId { get; set; }

            [JsonProperty(PropertyName = "secret_key", Required = Required.Always)]
            public String SecretKey { get; set; }
        }

        [JsonProperty(PropertyName = "action", Required = Required.Always)]
        public JsonAction Action { get; set; }

        [JsonProperty(PropertyName = "data", Required = Required.Always)]
        public JsonData Data { get; set; }
    }
}