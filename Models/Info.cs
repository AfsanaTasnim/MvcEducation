using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcEducation.Models
{
    public class Info
    {
        public int ID { get; set; }
        public int Roll { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }

    public class InfoDBContext : DbContext
    {
        public DbSet<Info> Infos { get; set; }    
    }
}