using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Battalion.Models;

namespace Battalion.DAL
{
    public class UserContext : DbContext
    {
        public UserContext()

            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }


        public virtual DbSet<Battalion.Models.Notice> Notice { get; set; }

        public virtual DbSet<Battalion.Models.Downloads> Downloads { get; set; }

        public virtual DbSet<Battalion.Models.WhatsNew> WhatsNew { get; set; }


        public virtual DbSet<Battalion.Models.Gallery> Gallery { get; set; }

        public virtual DbSet<Battalion.Models.Contact> Contact { get; set; }

        public virtual DbSet<Battalion.Models.Officers> Officers { get; set; }


        public virtual DbSet<Battalion.Models.UserContact> UserContact { get; set; }


    }
}