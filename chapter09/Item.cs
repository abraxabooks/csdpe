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
    public abstract class Item
    {
        private string description;
        private int cost;

        public Item(string description, int cost)
        {
            this.description = description;
            this.cost = cost;
        }

        public virtual string Description
        {
            get
            {
                return description;
            }
        }

        public virtual int Cost
        {
            get
            {
                return cost;
            }
        }

        public abstract void AddItem(Item item);
        public abstract void RemoveItem(Item item);
        public abstract Item[] Items { get; }

        public override string ToString()
        {
            return description + " (cost " + Cost + ")";
        }

    }
}
