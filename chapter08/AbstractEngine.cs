/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter08
{
    public abstract class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;
        private bool running;
        private int power;

        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
            running = false;
            power = 0;
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

        public virtual void Start()
        {
            running = true;
        }

        public virtual void Stop()
        {
            running = false;
            power = 0;
        }

        public virtual void IncreasePower()
        {
            if ((running) && (power < 10))
            {
                power++;
            }
        }

        public virtual void DecreasePower()
        {
            if ((running) && (power > 0))
            {
                power--;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + size + ")";
        }

    }
}
