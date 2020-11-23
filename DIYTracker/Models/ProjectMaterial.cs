using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DIYTracker.Models
{
    public class ProjectMaterial : IProjectItem
    {
        [Key]
        public int Id { get; set; }

        public Project Project { get; set; }

        public IItem Item { get; set; }

        public int Quantity { get; set; }
    }
}