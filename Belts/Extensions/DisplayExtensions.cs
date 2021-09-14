using Qualnet.Web.FluentCanvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualnet.Web
{
    public static class DisplayExtensions
    {
        public static string ToYesNo(this bool value)
        {
            return ToYesNo((bool?)value);
        }
        public static string ToYesNo(this bool? value, string nullDisplayValue = "")
        {
            switch (value)
            {
                case true:
                    return "Yes";
                case false:
                    return "No";
                case null:
                    return nullDisplayValue;
            }
        }

        public static string ToNumberDisplay(this int value)
        {
            return ToNumberDisplay((int?)value);
        }
        public static string ToNumberDisplay(this int? value, string nullDisplayValue = "", string format = "###,###,###,##0")
        {
            return value?.ToString(format) ?? nullDisplayValue;
        }
        public static string ToNumberDisplay(this double value, string format = "###,###,###,##0.########")
        {
            return value.ToString(format);
        }
        public static string ToNumberDisplay(this double? value, string nullDisplayValue = "", string format = "###,###,###,##0.########")
        {
            return value?.ToString(format) ?? nullDisplayValue;
        }
        public static string ToWeightDisplay(this int? value, string nullDisplayValue = "")
        {
            //i'm not using "n" because i want to hide .00 so we don't waste anymore realestate than needed
            return value?.ToString("###,###,###,##0.########") ?? nullDisplayValue;
        }

        public static string ToWeightDisplay(this int value)
        {
            return ToWeightDisplay((int?)value);
        }

        public static string ToWeightDisplay(this double? value, string nullDisplayValue = "")
        {
            //i'm not using "n" because i want to hide .00 so we don't waste anymore realestate than needed
            return value?.ToString("###,###,###,##0.########") ?? nullDisplayValue;
        }

        /// <summary>
        /// applies a string format to the number which gives a good display for weight/tonnage
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToWeightDisplay(this double value)
        {
            return ToWeightDisplay((double?)value);
        }

        public static string ToPercentageDisplay(this double? value, string nullDisplayValue = "", int? digits = null)
        {
            
            if (value.HasValue && double.IsNaN(value.Value))
            {
                return nullDisplayValue;
            }
            if (digits.HasValue)
            {
                return value?.ToString($"P{digits}") ?? nullDisplayValue;
            }
            else
            {
                //i'm not using "P" because i want to hide .00 so we don't waste anymore realestate than needed
                return value?.ToString("0.####%") ?? nullDisplayValue;
            }
        }

        public static string ToPercentageDisplay(this double value, int? digits = null)
        {
            return ToPercentageDisplay((double?)value, digits: digits);
        }

        public static string ToPercentageDisplay(this decimal? value, int? digits = null)
        {
            if (digits.HasValue)
            {
                return value?.ToString($"P{digits}");
            }
            else
            {
                //i'm not using "P" because i want to hide .00 so we don't waste anymore realestate than needed
                return value?.ToString("0.####%");
            }
        }

        public static string ToPercentageDisplay(this decimal value, int? digits = null)
        {
            return ToPercentageDisplay((decimal?)value, digits: digits);
        }

        public static string ToPercentageDisplay(this int? value, int? digits = null)
        {
            if (digits.HasValue)
            {

                return value?.ToString($"P{digits}");
            }
            else
            {
                //i'm not using "P" because i want to hide .00 so we don't waste anymore realestate than needed
                return value?.ToString("0%");
            }
        }

        public static string ToPercentageDisplay(this int value, int? digits = null)
        {
            return ToPercentageDisplay((int?)value, digits: digits);
        }

        public static string ToHtmlInputDateStringOrEmpty(this DateTime? value, string nullDisplayValue = null)
        {
            if (value.HasValue)
                return value.Value.ToHtmlInputDateString();
            else
                return nullDisplayValue;
        }

        public static string ToHtmlInputDateString(this DateTime value)
        {
            return value.ToString("yyyy-MM-dd");
        }

        public static string ToHtmlInputDateAndTimeStringOrEmpty(this DateTime? value, string nullDisplayValue = null)
        {
            if (value.HasValue)
                return value.Value.ToHtmlInputDateAndTimeStringOrEmpty();
            else
                return nullDisplayValue;
        }

        public static string ToHtmlInputDateAndTimeStringOrEmpty(this DateTime value)
        {
            return value.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        public static string ToShortDateStringOrEmpty(this DateTime? value, string nullDisplayValue = null)
        {
            if (value.HasValue)
                return value.Value.ToShortDateString();
            else
                return nullDisplayValue;
        }

        public static string ToLongDateStringOrEmpty(this DateTime? value, string nullDisplayValue = null)
        {
            if (value.HasValue)
                return value.Value.ToLongDateString();
            else
                return nullDisplayValue;
        }


        public static string ToDateStringOrEmpty(this DateTime? value, string format, string nullDisplayValue = null)
        {
            if (value.HasValue)
                return value.Value.ToString(format);
            else
                return nullDisplayValue;
        }

        public static string ToDateStringOrEmpty(this DateTimeOffset? value, string format, string nullDisplayValue = null)
        {
            if (value.HasValue)
                return value.Value.ToString(format);
            else
                return nullDisplayValue;
        }
        public static string ToHourMinuteDurationDisplay(this TimeSpan timeSpan)
        {
            string hours = ((int)timeSpan.TotalHours).ToString("00");
            string minutes = ((int)timeSpan.Minutes).ToString("00");
            return $"{hours}:{minutes}";
        }
    }
}
