﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Inheritance
{
    class Shape
    {
        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
    }
}
