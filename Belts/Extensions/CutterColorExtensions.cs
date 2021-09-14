using System;

namespace Qualnet.Web
{
    public static class CutterColorExtensions
    {
        public static string ToCutterColor(this DateTime value)
        {
            return ToCutterColor((DateTime?)value);
        }
        public static string ToCutterColor(this DateTime? value)
        {
            if (!value.HasValue)
                return "yellow";

            //the orginal qualnet used a cached value and compared the current value to that cache
            //   if it had changed then it was running
            //   the new version i'm just checking if it's cut was in the last X seconds then it's running
            if (DateTime.Now.Subtract(value.Value).TotalSeconds < 5)
            {
                return "lime";
            }
            else
            {
                return "red";
            }

        }

    }
}
