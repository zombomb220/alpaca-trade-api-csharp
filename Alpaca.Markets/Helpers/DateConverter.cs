﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    internal sealed class DateConverter : IsoDateTimeConverter
    {
        public DateConverter()
            : this("yyyy-MM-dd")
        {
        }

        public DateConverter(String format)
        {
            DateTimeStyles = DateTimeStyles.AssumeLocal;
            DateTimeFormat = format;
        }
    }
}