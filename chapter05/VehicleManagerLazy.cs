/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter05
{
    public class VehicleManagerLazy
    {

        private IVehicle saloon, coupe, sport, boxVan, pickup;

        public VehicleManagerLazy()
        {
        }

        public virtual IVehicle CreateSaloon()
        {
            if (saloon == null)
            {
                saloon = new Saloon(new StandardEngine(1300));
            }
            return (IVehicle)saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            if (coupe == null)
            {
                coupe = new Coupe(new StandardEngine(1300));
            }
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            if (sport == null)
            {
                sport = new Sport(new StandardEngine(1300));
            }
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreateBoxVan()
        {
            if (boxVan == null)
            {
                boxVan = new BoxVan(new StandardEngine(1300));
            }
            return (IVehicle)boxVan.Clone();
        }

        public virtual IVehicle CreatePickup()
        {
            if (pickup == null)
            {
                pickup = new Pickup(new StandardEngine(1300));
            }
            return (IVehicle)pickup.Clone();
        }

    }
}
