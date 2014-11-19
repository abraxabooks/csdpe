/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Chapter01;

namespace Chapter27
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			// Create the MVC classes
            SatNavModel model = new SatNavModel();
            SatNavView view = new SatNavView(model);
            SatNavController controller = new SatNavController(model, view);

            Application.Run(view);
        }
    }
}
