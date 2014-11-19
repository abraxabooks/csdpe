/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter29.Database
{
    class EntitySerializationStrategy : 
					AbstractEntityPersistenceStrategy
    {
        internal override string FileSuffix
        {
            get
            {
                return ".ser";
            }
        }

        internal override void Save(EntityTable table)
        {
            Stream stream = File.Open(GetFileName(table) +
									FileSuffix, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, table);
            stream.Close();
        }

        internal override EntityTable Restore(EntityTable table)
        {
            Stream stream = File.Open(GetFileName(table) +
									FileSuffix, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            EntityTable restoredTable = 
						(EntityTable)formatter.Deserialize(stream);
            stream.Close();
            return restoredTable;
        }
    }
}
