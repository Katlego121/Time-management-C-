using Azure.Core;

namespace ST10104140_POE_Katlego_Mononyane.Pages
{
    public class Module
    {
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int Credits { get; set; }
        public int HoursPerWeek { get; set; }
        public int Weeks { get; set; }
        public string StartSemester { get; set; }
        public int SelfStudyHours { get; set; }
        public int calculateSelfStudyHours { get; set;}
        public int CalculateRemainHours { get; set; }
        // Add other properties
    }
}

