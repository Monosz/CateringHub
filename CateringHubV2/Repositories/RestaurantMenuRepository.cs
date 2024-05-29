using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Repositories
{
    public class RestaurantMenuRepository
    {
        private static DatabaseEntities db = Singleton.GetInstance();

        public static List<RestaurantMenu> GetAllMenu(int restaurantId)
        {
            // return (from x in db.RestaurantMenus where x.RestaurantId == restaurantId select x).ToList();
            return null;
        }

        public static void AddMenu(RestaurantMenu menu)
        {
            db.RestaurantMenus.Add(menu);
            db.SaveChanges();
        }

        public static void RemoveMenu(RestaurantMenu menu)
        {
            db.RestaurantMenus.Remove(menu);
            db.SaveChanges();
        }
    }
}