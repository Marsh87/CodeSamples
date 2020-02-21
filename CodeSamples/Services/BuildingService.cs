using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.Models;

namespace CodeSamples.Services
{
    public class BuildingService:IBuldingService
    {
        public string CreateBuilding(Building building)
        {
            return building  is Hospital ? "Created Hospital" : "Plain old building created";
        }

        public IEnumerable<Building> GetAllBuildings()
        {
            var buildings = new List<Building>();
            var building1  = new  Building()
            {
                Address = new Address()
                {
                    PostalCode = "4092",
                    Province = "KZN",
                    StreetName = "Sesame Street",
                    Suburb = "Kloof",
                    UnitNumber = "4"
                },
                Description = "This is a residence",
                Id = 1,
                Name = "The Ritz"

            };

            var building2  = new  Building()
            {
                Address = new Address()
                {
                    PostalCode = "3092",
                    Province = "North West",
                    StreetName = "Coumerrine",
                    Suburb = "Kanto",
                    UnitNumber = "5"
                },
                Description = "This is a pokemon Gym",
                Id = 1,
                Name = "The Kanto Gym"

            };
            buildings.Add(building1);
            buildings.Add(building2);
            return buildings;
        }
    }

    public interface IBuldingService
    {
        string CreateBuilding(Building building);

        IEnumerable<Building> GetAllBuildings();

    }
}
