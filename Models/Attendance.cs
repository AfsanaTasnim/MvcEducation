using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcEducation.Models
{
    public class Attendance
    {
        public int ID { get; set; }
        public int Roll { get; set; }
        public string Name { get; set; }
        public int Day { get; set; }
    }
  
}