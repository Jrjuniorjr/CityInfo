using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        IEnumerable<City> GetCities();

        City GetCity(int cityId);

        IEnumerable<PointOfInterest> GetPointsOfInterest();

        PointOfInterest GetPointOfInterest(int cityId, int pointOfInterestId);


    }
}
