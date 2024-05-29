using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTransactionHeader(int userId, DateTime date, String status)
        {
            return new TransactionHeader
            {
                UserId = userId,
                TransactionDate = date,
                Status = status
            };
        }
    }
}