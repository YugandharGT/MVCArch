using System;

namespace MVCArch.Models
{
    public class EventDTO
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        //public string EventDetails { get; set; }
        public DateTime EventDate { get; set; }
        public string CountryName { get; set; }
        public string CategoryName { get; set; }
    }
}