﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern.Enums
{
    public class DirectionEnums
    {
        public enum AbsoluteDirection
        {
            North = 0, East, South, West
        }
        public enum RelativeDirection
        {
            Right,
            Left,
            Back
        }
    }
}
