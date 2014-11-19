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
    public class Brake
    {
		private EngineManagementSystem mediator;
        private bool enabled;
        private bool applied;

        // Constructor accepts mediator as an argument
        public Brake(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            enabled = false;
            applied = false;
            mediator.RegisterBrake(this);
        }

        public virtual void Enable()
        {
            enabled = true;
            mediator.BrakeEnabled();
            Console.WriteLine("Brakes enabled");
        }

        public virtual void Disable()
        {
            enabled = false;
            mediator.BrakeDisabled();
            Console.WriteLine("Brakes disabled");
        }

        public virtual bool Enabled
        {
            get
            {
                return enabled;
            }
        }

        public virtual void Apply()
        {
            if (Enabled)
            {
                applied = true;
                mediator.BrakePressed();
                Console.WriteLine("Now braking");
            }
        }

        private void Release()
        {
            if (Enabled)
            {
                applied = false;
            }
        }

    }
}
