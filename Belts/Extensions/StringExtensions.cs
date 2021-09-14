using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualnet.Web
{
    public static class StringExtensions
    {
        public static DateTime? ToDateOrNull(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            DateTime dt;
            if (DateTime.TryParse(value, out dt))
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
        public static DateTime? ToDateOrNull(this string value, string exactFormat)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            var provider = System.Globalization.CultureInfo.InvariantCulture;
            DateTime dt;
            if (DateTime.TryParseExact(value, exactFormat, provider, System.Globalization.DateTimeStyles.None, out dt))
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
        public static bool? ToBoolOrNull(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            bool b;
            if (bool.TryParse(value, out b))
            {
                return b;
            }
            else
            {
                return null;
            }
        }


        public static int? ToIntOrNull(this string value, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Any)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            int i;
            if (int.TryParse(value, style: style, provider: null, out i))
            {
                return i;
            }
            else
            {
                return null;
            }
        }

        public static decimal? ToDecimalOrNull(this string value, bool supportCurrency = true)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            decimal d;
            if (supportCurrency)
            {
                if (decimal.TryParse(value, style: System.Globalization.NumberStyles.Any, provider: null, result: out d))
                {
                    return d;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (decimal.TryParse(value, out d))
                {
                    return d;
                }
                else
                {
                    return null;
                }
            }
        }
        public static double? ToDoubleOrNull(this string value, bool supportCurrency = true)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            double d;
            if (supportCurrency)
            {
                if (double.TryParse(value, style: System.Globalization.NumberStyles.Any, provider: null, result: out d))
                {
                    return d;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (double.TryParse(value, out d))
                {
                    return d;
                }
                else
                {
                    return null;
                }
            }
        }

        public static Guid? ToGuidOrNull(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            Guid g;
            if (Guid.TryParse(value, out g))
            {
                return g;
            }
            else
            {
                return null;
            }
        }

        public static string AppendIfNotNullOrEmpty(this string value, string appendingValue)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }
            else
            {
                return value + appendingValue;
            }
        }

        public static string TryInsert(this string input, int startIndex, string value)
        {
            if (input == null || input.Length <= startIndex)
            {
                return input;
            }
            else
            {
                return input.Insert(startIndex, value);
            }
        }
    }
}
