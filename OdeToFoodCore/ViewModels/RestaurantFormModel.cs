using OdeToFoodCore.Models;
using System.ComponentModel.DataAnnotations;

namespace OdeToFoodCore.ViewModels
{
    public class RestaurantFormModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
