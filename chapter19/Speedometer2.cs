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

    [Serializable]
    public class Speedometer2
	{
        private int currentSpeed;
        private int previousSpeed;

        public Speedometer2() {
            currentSpeed = 0;
            previousSpeed = 0;
        }

        public virtual int CurrentSpeed {
            set {
                previousSpeed = currentSpeed;
                currentSpeed = value;
            }
            get {
                return currentSpeed;
            }
        }

        // Only defined to help testing...
        public virtual int PreviousSpeed {
            get {
                return previousSpeed;
            }
		}
    }
}
