/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter29.Database
{
    class EntityCSVStrategy : AbstractEntityPersistenceStrategy
    {
        internal override string FileSuffix
        {
            get
            {
                return ".csv";
            }
        }

        internal override void Save(EntityTable table)
        {
            // code to save table data in CSV format (omitted)
        }

        internal override EntityTable Restore(EntityTable table)
        {
            // code to restore table data from CSV format (omitted)
            return table;
        }
    }
}
