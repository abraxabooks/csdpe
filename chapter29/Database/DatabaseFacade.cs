/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using System.Linq;

namespace Chapter29.Database
{
    [Serializable]
    public class DatabaseFacade
    {
        // static members
        private static volatile DatabaseFacade instance;
        private static object synchronizationRoot = new Object();

        public static DatabaseFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new DatabaseFacade();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        private EntityTable engines;
        private AbstractEntityPersistenceStrategy
									persistenceStrategy;
        public event EventHandler EngineAdded;
        public event EventHandler EnginesRestored;

        // private constructor
        private DatabaseFacade()
        {
            engines = new EntityTable(EntityKeyGenerator.Instance);
            engines.EntityTableItemAdded += HandleEngineAdded;
            engines.EntityTableRestored += HandleEnginesRestored;

            // Set which persistence strategy to use
            // (maybe get from configuration settings somewhere)
            persistenceStrategy = new EntitySerializationStrategy();
        }

        // instance methods

        public virtual object[] AllEngines
        {
            get
            {
                return engines.All.ToArray();
            }
        }

        public virtual object GetEngine(int? key)
        {
            return engines.GetByKey(key);
        }

        public virtual int? AddEngine(object engine)
        {
            return engines.AddEntity(engine);
        }

        public virtual void SaveEngines()
        {
            persistenceStrategy.Save(engines);
        }

        public virtual void RestoreEngines()
        {
            EntityTable restoredEngines =
							persistenceStrategy.Restore(engines);
            engines.Restore(restoredEngines);
        }

        public void HandleEngineAdded(Object sender, EventArgs args)
        {
            if (EngineAdded != null)
            {
                EngineAdded(sender, args);
            }
        }

        public void HandleEnginesRestored(Object sender,
											EventArgs args)
        {
            if (EnginesRestored != null)
            {
                EnginesRestored(sender, args);
            }
        }

    }
}
