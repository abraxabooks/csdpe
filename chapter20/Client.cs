/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter20
{
    public class Client
    {
        static void Main()
        {
            // Create a speedometer...
            Speedometer speedo = new Speedometer();

            // Create a monitor...
            SpeedMonitor monitor = new SpeedMonitor(speedo);

            // Add automatic gearbox as an observer
            AutomaticGearbox auto = new AutomaticGearbox(speedo);

            // Drive at different speeds...
            speedo.CurrentSpeed = 50;
            speedo.CurrentSpeed = 70;
            speedo.CurrentSpeed = 40;
            speedo.CurrentSpeed = 100;
            speedo.CurrentSpeed = 69;

            Console.Read();
        }

    }
}
