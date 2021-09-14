namespace Qualnet.Web
{
    public static class RawCoalBunkerExtensions
    {
        public static ViewModels.SiloViewModel ToViewModel(this TheUnifiedNamespace.Models.RawCoalBunker bunker)
        {
            return new ViewModels.SiloViewModel()
            {
                Capacity = bunker?.MaxCapacityTons ?? 0,
                FillPercentage = (bunker?.OverallPercentFilled ?? 0) / 100,
                ReclaimTonsPerHour = bunker?.ScaleTonsPerHour,
                ReclaimTonsPerHourLabelColor = (bunker?.ScaleTonsPerHour).ToSiloTphLabelColor()
            };
        }
    }
}
