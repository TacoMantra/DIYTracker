using System;
using System.ComponentModel.DataAnnotations;

namespace DIYTracker.Models
{
    public class Material : IItem
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Units { get; set; }
    }
}