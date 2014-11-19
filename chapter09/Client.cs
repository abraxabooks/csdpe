/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter09
{
    public class Client
    {
        static void Main()
        {
            Item nut = new Part("Nut", 5);
            Item bolt = new Part("Bolt", 9);
            Item panel = new Part("Panel", 35);

            Item gizmo = new Assembly("Gizmo");
            gizmo.AddItem(panel);
            gizmo.AddItem(nut);
            gizmo.AddItem(bolt);

            Item widget = new Assembly("Widget");
            widget.AddItem(gizmo);
            widget.AddItem(nut);

            // Display the items
            Console.WriteLine(nut);
            Console.WriteLine(bolt);
            Console.WriteLine(panel);
            Console.WriteLine(gizmo);
            Console.WriteLine(widget);

            Console.Read();
        }
    }
}
