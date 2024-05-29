using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Factories
{
    public class RestaurantMenuFactory
    {
        public static RestaurantMenu CreateRestaurantMenu(string name, string image, float calorie, bool isHalal)
        {
            return new RestaurantMenu
            {
                MenuName = name,
                MenuImage = image,
                MenuCalorie = calorie,
                MenuIsHalal = isHalal
            };
        }
    }
}