using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Factories
{
    public class RestaurantFactory
    {
        public static Restaurant CreateRestaurant(string name, string image, float rating)
        {
            return new Restaurant
            {
                RestaurantName = name,
                RestaurantImage = image,
                RestaurantRating = rating,
            };
        }
    }
}