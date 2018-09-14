// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;

namespace Alpaca.Markets
{
    internal sealed class FakeThrottler : IThrottler
    {
        private FakeThrottler() { }

        public static IThrottler Instance { get; } = new FakeThrottler();

        public Int32 MaxAttempts => 1;

        public void WaitToProceed() { }
    }
}