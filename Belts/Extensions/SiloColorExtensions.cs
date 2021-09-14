using System;

namespace Qualnet.Web
{
    public static class SiloColorExtensions
    {
        private const string _legendColorPlant1 = "#FF00FF";
        private const string _legendColorPlant2 = "teal";
        private const string _legendColorPlantBoth = "lime";
        private const string _legendColorPlantUnknown = "gray";

        /// <remarks>use for both Sabia and eti</remarks>
        public static string ToAnalyzerIntervalColor(this TimeSpan? interval)
        {
            /*
            function _interval_color(interval) {
               if (alert(interval)) return;

               if (interval > (60 * 4)) return "maroon";
               if (interval > (60 * 2)) return "yellow";
               return "black";
            }*/
            if (interval.HasValue)
            {
                var minutes = interval.Value.TotalMinutes;

                //more than 4 mins
                if (minutes > 4)
                    return "maroon";
                else if (minutes > 2)
                    return "yellow";
                else
                    return "black";
            }
            else
            {
                return string.Empty;
            }
        }

        public static string ToSiloTphLabelColor(this double? tph)
        {
            return ColorFromSiloTPH(tph);
        }
        public static string ToSiloTphLabelColor(this double tph)
        {
            return ColorFromSiloTPH(tph);
        }
        private static string ColorFromSiloTPH(double? tph)
        {
            switch (tph)
            {
                case null:
                case 0:
                case < 0:
                    return "red";
                default:
                    return "yellow";
            }
        }

        public static string ToSiloFunnelColor(this bool value)
        {
            return ToSiloFunnelColor((bool?)value);
        }
        public static string ToSiloFunnelColor(this bool? value)
        {
            if (!value.HasValue)
                return "gray";
            else if (value == true)
                return "lime";
            else
                return "white";
        }
        public static string ToSiloFunnelColor(this int value)
        {
            return ToSiloFunnelColor((int?)value);
        }
        public static string ToSiloFunnelColor(this int? value)
        {
            if (!value.HasValue)
                return "gray";
            else if (value == 1)
                return "lime";
            else
                return "white";
        }

        public static string ToPlantLayerColor(this TheUnifiedNamespace.Models.CleanCoalLayer layer)
        {
            if (layer.LayerTonsFromPlant1 > 0 && layer.LayerTonsFromPlant2 > 0)
            {
                return _legendColorPlantBoth;
            }
            else if (layer.LayerTonsFromPlant1 > 0)
            {
                return _legendColorPlant1;
            }
            else if (layer.LayerTonsFromPlant2 > 0)
            {
                return _legendColorPlant2;
            }
            else
            {
                return _legendColorPlantUnknown;
            }
        }

        public static string ToSulfurLayerColor(this double value)
        {
            return ((double?)value).ToSulfurLayerColor();
        }

        public static string ToSulfurLayerColor(this double? value)
        {
            if (!value.HasValue || value < 0.01)//0 and null are both the same, basically no reading
                return "gray";

            if (value < 1.5)
                return "#0066FF";
            else if (value < 1.75)
                return "#00CCFF";
            else if (value < 2.0)
                return "#00FF66";
            else if (value < 2.25)
                return "#FFCC00";
            else if (value < 2.5)
                return "#FF6600";
            else if (value < 2.75)
                return "#FF6680";
            else
                return "#FF002B";
        }

        public static string ToLayerFillColor(this TheUnifiedNamespace.Models.CleanCoalLayer layer, Pages.CleanSilosModel.QualityOption quality)
        {
            switch (quality)
            {
                case Pages.CleanSilosModel.QualityOption.Sulfur:
                    return (layer.AverageSulfur.Round(digits: 2)).ToSulfurLayerColor();

                default:
                    //sulfur has it's own color scheme, all others color based on which plant(s) it comes from
                    return layer.ToPlantLayerColor();
            }
        }
    }
}
