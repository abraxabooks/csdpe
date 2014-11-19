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
    public class DaySetupState : ClockSetupState
    {
        private ClockSetup clockSetup;
        private int day;

        public DaySetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            day = DateTime.Now.Day;
        }

        public virtual void PreviousValue()
        {
            if (day > 1)
            {
                day--;
            }
        }

        public virtual void NextValue()
        {
            if (day < System.DateTime.DaysInMonth(new DateTime().Year,
												  new DateTime().Month))
            {
                day++;
            }
        }

        public virtual void SelectValue()
        {
            Console.WriteLine("Day set to " + day);
            clockSetup.State = clockSetup.HourSetupState;
        }

        public virtual string Instructions
        {
            get
            {
                return "Please set the day...";
            }
        }

        public virtual int SelectedValue
        {
            get
            {
                return day;
            }
        }

    }
}
