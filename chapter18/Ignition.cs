/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter18
{
    public class Ignition
    {
        private EngineManagementSystem mediator;
        private bool on;

        // Constructor accepts mediator as an argument
        public Ignition(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            on = false;

            // Register back with the mediator;
            mediator.RegisterIgnition(this);
        }

        public virtual void Start()
        {
            on = true;
            mediator.IgnitionTurnedOn();
            Console.WriteLine("Ignition turned on");
        }

        public virtual void Stop()
        {
            on = false;
            mediator.IgnitionTurnedOff();
            Console.WriteLine("Ignition turned off");
        }

        public virtual bool On
        {
            get
            {
                return on;
            }
        }

    }
}
