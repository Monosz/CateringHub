using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Repositories
{
    public class RestaurantRepository
    {
        private static DatabaseEntities db = Singleton.GetInstance();

        public static Restaurant FindRestaurantByName(string name)
        {
            return db.Restaurants.Find(name);
        }

        public static void AddRestaurant(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public static void AddRestaurantLocation(Restaurant restaurant, string locationName)
        {
            restaurant.RestaurantLocationId = LocationRepository.FindLocationByName(locationName).LocationId;
            db.SaveChanges();
        }
    }
}