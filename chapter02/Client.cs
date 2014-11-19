/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter02
{
    public class Client
    {
        static void Main()
        {
            string whatToMake = "car"; // or "van"

            AbstractVehicleFactory factory = null;

            // Create the correct 'factory'...
            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            // Create the vehicle's component parts...
            // These will either be all car parts or all van parts
            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IWindows vehicleWindows = factory.CreateWindows();

            // Show what we've created...
            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleWindows.WindowParts);
            Console.Read();
        }
    }
}
