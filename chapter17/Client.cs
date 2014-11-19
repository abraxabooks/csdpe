/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Chapter01;

namespace Chapter17
{
    public class Client
    {
        static void Main()
        {
            // USING CONSISTENT iterator() METHODS
            Console.WriteLine("=== Our Cars ===");
            CarRange carRange2 = new CarRange();
            PrintIterator(carRange2.GetEnumerator());

            Console.WriteLine("=== Our Vans ===");
            VanRange vanRange2 = new VanRange();
            PrintIterator(vanRange2.GetEnumerator());


            // USING FOR-EACH
            Console.WriteLine("=== Our Cars ===");
            CarRange carRange3 = new CarRange();
            foreach (IVehicle currentVehicle in carRange3.Range)
            {
                Console.WriteLine(currentVehicle);
            }

            Console.WriteLine("=== Our Vans ===");
            VanRange vanRange3 = new VanRange();
            foreach (IVehicle currentVehicle in vanRange3.Range)
            {
                Console.WriteLine(currentVehicle);
            }

            Console.Read();
        }

        private static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }

    }
}
