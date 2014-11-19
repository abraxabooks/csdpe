/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter19
{
    public class Client
    {
        static void Main()
        {
            approach1();
            approach2();
            Console.Read();
        }

        private static void approach1()
        {
            Console.WriteLine("APPROACH 1");
            Speedometer1 speedo = new Speedometer1();

            speedo.CurrentSpeed = 50;
            speedo.CurrentSpeed = 100;
            Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
            Console.WriteLine("Previous speed: " + speedo.previousSpeed);

            // Save the state of 'speedo'
            SpeedometerMemento1 memento = new SpeedometerMemento1(speedo);

            // Change the state of 'speed'
            speedo.CurrentSpeed = 80;
            Console.WriteLine("After setting to 80...");
            Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
            Console.WriteLine("Previous speed: " + speedo.previousSpeed);

            // Restore the state of 'speedo'
            Console.WriteLine("Now restoring state...");
            memento.RestoreState();
            Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
            Console.WriteLine("Previous speed: " + speedo.previousSpeed);
        }

        private static void approach2()
        {
            try
            {
                Console.WriteLine("APPROACH 2");
                Speedometer2 speedo = new Speedometer2();

                speedo.Speed = 50;
                speedo.Speed = 100;
                Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
                Console.WriteLine("Previous speed: " + speedo.PreviousSpeed);

                // Save the state of 'speedo'
                SpeedometerMemento2 memento = new SpeedometerMemento2(speedo);

                // Change the state of 'speed'
                speedo.Speed = 80;
                Console.WriteLine("After setting to 80...");
                Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
                Console.WriteLine("Previous speed: " + speedo.PreviousSpeed);

                // Restore the state of 'speedo'
                Console.WriteLine("Now restoring state...");
                speedo = memento.RestoreState();
                Console.WriteLine("Current speed: " + speedo.CurrentSpeed);
                Console.WriteLine("Previous speed: " + speedo.PreviousSpeed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Write(ex.StackTrace);
            }
        }


    }
}
