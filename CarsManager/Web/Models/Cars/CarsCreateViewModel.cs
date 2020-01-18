using System;
using System.ComponentModel.DataAnnotations;
using Data.Enumeration;
using Web.Attributes;

namespace Web.Models.Cars
{
    public class CarsCreateViewModel
    {
        [Required, StringLength(50)] public string Brand { get; set; }
        [Required, StringLength(50)] public string Model { get; set; }

        [Required, CarYear] public int Year { get; set; }

        public EngineEnum Engine { get; set; }
    }
}