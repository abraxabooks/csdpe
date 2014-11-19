/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using Chapter01;

namespace Chapter03
{
    public abstract class VehicleBuilder
	{
		public virtual void BuildBody() {}
        public virtual void BuildBoot() {}
        public virtual void BuildChassis() {}
        public virtual void BuildPassengerArea() {}
        public virtual void BuildReinforcedStorageArea() {}
        public virtual void BuildWindows() {}

        public abstract IVehicle Vehicle {get;}
    }
}
