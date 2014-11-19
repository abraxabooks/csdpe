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
    public class AutomaticGearbox
    {
        public AutomaticGearbox(Speedometer speedo)
        {
            speedo.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(Object sender, EventArgs e )
        {
            Speedometer speedo = (Speedometer)sender;
            if (speedo.CurrentSpeed <= 10)
            {
                Console.WriteLine("Now in first gear");

            }
            else if (speedo.CurrentSpeed <= 20)
            {
                Console.WriteLine("Now in second gear");

            }
            else if (speedo.CurrentSpeed <= 30)
            {
                Console.WriteLine("Now in third gear");

            }
            else
            {
                Console.WriteLine("Now in fourth gear");
            }
        }
    }
}
