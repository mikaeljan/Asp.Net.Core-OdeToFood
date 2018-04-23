using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OdeToFoodCore.Models;
using OdeToFoodCore.Services;
using OdeToFoodCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFoodCore.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                Restaurants = _restaurantData.GetAll(),
                CurrentMessage = _greeter.GetMessageOfTheDay()
            };
            return View(viewModel);
        }
        public IActionResult Details(int id)
        {
            var restaurant = _restaurantData.Get(id);
            if (restaurant == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(restaurant);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Neposielat nikdy povodny model lebo overposting, plus davat tieto dve anotacie spolu 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantFormModel restaurantVM)
        {
            if (!ModelState.IsValid)
            {
                return View(restaurantVM);
            }

            var restaurant = new Restaurant
            {
                Name = restaurantVM.Name,
                Cuisine = restaurantVM.Cuisine
            };
            restaurant = _restaurantData.Add(restaurant);
            //Pri successfull addnuti redirectuj aby sa nestavali duplikacie
            return RedirectToAction(nameof(Details), new { id = restaurant.Id});
        }
    }
}
