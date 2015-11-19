using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace RoboTrial.Models
{
    public class RAIDSettingsDB : DbContext
    {
        public DbSet<RAIDUtility> RAIDUtility { get; set; }
    }
}