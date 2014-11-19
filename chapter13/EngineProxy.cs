/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using System.Threading;
using Chapter12;

namespace Chapter13
{
    public class EngineProxy : IEngine
    {
        private IEngine engine;

        public EngineProxy(int size, bool turbo)
        {
            if (turbo)
            {
                engine = new TurboEngine(size);
            }
            else
            {
                engine = new StandardEngine(size);
            }
        }

        public virtual int Size
        {
            get
            {
                return engine.Size;
            }
        }

        public virtual bool Turbo
        {
            get
            {
                return engine.Turbo;
            }
        }

        // This method is time-consuming...
        public virtual void Diagnose(IDiagnosticTool tool)
        {
            Console.WriteLine("(Running tool as thread)");
            Thread t = new Thread(() => RunDiagnosticTool(tool));
            t.Start();
            Console.WriteLine("EngineProxy diagnose() method finished");
        }

        public virtual void RunDiagnosticTool(IDiagnosticTool tool)
        {
            tool.RunDiagnosis(this);
        }

    }
}
