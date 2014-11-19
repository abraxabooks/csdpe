/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter08
{
    public class Client
    {
        static void Main()
        {
            IEngine engine = new StandardEngine(1300);
            AbstractDriverControls controls = new StandardControls(engine);
            controls.IgnitionOn();
            controls.Accelerate();

            // Can use a different engine without changing the driver controls
            IEngine turbo = new TurboEngine(1300);
            controls = new SportControls(turbo);
            controls.IgnitionOn();
            controls.Accelerate();

            Console.Read();
        }
    }
}
