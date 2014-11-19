/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter21
{
    public class Client
    {
        static void Main()
        {
            ClockSetup clockSetup = new ClockSetup();

            // Setup starts in 'year' state
            clockSetup.RotateKnobRight();
            clockSetup.PushKnob(); // year should be 1 on from current

            // Setup should now be in 'month' state
            clockSetup.RotateKnobRight();
            clockSetup.RotateKnobRight();
            clockSetup.PushKnob(); // month should be 2 on from current

            // Setup should now be in 'day' state
            clockSetup.RotateKnobRight();
            clockSetup.RotateKnobRight();
            clockSetup.RotateKnobRight();
            clockSetup.PushKnob(); // day should be 3 on from current

            // Setup should now be in 'hour' state
            clockSetup.RotateKnobLeft();
            clockSetup.RotateKnobLeft();
            clockSetup.PushKnob(); // hour should be 2 less than current

            // Setup should now be in 'minute' state
            clockSetup.RotateKnobRight();
            clockSetup.PushKnob(); // minute should be 1 on than current

            // Setup should now be in 'finished' state
            clockSetup.PushKnob(); // to display selected date

            Console.Read();
        }

    }
}
