using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qualnet.Web
{
    public static class RawCoalSiloExtensions
    {
        public static ViewModels.SiloViewModel ToViewModel(this TheUnifiedNamespace.Models.RawCoalSilo siloData, double? inputTonsPerHour = null)
        {
            return new ViewModels.SiloViewModel()
            {
                Capacity = siloData?.MaxCapacityTons ?? 0,
                FillPercentage = (siloData?.PercentFilled ?? 0) / 100,
                ReclaimTonsPerHour = siloData?.ScaleTonsPerHour,
                ReclaimTonsPerHourLabelColor = (siloData?.ScaleTonsPerHour).ToSiloTphLabelColor(),
                SiloFunnelColor = siloData?.FeederIsRunning.ToSiloFunnelColor(),
                InputTonsPerHour = inputTonsPerHour,
                IsBeingLoaded = siloData?.IsBeingLoaded,
            };
        }
    }
}
