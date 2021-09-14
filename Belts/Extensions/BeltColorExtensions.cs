namespace Qualnet.Web
{
    public static class BeltColorExtensions
    {
        public static string ToBeltColor(this int value, bool normalize = false)
        {
            //just using the generic setup
            return value.ToRedYellowGreen(normalize);
        }
        public static string ToBeltColor(this int? value, bool normalize = false)
        {
            //just using the generic setup
            return value.ToRedYellowGreen(normalize);
        }

        public static string ToBeltColor(this bool value)
        {
            //just using the generic setup
            return value.ToRedYellowGreen();
        }
        public static string ToBeltColor(this bool? value)
        {
            //just using the generic setup
            return value.ToRedYellowGreen();
        }
    }
}
