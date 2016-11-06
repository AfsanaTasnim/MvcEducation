using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEducation.Models
{
    public class Student
    {
        public int ID { get; set; }
        public int Roll { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Cell { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}