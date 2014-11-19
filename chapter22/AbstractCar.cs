/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter22
{
    public abstract class AbstractCar : AbstractVehicle
    {
        private IGearboxStrategy gearboxStrategy;

        public AbstractCar(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }

        public AbstractCar(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
            // Starts in standard gearbox mode (more economical)
            gearboxStrategy = new StandardGearboxStrategy();
        }

        // Allow the gearbox strategy to be changed...
        public virtual IGearboxStrategy IGearboxStrategy
        {
            set
            {
                this.gearboxStrategy = value;
            }
            get
            {
                return gearboxStrategy;
            }
        }

        public virtual int Speed
        {
            set
            {
                // Delegate to strategy in effect...
                gearboxStrategy.EnsureCorrectGear(Engine, value);
            }
        }

    }
}
