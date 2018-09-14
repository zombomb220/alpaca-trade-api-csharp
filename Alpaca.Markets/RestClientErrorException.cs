// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Represents Alpaca/Polygon REST API specific error information.
    /// </summary>
    public sealed class RestClientErrorException : Exception
    {
        internal RestClientErrorException(
            JsonError error)
            : base(error.Message)
        {
            ErrorCode = error.Code;
        }

        /// <summary>
        /// Original error code returned by REST API endpoint.
        /// </summary>
        public Int32 ErrorCode { get; }
    }
}