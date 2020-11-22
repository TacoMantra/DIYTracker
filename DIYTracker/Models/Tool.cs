using System;
using System.ComponentModel.DataAnnotations;

namespace DIYTracker.Models
{
    public class Tool : IItem
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
    }
}