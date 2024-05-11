using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ClassLibrary
{
    public class RestingPlace
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Tuple<double, double> Coordinates { get; set; }

        public RestingPlace(string name, string description, string type, double latitude, double longitude)
        {
            Name = name;
            Description = description;
            Type = type;
            Coordinates = new Tuple<double, double>(latitude, longitude);
        }
        public class RestingPlaceManager
        {
            private List<RestingPlace> restingPlaces;

            public RestingPlaceManager()
            {
                restingPlaces = new List<RestingPlace>();
            }

            public void AddRestingPlace(RestingPlace place)
            {
                restingPlaces.Add(place);
            }

            public bool RemoveRestingPlace(string name)
            {
                RestingPlace placeToRemove = restingPlaces.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (placeToRemove != null)
                {
                    restingPlaces.Remove(placeToRemove);
                    return true;
                }
                return false;
            }

            public RestingPlace FindRestingPlaceByName(string name)
            {
                return restingPlaces.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }

            public RestingPlace FindRestingPlaceByCoordinates(double latitude, double longitude)
            {
                return restingPlaces.FirstOrDefault(p => Math.Abs(p.Coordinates.Item1 - latitude) < 0.001 && Math.Abs(p.Coordinates.Item2 - longitude) < 0.001);
            }
        }
    }
}
