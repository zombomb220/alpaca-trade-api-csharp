// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    internal static class CustomTimeZone
    {
        public static TimeZoneInfo Est { get; } =
            TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
    }
}
