using LOMS.Service.Contract;
using System;

namespace LOMS.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}