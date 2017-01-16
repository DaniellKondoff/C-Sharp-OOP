﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interfaces_and_Abstraction.Cars
{
    public interface ICar
    {
        string Model { get; }

        void Start();

        void Stop();
    }
}
