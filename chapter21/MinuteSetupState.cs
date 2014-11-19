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
    public class MinuteSetupState : ClockSetupState
    {
        private ClockSetup clockSetup;
        private int minute;

        public MinuteSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            minute = DateTime.Now.Minute;
        }

        public virtual void PreviousValue()
        {
            if (minute > 0)
            {
                minute--;
            }
        }

        public virtual void NextValue()
        {
            if (minute < 59)
            {
                minute++;
            }
        }

        public virtual void SelectValue()
        {
            Console.WriteLine("Minute set to " + minute);
            clockSetup.State = clockSetup.FinishedSetupState;
        }

        public virtual string Instructions
        {
            get
            {
                return "Please set the minute...";
            }
        }

        public virtual int SelectedValue
        {
            get
            {
                return minute;
            }
        }

    }
}
