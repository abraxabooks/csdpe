/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using Chapter01;

namespace Chapter03
{
    public class CarBuilder : VehicleBuilder
    {

        private AbstractCar carInProgress;

        public CarBuilder(AbstractCar car)
        {
            carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("building car body");
        }

        public override void BuildBoot()
        {
            Console.WriteLine("building car boot");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building car chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("building car passenger area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building car windows");
        }

        public override IVehicle Vehicle
        {
            get
            {
                return carInProgress;
            }
        }

    }
}
