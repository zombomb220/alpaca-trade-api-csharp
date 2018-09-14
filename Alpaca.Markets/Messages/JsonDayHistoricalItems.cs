// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal sealed class JsonDayHistoricalItems<TApi, TJson>
        : JsonHistoricalItems<TApi, TJson> , IDayHistoricalItems<TApi> where TJson : TApi
    {
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty(PropertyName = "day", Required = Required.Always)]
        public DateTime ItemsDay { get; set; }

        [JsonProperty(PropertyName = "msLatency", Required = Required.Always)]
        public Int64 LatencyInMs { get; set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(
            StreamingContext context)
        {
            ItemsDay = DateTime.SpecifyKind(
                ItemsDay.Date, DateTimeKind.Utc);
        }
    }
}