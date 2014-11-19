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

namespace Chapter19
{
    public class SpeedometerMemento2
    {
        public SpeedometerMemento2(Speedometer2 speedometer)
        {
            // Serialize...
            Stream stream = File.Open("speedometer.ser", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, speedometer);
            stream.Close();
        }

        public virtual Speedometer2 RestoreState()
        {
            // Deserialize...
            Speedometer2 speedo;
            Stream stream = File.Open("speedometer.ser", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            speedo = (Speedometer2)formatter.Deserialize(stream);
            stream.Close();
            return speedo;
        }

    }
}
