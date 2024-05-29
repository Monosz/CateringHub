using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(int transactionId, int menuId, int qty)
        {
            return new TransactionDetail
            {
                TransactionId = transactionId,
                RestaurantMenuId = menuId,
                Quantity = qty
            };
        }
    }
}