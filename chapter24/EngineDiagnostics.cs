/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter24
{
    public class EngineDiagnostics : IEngineVisitor
    {
        public virtual void Visit(Camshaft camshaft)
        {
            Console.WriteLine("Diagnosing the camshaft");
        }

        public virtual void Visit(IEngine engine)
        {
            Console.WriteLine("Diagnosing the engine");
        }

        public virtual void Visit(Piston piston)
        {
            Console.WriteLine("Diagnosing the piston");
        }

        public virtual void Visit(SparkPlug sparkPlug)
        {
            Console.WriteLine("Diagnosing a single spark plug");
        }

    }
}
