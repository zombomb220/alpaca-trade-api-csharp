// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Threading;
using Xunit;

namespace Alpaca.Markets.Tests
{
    public sealed class SockClientTest
    {
        [Fact]
        public async void ConnectWorks()
        {
            using (var client = ClientsFactory.GetSockClient())
            {
                client.OnError += (ex) =>
                {
                    Assert.Null(ex.Message);
                };

                await client.ConnectAsync();

                var waitObject = new AutoResetEvent(false);
                client.Connected += (status) =>
                {
                    Assert.Equal(AuthStatus.Authorized, status);
                    waitObject.Set();
                };

                Assert.True(waitObject.WaitOne(
                    TimeSpan.FromSeconds(10)));

                await client.DisconnectAsync();
            }
        }
    }
}
