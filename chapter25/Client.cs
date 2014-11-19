/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter25
{
    public class Client
    {
        static void Main()
        {
            IWarningLight[] lights = new IWarningLight[3];
            lights[0] = new OilLevelLight();
            lights[1] = new BrakeFluidLight();
            lights[2] = new NullObjectLight(); // empty slot

            // No need to test for null...
            foreach (IWarningLight currentLight in lights)
            {
                currentLight.On();
                currentLight.Off();
            }
            Console.Read();
        }

    }
}
