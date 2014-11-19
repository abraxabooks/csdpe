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
    public class Speedometer
    {
        public event EventHandler ValueChanged;
        private int currentSpeed;

        public Speedometer()
        {
            currentSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                currentSpeed = value;

                // Tell all observers so they know value has changed...
                OnValueChanged();
            }
            get
            {
                return currentSpeed;
            }
        }

        protected void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }

    }
}
