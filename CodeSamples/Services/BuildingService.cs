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
    }

    public interface IBuldingService
    {
        string CreateBuilding(Building building);

    }
}
