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
    public class EngineInventory : IEngineVisitor
    {
        private int camshaftCount;
        private int pistonCount;
        private int sparkPlugCount;

        public EngineInventory()
        {
            camshaftCount = 0;
            pistonCount = 0;
            sparkPlugCount = 0;
        }

        public virtual void Visit(Camshaft camshaft)
        {
            camshaftCount++;
        }

        public virtual void Visit(IEngine engine)
        {
            Console.WriteLine("The engine has: " + 
									camshaftCount +" camshaft(s), " + 
									pistonCount + " piston(s), and " + 
									sparkPlugCount + " spark plug(s)");
        }

        public virtual void Visit(Piston piston)
        {
            pistonCount++;
        }

        public virtual void Visit(SparkPlug sparkPlug)
        {
            sparkPlugCount++;
        }

    }
}
