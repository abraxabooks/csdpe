/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter05
{
    public class Client
    {
        static void Main()
        {
            VehicleManager manager = new VehicleManager();

            IVehicle saloon1 = manager.CreateSaloon();
            IVehicle saloon2 = manager.CreateSaloon();
            IVehicle pickup1 = manager.CreatePickup();

            Console.WriteLine(saloon1);
            Console.WriteLine(saloon2);
            Console.WriteLine(pickup1);

            Console.Read();
        }
    }
}
