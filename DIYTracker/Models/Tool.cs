using System;
using System.ComponentModel.DataAnnotations;

namespace DIYTracker.Models
{
    public class Tool : IItem
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
    }
}