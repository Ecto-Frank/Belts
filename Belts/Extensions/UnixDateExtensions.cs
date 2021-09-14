using System;

namespace Qualnet.Web
{
    public static class UnixDateExtensions
    {
        public static DateTimeOffset UnixToDateTime(this long value)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(value);
        }

        public static DateTimeOffset? UnixToDateTime(this long? value)
        {
            if (!value.HasValue)
                return null;

            return UnixToDateTime(value.Value);
        }
    }
}
