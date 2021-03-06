﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DIYTracker.Models
{
    public class MyDatabaseContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyDatabaseContext() : base("name=MyDbConnection")
        {
        }

        public System.Data.Entity.DbSet<DIYTracker.Models.Material> Materials { get; set; }

        public System.Data.Entity.DbSet<DIYTracker.Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<DIYTracker.Models.ProjectMaterial> ProjectMaterials { get; set; }

        public System.Data.Entity.DbSet<DIYTracker.Models.ProjectTool> ProjectTools { get; set; }

        public System.Data.Entity.DbSet<DIYTracker.Models.Step> Steps { get; set; }

        public System.Data.Entity.DbSet<DIYTracker.Models.Tool> Tools { get; set; }

        public System.Data.Entity.DbSet<DIYTracker.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<DIYTracker.Models.Todo> Todoes { get; set; }
    }
}
