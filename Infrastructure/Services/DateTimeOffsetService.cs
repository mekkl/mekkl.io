using System;
using mekkl.Application.Common.Interfaces.Services;

namespace mekkl.Infrastructure.Services
{
    public class DateTimeOffsetService : IDateTimeOffsetService
    {
        public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    }
}