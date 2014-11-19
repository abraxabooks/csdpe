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
    public class SpeedMonitor
    {
        public const int SPEED_TO_ALERT = 70;

        public SpeedMonitor(Speedometer speedo)
        {
            speedo.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(Object sender, EventArgs e )
        {
            Speedometer speedo = (Speedometer)sender;
            if (speedo.CurrentSpeed > SPEED_TO_ALERT)
            {
                Console.WriteLine("** ALERT ** Driving too fast! ("
										+ speedo.CurrentSpeed + ")");

            }
            else
            {
                Console.WriteLine("... nice and steady ... ("
										+ speedo.CurrentSpeed + ")");
            }
        }
    }
}
