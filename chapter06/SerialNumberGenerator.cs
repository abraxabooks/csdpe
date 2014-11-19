/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter06
{
    public class SerialNumberGenerator
    {
        // static members
        private static volatile SerialNumberGenerator instance;
        private static object synchronizationRoot = new Object();

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        private int count;

        // private constructor
        private SerialNumberGenerator()
        {
        }

        // instance methods
        public virtual int NextSerial
        {
            get
            {
                return ++count;
            }
        }

    }
}
