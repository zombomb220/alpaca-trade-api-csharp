// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    internal interface IThrottler
    {
        /// <summary>
        /// Gets flag indicating we are currently being rate limited.
        /// </summary>
        Int32 MaxAttempts { get; }

        /// <summary>
        /// Blocks the current thread indefinitely until allowed to proceed.
        /// </summary>
        void WaitToProceed();
    }
}