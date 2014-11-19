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
    public class Speedometer1
    {
        // Normal private visibility but has accessor method...
        private int currentSpeed;

        // internal visibility and no accessor method...
        internal int previousSpeed;

        public Speedometer1()
        {
            currentSpeed = 0;
            previousSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                previousSpeed = currentSpeed;
                currentSpeed = value;
            }
            get
            {
                return currentSpeed;
            }
        }
    }
}
