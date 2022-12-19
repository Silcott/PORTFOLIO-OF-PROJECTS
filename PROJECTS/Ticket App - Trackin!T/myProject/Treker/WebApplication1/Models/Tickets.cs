using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string issueCategory { get; set; }
        public string priorityLevel { get; set; }
        public string description { get; set; }
        public string dateIssued { get; set; }
        public string dateCompleted { get; set; }
        public string costs { get; set; }
        public string status { get; set; }



    }
}
