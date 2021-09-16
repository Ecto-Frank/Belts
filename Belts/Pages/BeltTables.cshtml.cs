using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Belts.Services;

namespace Belts.Pages
{
    public class BaileyBeltModel : PageModel
    {
        public string RecentMonday { get; set; }
        public string CurrentDateTime { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MineName { get; set; }
        public Services.BuildBailey BaileyLists { get; set; } = new Services.BuildBailey();
        public Services.BuildEnlow EnlowLists { get; set; } = new Services.BuildEnlow();
        public Services.BuildHarvey HarveyLists { get; set; } = new Services.BuildHarvey();
        public List<Belt> LongWallBelts { get; set; } = new List<Belt>();
        public List<Belt> CMBelts { get; set; } = new List<Belt>();
        public List<Belt> MainBelts { get; set; } = new List<Belt>();
        public List<BeltAvail> BeltAvailability { get; set; } = new List<BeltAvail>();

        public void OnGet()
        {
            this.RecentMonday = DateTime.Now.FirstDayOfWeek(DayOfWeek.Monday).ToShortDateString();
            this.CurrentDateTime = DateTime.Now.ToString();
            if(MineName == "Bailey")
            {
                BaileyLists.Build(LongWallBelts = LongWallBelts, CMBelts = CMBelts, MainBelts = MainBelts, BeltAvailability = BeltAvailability);

            }
            if(MineName == "Enlow")
            {
                EnlowLists.Build(LongWallBelts = LongWallBelts, CMBelts = CMBelts, MainBelts = MainBelts, BeltAvailability = BeltAvailability);
            }
            if(MineName == "Harvey")
            {
                HarveyLists.Build(LongWallBelts = LongWallBelts, CMBelts = CMBelts, MainBelts = MainBelts, BeltAvailability = BeltAvailability);

            }
        }
    }
    public class Belt
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string StateCSS { get; set; }
        public string State { get; set; }
        public string TimeOn { get; set; }
        public string TimeOff { get; set; }
        public string Uncertain { get; set; }

        public Belt()
        {
          
        }

        public string SetStateCSS(Belt belt)
        {
            if (belt.State == "ON")
            {
               return belt.StateCSS = "bg-success";
            }
            if (belt.State == "OFF")
            {
               return belt.StateCSS = "bg-danger";
            }
            if (belt.State == "Unknown")
            {
               return belt.StateCSS = "bg-warning";
            }
            else
            {
                return "";
            }
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

        public BeltAvail()
        {

        }
    }
}
