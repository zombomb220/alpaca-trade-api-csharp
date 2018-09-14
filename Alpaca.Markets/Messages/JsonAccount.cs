﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    internal sealed class JsonAccount : IAccount
    {
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public Guid AccountId { get; set; }

        [JsonProperty(PropertyName = "status", Required = Required.Always)]
        public AccountStatus Status { get; set; }

        [JsonProperty(PropertyName = "currency", Required = Required.Default)]
        public String Currency { get; set; }

        [JsonProperty(PropertyName = "cash", Required = Required.Always)]
        public Decimal TradableCash { get; set; }

        [JsonProperty(PropertyName = "cash_withdrawable", Required = Required.Always)]
        public Decimal WithdrawableCash { get; set; }

        [JsonProperty(PropertyName = "portfolio_value", Required = Required.Always)]
        public Decimal PortfolioValue { get; set; }

        [JsonProperty(PropertyName = "pattern_day_trader", Required = Required.Always)]
        public Boolean IsDayPatternTrader { get; set; }

        [JsonProperty(PropertyName = "trading_blocked", Required = Required.Always)]
        public Boolean IsTradingBlocked { get; set; }

        [JsonProperty(PropertyName = "transfers_blocked", Required = Required.Always)]
        public Boolean IsTransfersBlocked { get; set; }

        [JsonProperty(PropertyName = "account_blocked", Required = Required.Always)]
        public Boolean IsAccountBlocked { get; set; }

        [JsonProperty(PropertyName = "created_at", Required = Required.Always)]
        public DateTime CreatedAt { get; set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(
            StreamingContext context)
        {
            if (String.IsNullOrEmpty(Currency))
            {
                Currency = "USD";
            }
        }
    }
}