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
    public class Gearbox
    {
        private EngineManagementSystem mediator;
        private bool enabled;
        private Gear currentGear;

        // Constructor accepts mediator as an argument
        public Gearbox(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            enabled = false;
            currentGear = Gear.Neutral;
            mediator.RegisterGearbox(this);
        }

        public virtual void Enable()
        {
            enabled = true;
            mediator.GearboxEnabled();
            Console.WriteLine("Gearbox enabled");
        }

        public virtual void Disable()
        {
            enabled = false;
            mediator.GearboxDisabled();
            Console.WriteLine("Gearbox disabled");
        }

        public virtual bool Enabled
        {
            get
            {
                return enabled;
            }
        }

        public virtual Gear Gear
        {
            set
            {
                if ((Enabled) && (Gear != value))
                {
                    currentGear = value;
                    mediator.GearChanged();
                    Console.WriteLine("Now in " + Gear + " gear");
                }
            }
            get
            {
                return currentGear;
            }
        }

    }
}
