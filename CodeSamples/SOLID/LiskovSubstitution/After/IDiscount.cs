using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.LiskovSubstitution.After
{
     interface IDiscount
    {
        int Discount(int sales);
    }
}
