using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belts.Services
{
    public class BuildEnlow
    {
        public void Build(List<Pages.Belt> LongWallBelts, List<Pages.Belt> CMBelts, List<Pages.Belt> MainBelts, List<Pages.BeltAvail> BeltAvailability)
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
    }
}
