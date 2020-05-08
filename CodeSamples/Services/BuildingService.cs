using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.Models;

namespace CodeSamples.Services
{
    public class BuildingService : IBuldingService
    {
        public IEnumerable<Building> GetAllBuildings()
        {
            var building1 = new Building()
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
            yield return building1;
            var building2 = new Building()
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
            yield return building2;
        }
    }

    public interface IBuldingService
    {
        IEnumerable<Building> GetAllBuildings();
    }
}
