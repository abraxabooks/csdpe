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
    public abstract class AbstractEmailHandler : IEmailHandler
    {
        public static void Handle(string email)
        {
            // Create the handler objects...
            IEmailHandler spam = new SpamEmailHandler();
            IEmailHandler sales = new SalesEmailHandler();
            IEmailHandler service = new ServiceEmailHandler();
            IEmailHandler manager = new ManagerEmailHandler();
            IEmailHandler general = new GeneralEnquiriesEmailHandler();

            // Chain them together...
            spam.NextHandler = sales;
            sales.NextHandler = service;
            service.NextHandler = manager;
            manager.NextHandler = general;

            // Start the ball rolling...
            spam.ProcessHandler(email);
        }

        private IEmailHandler nextHandler;

        public virtual IEmailHandler NextHandler
        {
            set
            {
                nextHandler = value;
            }
        }

        public virtual void ProcessHandler(string email)
        {
            bool wordFound = false;

            // If no words to match against then this object can handle
            if (MatchingWords().Length == 0)
            {
                wordFound = true;

            }
            else
            {
                // Look for any of the matching words
                foreach (string word in MatchingWords())
                {
                    if (email.IndexOf(word) >= 0)
                    {
                        wordFound = true;
                        break;
                    }
                }
            }

            // Can we handle emai in this object?
            if (wordFound)
            {
                HandleHere(email);

            }
            else
            {
                // Unable to handle here so forward to next in chain
                nextHandler.ProcessHandler(email);
            }
        }

        protected internal abstract string[] MatchingWords();
        protected internal abstract void HandleHere(string email);

    }
}
