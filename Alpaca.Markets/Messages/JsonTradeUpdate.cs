﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal sealed class JsonTradeUpdate : ITradeUpdate
    {
        // TODO: olegra - convert it into enum instead of free string
        [JsonProperty(PropertyName = "event", Required = Required.Always)]
        public String Event { get; set; }

        [JsonProperty(PropertyName = "price", Required = Required.Default)]
        public Decimal? Price { get; set; }

        [JsonProperty(PropertyName = "qty", Required = Required.Default)]
        public Int64? Quantity { get; set; }

        [JsonProperty(PropertyName = "timestamp", Required = Required.Default)]
        public DateTime Timestamp { get; set; }

        [JsonProperty(PropertyName = "order", Required = Required.Always)]
        public JsonOrder JsonOrder { get; set; }

        public IOrder Order => JsonOrder;
    }
}