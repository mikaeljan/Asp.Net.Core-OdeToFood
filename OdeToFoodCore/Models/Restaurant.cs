using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFoodCore.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required, MaxLength(80), Display(Name = "Restaurant Name")]
        public string Name { get; set; }
        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
