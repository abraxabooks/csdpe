/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter27
{
    [Serializable]
    public class SatNavModel
    {
        // The directions we can travel
        public enum TravelDirection
        {
            Still, North, South, East, West
        }

        // Change handler
        public event EventHandler ModelChanged;

        // The current direction and speed
        private TravelDirection CurrentDirection;
        private int CurrentSpeed;


        public SatNavModel()
        {
            CurrentDirection = TravelDirection.North;
            CurrentSpeed = 0;
        }

        public virtual TravelDirection Direction
        {
            set
            {
                if (value != CurrentDirection)
                {
                    CurrentDirection = value;
                    if (ModelChanged != null)
                    {
                        ModelChanged(this, EventArgs.Empty);
                    }
                }
            }
            get
            {
                return CurrentDirection;
            }
        }


        public virtual int Speed
        {
            set
            {
                if (value != CurrentSpeed)
                {
                    CurrentSpeed = value;
                    if (ModelChanged != null)
                    {
                        ModelChanged(this, EventArgs.Empty);
                    }
                }
            }
            get
            {
                return CurrentSpeed;
            }
        }
    }
}
