// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    internal sealed class TimeConverter : IsoDateTimeConverter
    {
        public TimeConverter()
        {
            DateTimeStyles = DateTimeStyles.AssumeLocal;
            DateTimeFormat = "HH:mm";
        }
    }
}