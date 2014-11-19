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

namespace Chapter12
{
    public class EngineDiagnosticTool : IDiagnosticTool
    {
        public virtual void RunDiagnosis(object obj)
        {
            Console.WriteLine("Starting engine diagnostic tool for "
																+ obj);
            Thread.Sleep(5000);
            Console.WriteLine("Engine diagnosis complete");
        }

    }
}
