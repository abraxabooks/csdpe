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
using Chapter29.Database;

namespace Chapter29.Business
{
    [Serializable]
    public class BusinessFacade
    {
        // static members
        private static volatile BusinessFacade instance;
        private static object synchronizationRoot = new Object();

        public static BusinessFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new BusinessFacade();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        public event EventHandler EngineAdded;
        public event EventHandler EnginesRestored;

        // private constructor
        private BusinessFacade()
        {
            DatabaseFacade.Instance.EngineAdded += HandleEngineAdded;
            DatabaseFacade.Instance.EnginesRestored
								+= HandleEnginesRestored;
        }

        // instance methods
        public virtual string[] EngineTypes
        {
            get
            {
                return Enum.GetNames(typeof(EngineFactory.Type));
            }
        }

        public virtual object[] AllEngines
        {
            get
            {
                return DatabaseFacade.Instance.AllEngines;
            }
        }

        public virtual object AddEngine(object type, int size)
        {
            EngineFactory.Type engineType;
            if (type is string)
            {
                engineType = (EngineFactory.Type)
						Enum.Parse(typeof(EngineFactory.Type),
									(string)type);
            }
            else
            {
                engineType = (EngineFactory.Type)type;
            }
            IEngine engine = EngineFactory.Create
						(size, (engineType == EngineFactory.Type.Turbo));
            DatabaseFacade.Instance.AddEngine(engine);
            return engine;
        }

        public virtual void SaveEngines()
        {
            DatabaseFacade.Instance.SaveEngines();
        }

        public virtual void RestoreEngines()
        {
            DatabaseFacade.Instance.RestoreEngines();
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
