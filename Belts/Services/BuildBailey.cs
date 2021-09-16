using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belts.Services
{
    public class BuildBailey
    {
        public void Build(List<Pages.Belt> LongWallBelts, List<Pages.Belt> CMBelts, List<Pages.Belt> MainBelts, List<Pages.BeltAvail> BeltAvailability)
        {
            //LongWall Belts
            LongWallBelts.Add(new Pages.Belt { Name = "8L", Type = "LW", State = "OFF", TimeOn = "15:14", TimeOff = "1:21", Uncertain = "0:00" });
            LongWallBelts.Add(new Pages.Belt { Name = "11J", Type = "LW", State = "OFF", TimeOn = "13:28", TimeOff = "3:07", Uncertain = "0:00" });

            //CM Belts
            CMBelts.Add(new Pages.Belt { Name = "9L", Type = "CM", State = "OFF", TimeOn = "0:00", TimeOff = "16:35", Uncertain = "0:00" });
            CMBelts.Add(new Pages.Belt { Name = "12J", Type = "CM", State = "ON", TimeOn = "16:27", TimeOff = "0:08", Uncertain = "0:00" });
            CMBelts.Add(new Pages.Belt { Name = "KTG", Type = "CM", State = "ON", TimeOn = "16:04", TimeOff = "0:31", Uncertain = "0:00" });
            CMBelts.Add(new Pages.Belt { Name = "1K", Type = "CM", State = "ON", TimeOn = "15:53", TimeOff = "0:42", Uncertain = "0:00" });

            //Main Belts
            MainBelts.Add(new Pages.Belt { Name = "U57", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "U56", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "U55", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "SILOBELT", Type = "Mains", State = "ON", TimeOn = "16:28", TimeOff = "0:07", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "SLOPE", Type = "Mains", State = "ON", TimeOn = "16:26", TimeOff = "0:09", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "RECLAIM", Type = "Mains", State = "ON", TimeOn = "15:23", TimeOff = "1:12", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "FEED", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "4SOUTHD1", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "2EAST1", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "2EAST2", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "6SOUTH1", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "6SOUTH2", Type = "Mains", State = "OFF", TimeOn = "15:58", TimeOff = "0:37", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "6SOUTH3", Type = "Mains", State = "OFF", TimeOn = "15:58", TimeOff = "0:37", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "4WEST1", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "4WEST2", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "4WEST3", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "4WEST4", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "4WEST5", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "5SOUTH1", Type = "Mains", State = "ON", TimeOn = "16:35", TimeOff = "0:00", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "5SOUTH2", Type = "Mains", State = "ON", TimeOn = "16:32", TimeOff = "0:03", Uncertain = "0:00" });
            MainBelts.Add(new Pages.Belt { Name = "5SOUTH3", Type = "Mains", State = "ON", TimeOn = "16:29", TimeOff = "0:06", Uncertain = "0:00" });

            //Belt Availability
            BeltAvailability.Add(new Pages.BeltAvail { Name = "Feed", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "4SouthD1", TimeOn = "67:57", TimeOff = "20:34", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.8%", MinAvailability = "76.7%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "2East1", TimeOn = "67:54", TimeOff = "20:37", Uncertain = "0:04", Availability = "76.7%", MaxAvailability = "76.7%", MinAvailability = "76.7%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "2East2", TimeOn = "66:48", TimeOff = "21:43", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "6South1", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "6South2", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "6South3", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "4West1", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "4West2", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "4West3", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "4West4", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "4West5", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "5South1", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "5South2", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
            BeltAvailability.Add(new Pages.BeltAvail { Name = "5South3", TimeOn = "68:01", TimeOff = "20:30", Uncertain = "0:04", Availability = "76.8%", MaxAvailability = "76.9%", MinAvailability = "76.8%" });
        }

    }
}
