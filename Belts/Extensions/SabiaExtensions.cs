using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualnet.Web
{
    public static class SabiaExtensions
    {
        public static string ToSabiaHealthDisplay(this int? errorCode)
        {

            return errorCode switch
            {
                1 => "Static",//status 1 means "low tonnage"
                0 => "Healthy",//status 0 means happy
                _ => "Sick"//everything else.... sickup
            };
        }
        public static string ToSabiaHealthColor(this int? errorCode)
        {

            return errorCode switch
            {
                1 => "yellow",//status 1 means "low tonnage"
                0 => "lime",//status 0 means happy
                _ => "red"//everything else.... sickup
            };
        }

        public static string ToSabiaHealthCss(this int? errorCode)
        {

            return errorCode switch
            {
                1 => "bg-warning",//status 1 means "low tonnage"
                0 => "bg-success",//status 0 means happy
                _ => "bg-danger"//everything else.... sickup
            };
        }

        public static string ToEtiLastValidAnalysisColor(this DateTime? lastValidAnalysis)
        {
            return !lastValidAnalysis.HasValue ? "" : DateTimeOffset.Now.Subtract(lastValidAnalysis.Value).TotalMinutes switch
            {
                > 4 => "text-danger",//more than 4 minutes
                > 2 => "text-warning",//more than 2 minutes
                _ => "text-success"
            };
        }
    }
}
