using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belts.Services
{
    public class BuildHarvey
    {
        public void Build(List<Pages.Belt> LongWallBelts, List<Pages.Belt> CMBelts, List<Pages.Belt> MainBelts, List<Pages.BeltAvail> BeltAvailability)
        {
            LongWallBelts.Add(new Pages.Belt { Name = "5B", Type = "LW", State = "ON", TimeOn = "6:29", TimeOff = "5:23", Uncertain = "0:00" });

            CMBelts.Add(new Pages.Belt { Name = "4B", Type = "CM", State = "ON", TimeOn = "6:29", TimeOff = "5:23", Uncertain = "0:00" });

            MainBelts.Add(new Pages.Belt { Name = "Silo", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "Slope", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "1Mother", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "2Mother", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "3Mother", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "4Mother", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "5Mother", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "7N1", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "7N2", Type = "Main", State = "ON", TimeOn = "11:52", TimeOff = "0:00", Uncertain = "0:00" });

            BeltAvailability.Add(new Pages.BeltAvail { Name = "1Mother", TimeOn = "32:26", TimeOff = "3:26", Uncertain = "0:00", Availability = "90.4%", MaxAvailability = "90.4%", MinAvailability = "90.4%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "2Mother", TimeOn = "32:26", TimeOff = "3:26", Uncertain = "0:00", Availability = "90.4%", MaxAvailability = "90.4%", MinAvailability = "90.4%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "3Mother", TimeOn = "32:26", TimeOff = "3:26", Uncertain = "0:00", Availability = "90.4%", MaxAvailability = "90.4%", MinAvailability = "90.4%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "4Mother", TimeOn = "32:26", TimeOff = "3:26", Uncertain = "0:00", Availability = "90.4%", MaxAvailability = "90.4%", MinAvailability = "90.4%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "5Mother", TimeOn = "32:26", TimeOff = "3:26", Uncertain = "0:00", Availability = "90.4%", MaxAvailability = "90.4%", MinAvailability = "90.4%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "7N1", TimeOn = "32:26", TimeOff = "3:26", Uncertain = "0:00", Availability = "90.4%", MaxAvailability = "90.4%", MinAvailability = "90.4%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "7N2", TimeOn = "32:26", TimeOff = "3:26", Uncertain = "0:00", Availability = "90.4%", MaxAvailability = "90.4%", MinAvailability = "90.4%" });
        }

    }
}
