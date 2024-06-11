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

        public static void AddUserLocation(int id, string locationName)
        {
            User user = FindUserById(id);
            user.UserLocationId = LocationRepository.FindLocationByName(locationName).LocationId;
            db.SaveChanges();
        }

        public static void UpdateUser(string name, string email, string password)
        {
            User u = FindUserByEmail(email);
            u.UserName = name;
            u.UserEmail = email;
            u.UserPassword = password;
            db.SaveChanges();
        }

        public static bool ValidateLogin(string email, string password)
        {
            User u = FindUserByEmail(email);
            if (u == null)
            {
                return false;
            }
            else if (u.UserPassword != password)
            {
                return false;
            }
            return true;
        }
    }
}