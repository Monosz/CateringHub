using CateringHubV2.Models;
using CateringHubV2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Handlers
{
    public class UserHandler
    {
        public static User FindUserById(int id)
        {
            return UserRepository.FindUserById(id);
        }

        public static User FindUserByEmail(string email)
        {
            return UserRepository.FindUserByEmail(email);
        }

        public static void AddUser(User user)
        {
            UserRepository.AddUser(user);
        }

        public static void AddUserLocation(int id, string locationName)
        {
            UserRepository.AddUserLocation(id, locationName);
        }

        public static void UpdateUser(string name, string email, string password)
        {
            UserRepository.UpdateUser(name, email, password);
        }

        public static bool ValidateLogin(string email, string password)
        {
            return UserRepository.ValidateLogin(email, password);
        }
    }
}