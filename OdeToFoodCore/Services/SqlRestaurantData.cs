using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFoodCore.Data;
using OdeToFoodCore.Models;

namespace OdeToFoodCore.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private OdeToFoodDbContext _context;

        public SqlRestaurantData(OdeToFoodDbContext context)
        {
            _context = context;
        }
        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.SingleOrDefault(r => r.Id == id);
        }

        //public IQueryable<Restaurant> GetAll()
        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }
    }
}
