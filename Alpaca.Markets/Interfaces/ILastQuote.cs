﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates last quote information from Alpaca REST API.
    /// </summary>
    public interface ILastQuote
    {
        /// <summary>
        /// Gets quote response status.
        /// </summary>
        String Status { get; }

        /// <summary>
        /// Gets asset name for last quote.
        /// </summary>
        String Symbol { get; }

        /// <summary>
        /// Gets identifier of bid source exchange.
        /// </summary>
        Int64 BidExchange { get; }

        /// <summary>
        /// Gets identifier of ask source exchange.
        /// </summary>
        Int64 AskExchange { get; }

        /// <summary>
        /// Gets bid price level.
        /// </summary>
        Decimal BidPrice { get; }

        /// <summary>
        /// Gets ask price level.
        /// </summary>
        Decimal AskPrice { get; }

        /// <summary>
        /// Gets bid quantity.
        /// </summary>
        Int64 BidSize { get; }

        /// <summary>
        /// Gets ask quantity.
        /// </summary>
        Int64 AskSize { get; }

        /// <summary>
        /// Gets last quote timestamp.
        /// </summary>
        DateTime Time { get; }
    }
}