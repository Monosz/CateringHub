using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Repositories
{
    public class Singleton
    {
        private static DatabaseEntities instance;
        public static DatabaseEntities GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseEntities();
            }
            return instance;
        }
    }
}