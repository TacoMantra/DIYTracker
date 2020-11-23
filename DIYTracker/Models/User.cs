using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DIYTracker.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int UserType { get; set; } // TODO: not sure how to do EF migration for enum, but this should be an enum
    }
}