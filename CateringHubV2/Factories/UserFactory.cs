using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Factories
{
    public class UserFactory
    {
        public static User CreateUser(string username, string email, string password)
        {
            return new User
            {
                UserName = username,
                UserEmail = email,
                UserPassword = password,
                UserLocationId = 1 // Empty loc
            };
        }
    }
}