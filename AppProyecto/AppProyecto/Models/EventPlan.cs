using System;
using System.Collections.Generic;
using System.Text;

namespace AppProyecto.Models
{
    public class EventPlan
    {
        public int eventId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string date { get; set; }
    }
}