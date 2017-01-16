﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    class Frog : Animal ,Sound
    {
        public Frog(string name, int age, string gender)
            :base(name,age,gender)
        {
        }

        public override  string produceSound()
        {
            return "Frogggg";
        }

    }
}
