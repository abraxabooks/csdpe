/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter29.Database
{
    [Serializable]
    class EntityKeyGenerator
    {
        // static members
        private static volatile EntityKeyGenerator instance;
        private static object synchronizationRoot = new Object();

        public static EntityKeyGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new EntityKeyGenerator();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        private int nextKey;

        // private constructor
        private EntityKeyGenerator()
        {
        }

        // instance methods
        public virtual int NextKey
        {
            get
            {
                return ++nextKey;
            }
        }
    }
}
