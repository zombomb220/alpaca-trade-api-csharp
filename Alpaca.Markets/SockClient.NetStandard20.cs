// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
#if NETSTANDARD2_0

using Microsoft.Extensions.Configuration;

namespace Alpaca.Markets
{
    public sealed partial class SockClient
    {
        /// <summary>
        /// Creates new instance of <see cref="SockClient"/> object.
        /// </summary>
        /// <param name="configuration">Application configuration.</param>
        public SockClient(
            IConfiguration configuration)
            : this(
                configuration["keyId"],
                configuration["secretKey"],
                configuration["alpacaRestApi"])
        {
        }
    }
}

#endif
