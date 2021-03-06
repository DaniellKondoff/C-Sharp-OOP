﻿using BoatRacingSimulator.Interfaces;
using BoatRacingSimulator.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoatRacingSimulator.Models.Boats
{
    public abstract class Boat :IBoat
    {
        private string model;
        private int weight;

        protected Boat(string model,int weight)
        {
            this.Model = model;
            this.Weight = weight;
        }
        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateModelLength(value, Constants.MinBoatModelLength);
                this.model = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                Validator.ValidatePropertyValue(value, nameof(this.Weight));
                this.weight = value;
            }
        }

        public abstract double CalculateRaceSpeed(IRace race);

    }
}
