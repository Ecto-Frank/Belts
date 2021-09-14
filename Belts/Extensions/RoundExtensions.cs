using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualnet.Web
{
    public static class RoundExtensions
    {
        public static double? Round(this double? value, int digits)
        {
            if (value.HasValue && double.IsNaN(value.Value))
            {
                return null;
            }

            if (value.HasValue)
                return value.Value.Round(digits);
            else
                return null;
        }
        public static double Round(this double value, int digits)
        {
            return Math.Round(value, digits: digits, mode: MidpointRounding.AwayFromZero);
        }

        public static int RoundToInt(this double value)
        {
            return (int)RoundExtensions.Round(value, digits: 0);
        }

        public static string RoundAndDisplay(this double? value, int digits, string nullDisplayValue = null)
        {


            if (!value.HasValue && nullDisplayValue != null)
                return nullDisplayValue;
            value = value.Round(digits);

            return value.ToNumberDisplay(format: $"N{digits}");
        }

        public static string RoundAndDisplay(this double value, int digits)
        {
            value = value.Round(digits);

            return value.ToNumberDisplay(format: $"N{digits}");
        }

    }
}
