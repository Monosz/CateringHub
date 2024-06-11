using CateringHubV2.Handlers;
using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Controllers
{
    public class UserController
    {
        public static User FindUserById(int id)
        {
            return UserHandler.FindUserById(id);
        }

        public static User FindUserByEmail(string email)
        {
            return UserHandler.FindUserByEmail(email);
        }

        public static void AddUser(User user)
        {
            UserHandler.AddUser(user);
        }

        public static void AddUserLocation(int id, string locationName)
        {
            UserHandler.AddUserLocation(id, locationName);
        }

        public static void UpdateUser(string name, string email, string password)
        {
            UserHandler.UpdateUser(name, email, password);
        }

        public static bool ValidateLogin(string email, string password)
        {
            return UserHandler.ValidateLogin(email, password);
        }

        public static bool ValidateRegister()
        {
            // Validasi?
            return true;
        }
    }
}