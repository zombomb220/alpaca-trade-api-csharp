// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates single trading day information from Alpaca REST API.
    /// </summary>
    public interface ICalendar
    {
        /// <summary>
        /// Gets trading date (in UTC time zone).
        /// </summary>
        DateTime TradingDate { get; }

        /// <summary>
        /// Gets trading date open time (in UTC time zone).
        /// </summary>
        DateTime TradingOpenTime { get; }

        /// <summary>
        /// Gets trading date close time (in UTC time zone).
        /// </summary>
        DateTime TradingCloseTime { get; }
    }
}