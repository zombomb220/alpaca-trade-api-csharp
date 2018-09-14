﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates list of single day historical itmes from Polygon REST API.
    /// </summary>
    /// <typeparam name="TItem">Type of historical items inside this container.</typeparam>
    public interface IDayHistoricalItems<out TItem> : IHistoricalItems<TItem>
    {
        /// <summary>
        /// Gets historical items day.
        /// </summary>
        DateTime ItemsDay { get; }

        /// <summary>
        /// Gets data latency in milliseconds.
        /// </summary>
        Int64 LatencyInMs { get; }
    }
}