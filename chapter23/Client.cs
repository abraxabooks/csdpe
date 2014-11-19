/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter23
{
    public class Client
    {
        static void Main()
        {
            Console.WriteLine("About to print a booklet for saloon cars");
            AbstractBookletPrinter saloonBooklet = new SaloonBooklet();
            saloonBooklet.Print();

            Console.WriteLine("About to print a service history booklet");
            AbstractBookletPrinter serviceBooklet = new ServiceHistoryBooklet();
            serviceBooklet.Print();

            Console.Read();
        }

    }
}
