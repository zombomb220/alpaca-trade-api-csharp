﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates last quote information from Alpaca REST API.
    /// </summary>
    public interface IQuote
    {
        /// <summary>
        /// Gets asset identifier.
        /// </summary>
        Guid AssetId { get; }

        /// <summary>
        /// Gets asset name.
        /// </summary>
        String Symbol { get; }

        /// <summary>
        /// Gets asset class.
        /// </summary>
        AssetClass AssetClass { get; }

        /// <summary>
        /// Gets bid price level.
        /// </summary>
        Decimal BidPrice { get; }

        /// <summary>
        /// Gets bid timestamp.
        /// </summary>
        DateTime BidTime { get; }

        /// <summary>
        /// Gets ask price level.
        /// </summary>
        Decimal AskPrice { get; }

        /// <summary>
        /// Gets ask timestamp.
        /// </summary>
        DateTime AskTime { get; }

        /// <summary>
        /// Gets last trade price level.
        /// </summary>
        Decimal LastPrice { get; }

        /// <summary>
        /// Gets last trade timestamp.
        /// </summary>
        DateTime LastTime { get; }

        /// <summary>
        /// Gets current day change in percent.
        /// </summary>
        Decimal DayChange { get; }
    }
}