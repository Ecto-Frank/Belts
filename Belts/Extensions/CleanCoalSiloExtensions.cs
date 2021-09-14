using System.Collections.Generic;
using System.Linq;

namespace Qualnet.Web
{
    public static class CleanCoalSiloExtensions
    {
        public static ViewModels.SiloViewModel ToViewModel(this TheUnifiedNamespace.Models.CleanSilo siloData,
            double? averageSulfur = null,
            IEnumerable<TheUnifiedNamespace.Models.PlantOutput> plantOutputs = null)
        {
            return new ViewModels.SiloViewModel()
            {
                Capacity = siloData?.Capacity ?? 0,
                FillPercentage = (siloData?.PercentFilled ?? 0) / 100,
                ReclaimTonsPerHour = siloData?.ScaleTonsPerHour,
                ReclaimTonsPerHourLabelColor = (siloData?.ScaleTonsPerHour).ToSiloTphLabelColor(),
                SiloFunnelColor = siloData?.FeederIsRunning.ToSiloFunnelColor(),

                AverageSulfur = averageSulfur,

                InputTonsPerHour = siloData != null && plantOutputs?.Any() == true
                                    ? plantOutputs.Where(x => x.ToSiloNumber == siloData.SiloNumber).SumOrDefault(x => x.TonsPerHour ?? 0)
                                    : null,
            };
        }

        public static double? AverageSulfur(this IEnumerable<TheUnifiedNamespace.Models.CleanCoalLayer> layers)
        {
            //total tonnage of layers with sulfur reading (so we can average)
            var layersWithSulfurReading = layers?
                    .Where(x => x.AverageSulfur.HasValue && x.LayerTonsTotal.HasValue && x.LayerTonsTotal.Value > 0)
                    .Select(x => new { Tons = x.LayerTonsTotal.Value, Sulfur = x.AverageSulfur.Value })
                    .ToList();
            var totalTons = layersWithSulfurReading?.Sum(x => x.Tons);

            //using the total tons, you can compute the overal average sulfur of the silo
            return layersWithSulfurReading?.Sum(x => x.Sulfur * (x.Tons / totalTons));
        }
        public static double? AnalyzedTonsRatio(this IEnumerable<TheUnifiedNamespace.Models.CleanCoalLayer> layers)
        {
            var totalTons = layers?.Sum(x => x.LayerTonsTotal ?? 0);
            var totalAnalyzed = layers?.Sum(x => x.TonsAnalyzed ?? 0);
            return totalAnalyzed / totalTons;
        }


        public static string ToSourcePlantText(this TheUnifiedNamespace.Models.CleanCoalLayer layer)
        {
            if (layer.LayerTonsFromPlant1 > 0 && layer.LayerTonsFromPlant2 > 0)
            {
                return "1,2";
            }
            else if (layer.LayerTonsFromPlant1 > 0)
            {
                return "1";
            }
            else if (layer.LayerTonsFromPlant2 > 0)
            {
                return "2";
            }
            else
            {
                return "";
            }
        }

    }
}
