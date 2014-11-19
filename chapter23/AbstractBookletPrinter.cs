/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter23
{
    public abstract class AbstractBookletPrinter
    {
        protected internal abstract int PageCount { get; }
        protected internal abstract void PrintFrontCover();
        protected internal abstract void PrintTableOfContents();
        protected internal abstract void PrintPage(int pageNumber);
        protected internal abstract void PrintIndex();
        protected internal abstract void PrintBackCover();

        // This is the 'template method'
        public void Print()
        {
            PrintFrontCover();
            PrintTableOfContents();
            for (int i = 1; i <= PageCount; i++)
            {
                PrintPage(i);
            }
            PrintIndex();
            PrintBackCover();
        }
    }
}
