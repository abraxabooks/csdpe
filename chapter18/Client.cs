/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter18
{
    public class Client
    {
        static void Main()
        {
            EngineManagementSystem ems = new EngineManagementSystem();

            Ignition ignition = new Ignition(ems);
            Gearbox gearbox = new Gearbox(ems);
            Accelerator accelerator = new Accelerator(ems);
            Brake brake = new Brake(ems);

            ignition.Start();
            accelerator.AccelerateToSpeed(30);
            gearbox.Gear = Gear.Fourth;
            brake.Apply();

            Console.Read();
        }

    }
}
