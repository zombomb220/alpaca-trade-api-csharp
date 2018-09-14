// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Threading.Tasks;
using Xunit;

namespace Alpaca.Markets.Tests
{
    public sealed class RestClientExtendedTest : IDisposable
    {
        private readonly RestClient _restClient = ClientsFactory.GetRestClient();

        [Fact]
        public async void ListHistoricalQuotesReturnsEmptyListForSunday()
        {
            var historicalItems = await _restClient
                .ListHistoricalQuotesAsync("AAPL", new DateTime(2018, 8, 5));

            Assert.NotNull(historicalItems);

            Assert.NotNull(historicalItems.Items);
            Assert.Empty(historicalItems.Items);
        }

        [Fact]
        public async void ListDayAggregatesForSpecificDatesWorks()
        {
            var dateInto = DateTime.Today;
            var dateFrom = dateInto.AddDays(-7);

            var historicalItems = await _restClient
                .ListDayAggregatesAsync("AAPL", dateFrom, dateInto);

            Assert.NotNull(historicalItems);

            Assert.NotNull(historicalItems.Items);
            Assert.NotEmpty(historicalItems.Items);
        }

        [Fact]
        public async void ListMinuteAggregatesForSpecificDatesWorks()
        {
            var dateInto = DateTime.Today;
            var dateFrom = dateInto.AddDays(-7);

            var historicalItems = await _restClient
                .ListMinuteAggregatesAsync("AAPL", dateFrom, dateInto, 100);

            Assert.NotNull(historicalItems);

            Assert.NotNull(historicalItems.Items);
            Assert.NotEmpty(historicalItems.Items);
        }

        [Fact]
        public void AlpacaRestApiThrottlingWorks()
        {
            var tasks = new Task[300];
            for (var i = 0; i < tasks.Length; ++i)
            {
                tasks[i] = _restClient.GetClockAsync();
            }

            Task.WaitAll(tasks);
            Assert.DoesNotContain(tasks, task => task.IsFaulted);
        }

        public void Dispose()
        {
            _restClient?.Dispose();
        }
    }
}
