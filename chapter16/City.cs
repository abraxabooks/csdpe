/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter16
{
    public class City
    {
        private string name;
        private double latitude, longitude;

        public City(string name, double latitude, double longitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public virtual string Name
        {
            get
            {
                return name;
            }
        }

        public virtual double Latitude
        {
            get
            {
                return latitude;
            }
        }

        public virtual double Longitude
        {
            get
            {
                return longitude;
            }
        }

        public override bool Equals(object otherObject)
        {
            if (this == otherObject)
            {
                return true;
            }
            if (!(otherObject is City))
            {
                return false;
            }
            City otherCity = (City)otherObject;
            return Name.Equals(otherCity.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
