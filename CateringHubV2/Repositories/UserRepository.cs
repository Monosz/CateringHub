using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Repositories
{
    public class UserRepository
    {
        private static DatabaseEntities db = Singleton.GetInstance();

        public static User FindUserById(int id)
        {
            return db.Users.Find(id);
        }

        public static User FindUserByEmail(string email)
        {
            return db.Users.Find(email);
        }

        public static void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static void AddUserLocation(User user, string locationName)
        {
            user.UserLocationId = LocationRepository.FindLocationByName(locationName).LocationId;
            db.SaveChanges();
        }

        public static void UpdateUser()
        {
            db.SaveChanges();
        }
    }
}