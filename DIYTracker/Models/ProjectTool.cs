using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIYTracker.Models
{
    public class ProjectTool : IProjectItem
    {
        public string Id { get; set; }

        public Project Project { get; set; }
    }
}