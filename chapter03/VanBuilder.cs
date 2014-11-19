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
    public class VanBuilder : VehicleBuilder
    {

        private AbstractVan vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            vanInProgress = van;
        }


        public override void BuildBody()
        {
            Console.WriteLine("building van body");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building van chassis");
        }

        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("building van storage area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building van windows");
        }

        public override IVehicle Vehicle
        {
            get
            {
                return vanInProgress;
            }
        }


    }
}
