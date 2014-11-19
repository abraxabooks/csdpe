/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter14
{
    public class ServiceEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "service", "repair" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("Email handled by service department.");
        }
    }
}
