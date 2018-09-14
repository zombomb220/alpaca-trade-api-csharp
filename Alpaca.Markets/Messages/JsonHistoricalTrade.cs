// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal class JsonHistoricalTrade : IHistoricalTrade
    {
        [JsonProperty(PropertyName = "e", Required = Required.Always)]
        public String Exchange { get; set; }

        [JsonProperty(PropertyName = "t", Required = Required.Always)]
        public Int64 TimeOffset { get; set; }

        [JsonProperty(PropertyName = "p", Required = Required.Always)]
        public Decimal Price { get; set; }

        [JsonProperty(PropertyName = "s", Required = Required.Default)]
        public Int64 Size { get; set; }
    }
}