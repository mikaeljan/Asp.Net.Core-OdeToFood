using OdeToFoodCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFoodCore.Services
{
    //public class inmemoryrestaurantdata : irestaurantdata
    //{
    //    public inmemoryrestaurantdata()
    //    {
    //        _restaurants = new list<restaurant>
    //        {
    //            new restaurant {id = 1, name ="scott's pizza place"},
    //            new restaurant {id = 2, name ="king's contrivance"},
    //            new restaurant {id = 3, name ="doma je pohoda"}
    //        };
    //    }

    //    public ienumerable<restaurant> getall()
    //    {
    //        return _restaurants.orderby(r => r.name);
    //    }

    //    public restaurant get(int id)
    //    {
    //        return _restaurants.singleordefault(r => r.id == id);
    //    }

    //    public restaurant add(restaurant restaurant)
    //    {
    //        restaurant.id = _restaurants.max(r => r.id) + 1;
    //        _restaurants.add(restaurant);
    //        return restaurant;
    //    }

    //    List<restaurant> _restaurants;
    //}
}
