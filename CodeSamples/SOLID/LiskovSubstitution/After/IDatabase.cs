using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.SOLID.LiskovSubstitution.Before;
using CodeSamples.SOLID.LiskovSubstitution.Models;

namespace CodeSamples.SOLID.LiskovSubstitution.After
{
    interface IDatabase
    {
        void Add(Database db);
    }
}
