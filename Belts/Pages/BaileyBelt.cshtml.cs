using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Belts.Pages
{
    public class BaileyBeltModel : PageModel
    {
        public string RecentMonday { get; set; }
        public string CurrentDateTime { get; set; }
        public string MineName { get; set; }
        public List<string> BeltTableHeadings { get; set; }
        public List<string> AvailTableHeadings { get; set; }
        public Belt FirstCMBelt { get; set; }
        public Belt FirstLWBelt { get; set; }
        public BeltAvail FirstBeltAvail { get; set; }


        public void OnGet()
        {
            this.RecentMonday = DateTime.Now.FirstDayOfWeek(DayOfWeek.Monday).ToShortDateString();
            this.CurrentDateTime = DateTime.Now.ToString();
            this.BeltTableHeadings = new List<string>{ "Belt","Type","State","Time On","Time Off","?"};
            this.AvailTableHeadings = new List<string> { "Belt", "Time Off", "Time On", "?", "Avail", "Max Avail", "Min Avail" };
            this.FirstCMBelt = new Belt("9L", "CM", "OFF", "0:00", "16:35", "0:00");
            this.FirstLWBelt = new Belt("8L", "LW", "OFF", "0:00", "16:35", "0:00");
            this.FirstBeltAvail = new BeltAvail("Feed", "68:01", "20:30", "0:04", "76.8%", "76.9%", "76.8%");
        }
    }
    public class Belt
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string TimeOn { get; set; }
        public string TimeOff { get; set; }
        public string Uncertain { get; set; }

        public Belt(string name, string type, string status, string timeOn, string timeOff, string uncertain)
        {
            Name = name;
            Type = type;
            Status = status;
            TimeOn = timeOn;
            TimeOff = timeOff;
            Uncertain = uncertain;

        }
    }
    public class BeltAvail
    {
        public string Name { get; set; }
        public string TimeOff { get; set; }
        public string TimeOn { get; set; }
        public string Uncertain { get; set; }
        public string Availability { get; set; }
        public string MaxAvailability { get; set; }
        public string MinAvailability { get; set; }

        public BeltAvail(string name, string timeOff, string timeOn, string uncertain, string avail, string maxAvail, string minAvail)
        {
            Name = name;
            TimeOff = timeOff;
            TimeOn = timeOn;
            Uncertain = uncertain;
            Availability = avail;
            MaxAvailability = maxAvail;
            MinAvailability = minAvail;
        }
    }
}
