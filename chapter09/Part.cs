/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter09
{
    public class Part : Item
    {
        public Part(string description, int cost)
            : base(description, cost)
        {
        }

        // Empty implementations for unit parts...
        public override void AddItem(Item item)
        {
        }

        public override void RemoveItem(Item item)
        {
        }

        public override Item[] Items
        {
            get
            {
                return new Item[0];
            }
        }
    }
}
