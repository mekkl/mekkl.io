using System;

namespace mekkl.Application.Common.Interfaces.Services
{
    public interface IDateTimeOffsetService
    {
        public DateTimeOffset UtcNow { get; }
    }
}