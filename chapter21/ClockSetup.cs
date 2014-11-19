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
    public class ClockSetup
    {
        // The various states the setup can be in...
        private ClockSetupState yearState;
        private ClockSetupState monthState;
        private ClockSetupState dayState;
        private ClockSetupState hourState;
        private ClockSetupState minuteState;
        private ClockSetupState finishedState;

        // The current state we are in...
        private ClockSetupState currentState;

        public ClockSetup()
        {
            yearState = new YearSetupState(this);
            monthState = new MonthSetupState(this);
            dayState = new DaySetupState(this);
            hourState = new HourSetupState(this);
            minuteState = new MinuteSetupState(this);
            finishedState = new FinishedSetupState(this);

            // Initial state is set to the year
            State = yearState;
        }

        public virtual ClockSetupState State
        {
            set
            {
                currentState = value;
                Console.WriteLine(currentState.Instructions);
            }
        }

        public virtual void RotateKnobLeft()
        {
            currentState.PreviousValue();
        }

        public virtual void RotateKnobRight()
        {
            currentState.NextValue();
        }

        public virtual void PushKnob()
        {
            currentState.SelectValue();
        }

        public virtual ClockSetupState YearSetupState
        {
            get
            {
                return yearState;
            }
        }

        public virtual ClockSetupState MonthSetupState
        {
            get
            {
                return monthState;
            }
        }

        public virtual ClockSetupState DaySetupState
        {
            get
            {
                return dayState;
            }
        }

        public virtual ClockSetupState HourSetupState
        {
            get
            {
                return hourState;
            }
        }

        public virtual ClockSetupState MinuteSetupState
        {
            get
            {
                return minuteState;
            }
        }

        public virtual ClockSetupState FinishedSetupState
        {
            get
            {
                return finishedState;
            }
        }

        public virtual DateTime SelectedDate
        {
            get
            {
                return new DateTime(yearState.SelectedValue,
                                    monthState.SelectedValue,
                                    dayState.SelectedValue,
                                    hourState.SelectedValue,
                                    minuteState.SelectedValue,
                                    0);
            }
        }

    }
}
