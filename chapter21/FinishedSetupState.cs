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
    public class FinishedSetupState : ClockSetupState
    {
        private ClockSetup clockSetup;

        public FinishedSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
        }

        public virtual void PreviousValue()
        {
            Console.WriteLine("Ignored...");
        }

        public virtual void NextValue()
        {
            Console.WriteLine("Ignored...");
        }

        public virtual void SelectValue()
        {
            DateTime selectedDate = clockSetup.SelectedDate;
            Console.WriteLine("Date set to: " + selectedDate);
        }

        public virtual string Instructions
        {
            get
            {
                return "Press knob to view selected date...";
            }
        }

        public virtual int SelectedValue
        {
            get
            {
                throw new System.NotSupportedException("Clock setup finished");
            }
        }

    }
}
