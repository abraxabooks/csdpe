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
    public class OilLevelLight : IWarningLight
    {
        public virtual void On()
        {
            Console.WriteLine("Oil level light ON");
        }

        public virtual void Off()
        {
            Console.WriteLine("Oil level light OFF");
        }
    }
}
