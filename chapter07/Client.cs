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
using Chapter01;

namespace Chapter07
{
    public class Client
    {
        static void Main()
        {
            IList<IEngine> engines = new List<IEngine>();

            engines.Add(new StandardEngine(1300));
            engines.Add(new StandardEngine(1600));
            engines.Add(new TurboEngine(2000));

            // "Adapt" the new engine type
            SuperGreenEngine greenEngine = new SuperGreenEngine(1200);
            engines.Add(new SuperGreenEngineAdapter(greenEngine));

            foreach (IEngine engine in engines)
            {
                Console.WriteLine(engine);
            }
            Console.Read();
        }
    }
}
