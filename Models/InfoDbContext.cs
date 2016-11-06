using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcEducation.Models
{
    public class InfoDBContext: DbContext
    {
        public DbSet<Info> Infos { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}