/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter22
{
    public class Client
    {
        static void Main()
        {
            AbstractCar myCar = new Sport(new StandardEngine(2000));
            myCar.Speed = 20;
            myCar.Speed = 40;

            Console.WriteLine("Switching on sports mode gearbox...");
            myCar.IGearboxStrategy = new SportGearboxStrategy();
            myCar.Speed = 20;
            myCar.Speed = 40;

            Console.Read();
        }

    }
}
