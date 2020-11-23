using System;
using System.ComponentModel.DataAnnotations;

namespace DIYTracker.Models
{
    public class Material : IItem
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string SingleUnits { get; set; }

        public string PluralUnits { get; set; }
    }
}