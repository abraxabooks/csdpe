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
    public class VehicleManager
    {
		private IVehicle saloon, coupe, sport, boxVan, pickup;

        public VehicleManager()
        {
            // For simplicity all vehicles use same engine type...
            saloon = new Saloon(new StandardEngine(1300));
            coupe = new Coupe(new StandardEngine(1300));
            sport = new Sport(new StandardEngine(1300));
            boxVan = new BoxVan(new StandardEngine(1300));
            pickup = new Pickup(new StandardEngine(1300));
        }

        public virtual IVehicle CreateSaloon()
        {
            return (IVehicle)saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreateBoxVan()
        {
            return (IVehicle)boxVan.Clone();
        }

        public virtual IVehicle CreatePickup()
        {
            return (IVehicle)pickup.Clone();
        }

    }
}
