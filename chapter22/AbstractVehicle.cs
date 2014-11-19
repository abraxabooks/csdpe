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
    public abstract class AbstractVehicle : IVehicle
    {
        private IEngine engine;
        private VehicleColour colour;

        public AbstractVehicle(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }

        public AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            this.engine = engine;
            this.colour = colour;
        }

        public virtual IEngine Engine
        {
            get
            {
                return engine;
            }
        }

        public virtual VehicleColour Colour
        {
            get
            {
                return colour;
            }
        }

        public virtual void Paint(VehicleColour colour)
        {
            this.colour = colour;
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + engine + ", " + colour + ")";
        }

    }

}
