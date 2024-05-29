using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Repositories
{
    public class LocationRepository
    {
        private static DatabaseEntities db = Singleton.GetInstance();

        public static Location FindLocationById(int id)
        {
            return db.Locations.Find(id);
        }

        public static Location FindLocationByName(string name)
        {
            return db.Locations.Find(name);
        }

        public static void AddLocation(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
        }
    }
}