﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Exchanges supported by Alpaca REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Exchange
    {
        /// <summary>
        /// NYSE American Stock Exchange.
        /// </summary>
        [EnumMember(Value = "NYSEMKT")]
        NyseMkt,

        /// <summary>
        /// NYSE Arca Stock Exchange.
        /// </summary>
        [EnumMember(Value = "NYSEARCA")]
        NyseArca,

        /// <summary>
        /// New York Stock Exchange (NYSE)
        /// </summary>
        [EnumMember(Value = "NYSE")]
        Nyse,

        /// <summary>
        /// Nasdaq Stock Market.
        /// </summary>
        [EnumMember(Value = "NASDAQ")]
        Nasdaq,

        /// <summary>
        /// BATS Global Market.
        /// </summary>
        [EnumMember(Value = "BATS")]
        Bats,

        /// <summary>
        /// American Stock Exchange (AMEX)
        /// </summary>
        [EnumMember(Value = "AMEX")]
        Amex,

        /// <summary>
        /// Archipelago Stock Exchagne (ARCA).
        /// </summary>
        [EnumMember(Value = "ARCA")]
        Arca
    }
}