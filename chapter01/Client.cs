/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter01
{
    class Client
    {
        static void Main()
        {
            IEngine e1 = new StandardEngine(1300);
            IEngine e2 = new TurboEngine(1600);

            IVehicle v1 = new Saloon(e1);
            IVehicle v2 = new Coupe(e1, VehicleColour.Blue);
            IVehicle v3 = new BoxVan(e2, VehicleColour.White);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.Read();
        }
    }
}
