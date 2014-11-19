/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter12
{
    public class Client
    {
        static void Main()
        {
            // Create the flyweight factory...
            EngineFlyweightFactory factory = new EngineFlyweightFactory();

            // Create the diagnostic tool
            IDiagnosticTool tool = new EngineDiagnosticTool();

            // Get the flyweights and run diagnostics on them
            IEngine standard1 = factory.GetStandardEngine(1300);
            standard1.Diagnose(tool);

            IEngine standard2 = factory.GetStandardEngine(1300);
            standard2.Diagnose(tool);

            IEngine standard3 = factory.GetStandardEngine(1300);
            standard3.Diagnose(tool);

            IEngine standard4 = factory.GetStandardEngine(1600);
            standard4.Diagnose(tool);

            IEngine standard5 = factory.GetStandardEngine(1600);
            standard5.Diagnose(tool);

            // Show that objects are shared
            Console.WriteLine(standard1.GetHashCode());
            Console.WriteLine(standard2.GetHashCode());
            Console.WriteLine(standard3.GetHashCode());
            Console.WriteLine(standard4.GetHashCode());
            Console.WriteLine(standard5.GetHashCode());

            Console.Read();
        }
    }
}
