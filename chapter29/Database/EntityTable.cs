/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using System.Collections.Generic;

namespace Chapter29.Database
{
    [Serializable]
    public class EntityTable
    {
        private EntityKeyGenerator keyGenerator;
        private IDictionary<int?, object> entities;
        [field:NonSerialized] public event
								EventHandler EntityTableItemAdded;
        [field: NonSerialized] public event
								EventHandler EntityTableRestored;

        internal EntityTable(EntityKeyGenerator keyGenerator)
        {
            this.keyGenerator = keyGenerator;
            entities = new Dictionary<int?, object>();
        }

        internal virtual object GetByKey(int? key)
        {
            return entities[key];
        }

        internal virtual ICollection<object> All
        {
            get
            {
                return entities.Values;
            }
        }

        internal virtual int? AddEntity(object value)
        {
            int? key = keyGenerator.NextKey;
            entities[key] = value;

            EntityAddedEventArgs args = new EntityAddedEventArgs();
            args.objectAdded = value;
            if (EntityTableItemAdded != null)
            {
                EntityTableItemAdded(this, args);
            }
            return key;
        }

        internal virtual void Restore(EntityTable restoredTable)
        {
            entities.Clear();
            foreach (KeyValuePair<int?, object> pair in
										restoredTable.entities)
            {
                entities.Add(pair.Key, pair.Value);
            }

            if (EntityTableRestored != null)
            {
                EntityTableRestored(this, EventArgs.Empty);
            }
        }

        // Nested class for entity added eventargs
        public class EntityAddedEventArgs : EventArgs
        {
            public object objectAdded;
        }

    }
}
