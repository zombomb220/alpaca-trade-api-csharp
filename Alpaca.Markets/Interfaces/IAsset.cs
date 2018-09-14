﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates asset information from Alpaca REST API.
    /// </summary>
    public interface IAsset
    {
        /// <summary>
        /// Gets unique asset identifier.
        /// </summary>
        Guid AssetId { get; }

        /// <summary>
        /// Gets asset class.
        /// </summary>
        AssetClass Class { get; }

        /// <summary>
        /// Gets asset source exchange.
        /// </summary>
        Exchange Exchange { get; }

        /// <summary>
        /// Gest asset name.
        /// </summary>
        String Symbol { get; }

        /// <summary>
        /// Get asset status in API.
        /// </summary>
        AssetStatus Status { get; }

        /// <summary>
        /// Returns <c>true</c> if asset is tradable.
        /// </summary>
        Boolean IsTradable { get; }
    }
}