using CateringHubV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CateringHubV2.Factories
{
    public class LocationFactory
    {
        public static Location CreateLocation(string address, string city, string subdistrict, float latitude, float longitude)
        {
            return new Location
            {
                LocationAddress = address,
                LocationCIty = city,
                LocationSubdistrict = subdistrict,
                LocationLatitude = latitude,
                LocationLongitude = longitude
            };
        }
    }
}