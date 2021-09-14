namespace Qualnet.Web
{
    public static class ColorExtensions
    {

        /// <summary>
        /// used for the most generic color palette of green means good, red means bad, and yellow means undetermined
        /// </summary>
        /// <param name="value"></param>
        /// <param name="normalize">when false anything greater than 1 is considered bad;  when true, values greater than one are assumed to be ok and will be treated as 1/good</param>
        /// <returns></returns>
        public static string ToRedYellowGreen(this int value, bool normalize = false)
        {
            return ColorByStatus(value, normalize);
        }
        /// <summary>
        /// used for the most generic color palette of green means good, red means bad, and yellow means undetermined
        /// </summary>
        /// <param name="value"></param>
        /// <param name="normalize">when false anything greater than 1 is considered bad;  when true, values greater than one are assumed to be ok and will be treated as 1/good</param>
        /// <returns></returns>
        public static string ToRedYellowGreen(this int? value, bool normalize = false)
        {
            return ColorByStatus(value, normalize);
        }

        private static string ColorByStatus(int? status, bool normalize = false)
        {
            switch (status)
            {
                case null:
                    return "yellow";
                case 1:
                    return "lime";
                case > 1:
                    if (normalize)
                        return "lime";
                    else
                        return "yellow";
                default:
                    return "red";
            }
        }

        /// <summary>
        /// used for the most generic color palette of green means good, red means bad, and yellow means undetermined
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToRedYellowGreen(this bool value)
        {
            return ColorFromBeltStatus(value);
        }
        /// <summary>
        /// used for the most generic color palette of green means good, red means bad, and yellow means undetermined
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToRedYellowGreen(this bool? value)
        {
            return ColorFromBeltStatus(value);
        }

        /// <summary>
        /// used for the most generic color palette of green means good, red means bad, and yellow means undetermined
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string ColorFromBeltStatus(bool? beltStatus)
        {
            switch (beltStatus)
            {
                case null:
                    return "yellow";
                case true:
                    return "lime";
                case false:
                default:
                    return "red";
            }
        }
    }
}
