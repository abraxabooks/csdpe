/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter29.Business
{
    class EngineFactory
    {
        public enum Type
        {
            Standard,
            Turbo
        }

        public static IEngine Create(EngineFactory.Type type,
										int size)
        {
            if (type == Type.Standard)
            {
                return new StandardEngine(size);
            }
            else
            {
                return new TurboEngine(size);
            }
        }

        public static IEngine Create(int size, bool turbo)
        {
            return EngineFactory.Create
						(turbo ? Type.Turbo : Type.Standard, size);
        }

        private EngineFactory()
        {
        }
    }
}
