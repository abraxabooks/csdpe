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
    public class YearSetupState : ClockSetupState
    {
        private ClockSetup clockSetup;
        private int year;

        public YearSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            year = DateTime.Now.Year;
        }

        public virtual void PreviousValue()
        {
            year--;
        }

        public virtual void NextValue()
        {
            year++;
        }

        public virtual void SelectValue()
        {
            Console.WriteLine("Year set to " + year);
            clockSetup.State = clockSetup.MonthSetupState;
        }

        public virtual string Instructions
        {
            get
            {
                return "Please set the year...";
            }
        }

        public virtual int SelectedValue
        {
            get
            {
                return year;
            }
        }

    }
}
