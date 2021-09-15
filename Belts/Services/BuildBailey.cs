using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belts.Services
{
    public class BuildBailey
    {
      /*public List<Pages.Belt> LongWallBelts { get; set; } = new List<Pages.Belt>();
        public List<Pages.Belt> CMBelts { get; set; } = new List<Pages.Belt>();
        public List<Pages.Belt> MainBelts { get; set; } = new List<Pages.Belt>();
        public List<Pages.BeltAvail> BeltAvailability { get; set; } = new List<Pages.BeltAvail>();*/

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

            /*if (Name == "Enlow")
            {
                LongWallBelts.Add(new Pages.Belt { Name = "G02", Type = "LW", State = "ON", TimeOn = "3:58", TimeOff = "7:54", Uncertain = "0:00" });
                LongWallBelts.Add(new Pages.Belt { Name = "E32", Type = "LW", State = "Unknown", TimeOn = "0:00", TimeOff = "0:00", Uncertain = "11:52" });

                CMBelts.Add(new Pages.Belt { Name = "H01", Type = "CM", State = "OFF", TimeOn = "3:41", TimeOff = "8:11", Uncertain = "0:00" });
                CMBelts.Add(new Pages.Belt { Name = "H01HG", Type = "CM", State = "ON", TimeOn = "4:59", TimeOff = "6:53", Uncertain = "0:00" });

                MainBelts.Add(new Pages.Belt { Name = "U1059", Type = "Mains", State = "ON", TimeOn = "4:25", TimeOff = "7:27", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "U1058", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "U1057", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "U1056", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "U1055", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "U1054", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "U1053", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "U1052", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "U1051", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "2E6", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "2E5", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "2E4", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "2E3", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "2E2", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "2E1", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "3N4", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "3N5", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "3N6", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "3N7", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "3N8", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "3N9", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "3N10", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "1S1", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });
                MainBelts.Add(new Pages.Belt { Name = "2S1", Type = "Mains", State = "ON", TimeOn = "4:23", TimeOff = "7:29", Uncertain = "0:00" });

                BeltAvailability.Add(new Pages.BeltAvail { Name = "2E6", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2E5", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2E4", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2E3", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2E2", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2E1", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2N4", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2N5", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2N6", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2N7", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2N8", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2N9", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2N10", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "1S1", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
                BeltAvailability.Add(new Pages.BeltAvail { Name = "2S1", TimeOn = "28:09", TimeOff = "7:43", Uncertain = "0:00", Availability = "78.5%", MaxAvailability = "78.5%", MinAvailability = "78.5%" });
            }
            if (Name == "Harvey")
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
            }*/
        }

    }
}
