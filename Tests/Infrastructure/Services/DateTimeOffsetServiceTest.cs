using System;
using mekkl.Infrastructure.Services;
using Xunit;

namespace mekkl.Tests.Infrastructure.Services
{
    public class DateTimeOffsetServiceTest
    {
        [Fact]
        public void Test()
        {
            var service = new DateTimeOffsetService();

            var result = service.UtcNow;

            Assert.Equal(DateTimeOffset.Now.Year, result.Year);
        }
    }
}