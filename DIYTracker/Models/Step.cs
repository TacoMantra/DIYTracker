using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DIYTracker.Models
{
    public class Step
    {
        [Key]
        public int Id { get; set; }

        public int Order { get; set; }

        public string Description { get; set; }

        public string DurationInMinutes { get; set; }

        public Project Project { get; set; }
    }
}