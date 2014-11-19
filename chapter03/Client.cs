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
    public class Client
    {
        static void Main()
        {
            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle v = director.Build(builder);
            Console.WriteLine(v);
            Console.Read();
        }

    }
}
