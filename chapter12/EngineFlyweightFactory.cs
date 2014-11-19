/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System.Collections.Generic;

namespace Chapter12
{
    public class EngineFlyweightFactory
    {
        private IDictionary<int?, IEngine> standardEnginePool;
        private IDictionary<int?, IEngine> turboEnginePool;

        public EngineFlyweightFactory()
        {
            standardEnginePool = new Dictionary<int?, IEngine>();
            turboEnginePool = new Dictionary<int?, IEngine>();
        }

        public virtual IEngine GetStandardEngine(int size)
        {
            IEngine e = null;
            bool found = standardEnginePool.TryGetValue(size, out e);
            if (! found)
            {
                e = new StandardEngine(size);
                standardEnginePool[size] = e;
            }
            return e;
        }

        public virtual IEngine GetTurboEngine(int size)
        {
            IEngine e = null;
            bool found = turboEnginePool.TryGetValue(size, out e);
            if (!found)
            {
                e = new TurboEngine(size);
                turboEnginePool[size] = e;
            }
            return e;
        }
    }
}
