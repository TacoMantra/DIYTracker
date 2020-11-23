using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DIYTracker.Models
{
    public class ProjectTool : IProjectItem
    {
        [Key]
        public int Id { get; set; }

        public IItem Item { get; set; }

        public Project Project { get; set; }
    }
}