﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal sealed class JsonHistoricalQuote : IHistoricalQuote
    {
        [JsonProperty(PropertyName = "bE", Required = Required.Always)]
        public String BidExchange { get; set; }

        [JsonProperty(PropertyName = "aE", Required = Required.Always)]
        public String AskExchange { get; set; }

        [JsonProperty(PropertyName = "bP", Required = Required.Default)]
        public Decimal BidPrice { get; set; }

        [JsonProperty(PropertyName = "aP", Required = Required.Default)]
        public Decimal AskPrice { get; set; }

        [JsonProperty(PropertyName = "bS", Required = Required.Default)]
        public Int64 BidSize { get; set; }

        [JsonProperty(PropertyName = "aS", Required = Required.Default)]
        public Int64 AskSize { get; set; }

        [JsonProperty(PropertyName = "t", Required = Required.Always)]
        public Int64 TimeOffset { get; set; }
    }
}