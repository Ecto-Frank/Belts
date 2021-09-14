namespace Qualnet.Web
{
    public static class ScaleColorExtensions
    {
        public static string ToScaleTphLabelColor(this double tph)
        {
            return ColorFromScaleTPH(tph);
        }

        public static string ToScaleTphLabelColor(this double? tph)
        {
            return ColorFromScaleTPH(tph);
        }

        private static string ColorFromScaleTPH(double? tph)
        {
            switch (tph)
            {
                case null:
                case 0:
                    return "red";

                case > 0.001:
                default:
                    return "yellow";
            }
        }
    }
}
