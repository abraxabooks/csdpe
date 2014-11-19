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
    public class StandardGearboxStrategy : IGearboxStrategy
    {
        public virtual void EnsureCorrectGear(IEngine engine, int speed)
        {
            int engineSize = engine.Size;
            bool turbo = engine.Turbo;

            // Some complicated code to determine correct gear
            // setting based on engineSize, turbo & speed, etc.
            // ... omitted ...

            Console.WriteLine("Working out correct gear at "
							+ speed + "mph for a STANDARD gearbox");
        }
    }
}
