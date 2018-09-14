﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
#if NETSTANDARD2_0

using System;
using Microsoft.Extensions.Configuration;

namespace Alpaca.Markets
{
    public sealed partial class RestClient
    {
        /// <summary>
        /// Creates new instance of <see cref="RestClient"/> object.
        /// </summary>
        /// <param name="configuration">Application configuration.</param>
        public RestClient(
            IConfiguration configuration)
            : this(
                configuration["keyId"],
                configuration["secretKey"],
                configuration["alpacaRestApi"],
                configuration["polygonRestApi"],
                Convert.ToBoolean(configuration["staging"] ?? "false"))
        {
        }
    }
}

#endif