﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal abstract class JsonHistoricalItems<TApi, TJson> where TJson : TApi
    {
        private static readonly IReadOnlyCollection<TApi> _empty = new TApi[0];

        [JsonProperty(PropertyName = "status", Required = Required.Default)]
        public String Status { get; set; }

        [JsonProperty(PropertyName = "symbol", Required = Required.Always)]
        public String Symbol { get; set; }

        [JsonProperty(PropertyName = "ticks", Required = Required.Default)]
        public List<TJson> ItemsList { get; set; }

        [JsonIgnore]
        public IReadOnlyCollection<TApi> Items =>
            (IReadOnlyCollection<TApi>)ItemsList ?? _empty;
    }
}