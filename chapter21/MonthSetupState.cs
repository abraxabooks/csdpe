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
    public class MonthSetupState : ClockSetupState
    {
        private ClockSetup clockSetup;
        private int month;

        public MonthSetupState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            month = DateTime.Now.Month;
        }

        public virtual void PreviousValue()
        {
            if (month > 0)
            {
                month--;
            }
        }

        public virtual void NextValue()
        {
            if (month < 11)
            {
                month++;
            }
        }

        public virtual void SelectValue()
        {
            Console.WriteLine("Month set to " + month);
            clockSetup.State = clockSetup.DaySetupState;
        }

        public virtual string Instructions
        {
            get
            {
                return "Please set the month...";
            }
        }

        public virtual int SelectedValue
        {
            get
            {
                return month;
            }
        }

    }
}
