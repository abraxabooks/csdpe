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
    public abstract class AbstractEngine : IEngine
    {
		private int size;
        private bool turbo;

        private Camshaft camshaft;
        private Piston piston;
        private SparkPlug[] sparkPlugs;

        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;

            // Create a camshaft, piston and 4 spark plugs...
            camshaft = new Camshaft();
            piston = new Piston();
            sparkPlugs = new SparkPlug[]
										{
											new SparkPlug(), new SparkPlug(),
											new SparkPlug(), new SparkPlug()
										};
        }

        public virtual int Size
        {
            get
            {
                return size;
            }
        }

        public virtual bool Turbo
        {
            get
            {
                return turbo;
            }
        }

        public virtual void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            // Visit each component first...
            camshaft.AcceptEngineVisitor(visitor);
            piston.AcceptEngineVisitor(visitor);
            foreach (SparkPlug eachSparkPlug in sparkPlugs)
            {
                eachSparkPlug.AcceptEngineVisitor(visitor);
            }

            // Now visit the receiver...
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + size + ")";
        }

    }
}
