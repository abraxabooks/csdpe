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
    public class ServiceHistoryBooklet : AbstractBookletPrinter
    {
        protected internal override int PageCount
        {
            get
            {
                return 12;
            }
        }

        protected internal override void PrintFrontCover()
        {
            Console.WriteLine("Printing front cover for service history booklet");
        }

        protected internal override void PrintTableOfContents()
        {
            Console.WriteLine("Printing table of contents for service history booklet");
        }

        protected internal override void PrintPage(int pageNumber)
        {
            Console.WriteLine("Printing page " + pageNumber + " for service history booklet");
        }

        protected internal override void PrintIndex()
        {
            Console.WriteLine("Printing index for service history booklet");
        }

        protected internal override void PrintBackCover()
        {
            Console.WriteLine("Printing back cover for service history booklet");
        }
    }
}
