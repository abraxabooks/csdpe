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

namespace Chapter04
{
    public abstract class VehicleFactory
    {

        public enum Category
        {
            Car, Van
        }
        public enum DrivingStyle
        {
            Economical, Midrange, Powerful
        }

        public static IVehicle Make(Category cat,
									DrivingStyle style,
									VehicleColour colour)
        {
            VehicleFactory factory;

            if (cat == Category.Car)
            {
                factory = new CarFactory();

            }
            else
            {
                factory = new VanFactory();
            }

            return factory.Build(style, colour);
        }

        public virtual IVehicle Build(DrivingStyle style,
								      VehicleColour colour)
        {
            IVehicle v = SelectVehicle(style);
            v.Paint(colour);
            return v;
        }

        // This is the "factory method"
        protected internal abstract IVehicle SelectVehicle
												(DrivingStyle style);

    }
}
