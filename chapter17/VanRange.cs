/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System.Collections.Generic;
using Chapter01;

namespace Chapter17
{
    public class VanRange
    {
        private IVehicle[] vans;

        public VanRange()
        {
            vans = new IVehicle[3];

            // Define the range of van models available
            vans[0] = new BoxVan(new StandardEngine(1600));
            vans[1] = new BoxVan(new StandardEngine(2000));
            vans[2] = new Pickup(new TurboEngine(2200));
        }

        public virtual IVehicle[] Range
        {
            get
            {
                return vans;
            }
        }

        public virtual IEnumerator<IVehicle> GetEnumerator()
        {
            return ((IEnumerable<IVehicle>) vans).GetEnumerator();
        }

    }
}
