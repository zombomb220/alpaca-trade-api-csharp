// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates historical trade infromation from Polygon REST API.
    /// </summary>
    public interface IHistoricalTrade
    {
        /// <summary>
        /// Gets trade source exchange.
        /// </summary>
        String Exchange { get; }

        /// <summary>
        /// Gets trade timestamp.
        /// </summary>
        Int64 TimeOffset  { get; }

        /// <summary>
        /// Gets trade price.
        /// </summary>
        Decimal Price { get; }

        /// <summary>
        /// Gets trade quantity.
        /// </summary>
        Int64 Size { get; }
    }
}