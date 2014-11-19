/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System.Collections.Generic;
using System.Linq;

namespace Chapter09
{
    public class Assembly : Item
    {
        private IList<Item> items;

        public Assembly(string description)
            : base(description, 0)
        {
            items = new List<Item>();
        }

        public override void AddItem(Item item)
        {
            items.Add(item);
        }

        public override void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public override Item[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        // Also have to override getCost() to accumulate cost of all items in list
        public override int Cost
        {
            get
            {
                int total = 0;
                foreach (Item item in items)
                {
                    total += item.Cost;
                }
                return total;
            }
        }

    }
}
