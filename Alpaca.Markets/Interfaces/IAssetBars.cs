﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Collections.Generic;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates read-only access for bars in Alpaca REST API.
    /// </summary>
    public interface IAssetBars
    {
        /// <summary>
        /// Gets unique asset identifier for all bars in container.
        /// </summary>
        Guid AssetId { get; }

        /// <summary>
        /// Gets unique asset name for all bars in container.
        /// </summary>
        String Symbol { get; }

        /// <summary>
        /// Gets unique asset exchange for all bars in container.
        /// </summary>
        Exchange Exchange { get; }

        /// <summary>
        /// Gets unique asset class for all bars in container.
        /// </summary>
        AssetClass AssetClass { get; }

        /// <summary>
        /// Gets read-only collection of bar items.
        /// </summary>
        IReadOnlyList<IBar> Items { get; }
    }
}