/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter15
{
    public class ElectricWindow
    {

        private bool open;

        public ElectricWindow()
        {
            open = false;
            Console.WriteLine("Window is closed");
        }

        public virtual bool Open
        {
            get
            {
                return open;
            }
        }

        public virtual bool Closed
        {
            get
            {
                return (!open);
            }
        }

        public virtual void OpenWindow()
        {
            if (Closed)
            {
                open = true;
                Console.WriteLine("Window is now open");
            }
        }

        public virtual void CloseWindow()
        {
            if (Open)
            {
                open = false;
                Console.WriteLine("Window is now closed");
            }
        }

    }
}
