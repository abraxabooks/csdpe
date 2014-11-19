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
    public class CarRange
    {
        private IList<IVehicle> cars;

        public CarRange()
        {
            cars = new List<IVehicle>();

            // Define the range of car models available
            cars.Add(new Saloon(new StandardEngine(1300)));
            cars.Add(new Saloon(new StandardEngine(1600)));
            cars.Add(new Coupe(new StandardEngine(2000)));
            cars.Add(new Sport(new TurboEngine(2500)));
        }

        public virtual IList<IVehicle> Range
        {
            get
            {
                return cars;
            }
        }

        public virtual IEnumerator<IVehicle> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

    }

}
