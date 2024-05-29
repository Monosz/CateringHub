using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Factories
{
    public class CartFactory
    {
        public static Cart CreateCart(int userId, int menuId, int qty)
        {
            return new Cart
            {
                UserId = userId,
                RestaurantMenuId = menuId,
                Quantity = qty
            };
        }
    }
}