using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Factories
{
    public class UserFavoriteFactory
    {
        public static UserFavorite CreateUserFavorite(User user, Restaurant restaurant)
        {
            return new UserFavorite
            {
                User = user,
                Restaurant = restaurant
            };
        }
    }
}