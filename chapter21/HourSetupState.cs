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
    public class HourSetupState : ClockSetupState
    {
        private ClockSetup clockSetup;
        private int hour;

        public HourSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            hour = DateTime.Now.Hour;
        }

        public virtual void PreviousValue()
        {
            if (hour > 0)
            {
                hour--;
            }
        }

        public virtual void NextValue()
        {
            if (hour < 23)
            {
                hour++;
            }
        }

        public virtual void SelectValue()
        {
            Console.WriteLine("Hour set to " + hour);
            clockSetup.State = clockSetup.MinuteSetupState;
        }

        public virtual string Instructions
        {
            get
            {
                return "Please set the hour...";
            }
        }

        public virtual int SelectedValue
        {
            get
            {
                return hour;
            }
        }

    }
}
