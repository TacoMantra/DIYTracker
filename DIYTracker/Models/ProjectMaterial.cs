using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIYTracker.Models
{
    public class ProjectMaterial : IProjectItem
    {
        public string Id { get; set; }

        public Project Project { get; set; }

        public int Quantity { get; set; }
    }
}