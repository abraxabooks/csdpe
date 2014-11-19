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

namespace Chapter04
{
    public class Client
    {
        static void Main()
        {
            // I want an economical car, coloured blue...
            VehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.Build(
                VehicleFactory.DrivingStyle.Economical, VehicleColour.Blue);
            Console.WriteLine(car);

            // I am a "white van man"...
            VehicleFactory vanFactory = new VanFactory();
            IVehicle van = vanFactory.Build(
                VehicleFactory.DrivingStyle.Powerful, VehicleColour.White);
            Console.WriteLine(van);

            // USING STATIC FACTORY

            // Create a red sports car...
            IVehicle sporty = VehicleFactory.Make(VehicleFactory.Category.Car,
                                                 VehicleFactory.DrivingStyle.Powerful,
                                                 VehicleColour.Red);
            Console.WriteLine(sporty);

            Console.Read();
        }
    }
}
