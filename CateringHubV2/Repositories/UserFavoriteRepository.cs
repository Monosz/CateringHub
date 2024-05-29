using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Repositories
{
    public class UserFavoriteRepository
    {
        private static DatabaseEntities db = Singleton.GetInstance();

        public static List<UserFavorite> GetAllFavorite(User user)
        {
            return (from x in db.UserFavorites where x.UserId == user.UserId select x).ToList();
        }

        public static void AddFavorite(UserFavorite favorite)
        {
            db.UserFavorites.Add(favorite);
            db.SaveChanges();
        }

        public static void RemoveFavorite(UserFavorite favorite)
        {
            db.UserFavorites.Remove(favorite);
            db.SaveChanges();
        }
    }
}