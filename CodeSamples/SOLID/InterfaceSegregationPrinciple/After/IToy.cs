﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.SOLID.InterfaceSegregationPrinciple.After
{
    public interface IToy
    {
        void setPrice(double price);
        void setColour(string colour);
    }
}
