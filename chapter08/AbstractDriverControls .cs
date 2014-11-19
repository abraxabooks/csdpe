/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter08
{
    public class AbstractDriverControls
    {
		private IEngine engine;

        public AbstractDriverControls(IEngine engine)
        {
            this.engine = engine;
        }

        public virtual void IgnitionOn()
        {
            engine.Start();
        }

        public virtual void IgnitionOff()
        {
            engine.Stop();
        }

        public virtual void Accelerate()
        {
            engine.IncreasePower();
        }

        public virtual void Brake()
        {
            engine.DecreasePower();
        }

    }
}
