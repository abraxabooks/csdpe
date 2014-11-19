/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter10
{
    public class Client
    {
        static void Main()
        {
            // Create a blue saloon car
            IVehicle myCar = new Saloon(new StandardEngine(1300));
            myCar.Paint(VehicleColour.Blue);
            Console.WriteLine(myCar);

            // Add air-conditioning to the car...
            myCar = new AirConditionedVehicle(myCar);
            Console.WriteLine(myCar);

            // Now add alloy wheels...
            myCar = new AlloyWheeledVehicle(myCar);
            Console.WriteLine(myCar);

            // Now add leather seats...
            myCar = new LeatherSeatedVehicle(myCar);
            Console.WriteLine(myCar);

            // Now add metallic paint...
            myCar = new MetallicPaintedVehicle(myCar);
            Console.WriteLine(myCar);

            // Now add satellite navigation
            myCar = new SatNavVehicle(myCar);
            Console.WriteLine(myCar);

            Console.Read();
        }
    }
}
