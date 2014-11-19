/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter27
{
    public class SatNavController
    {
		// Need a reference to both the model and the view
        private SatNavModel model;
        private SatNavView view;

        public SatNavController(SatNavModel model, SatNavView view)
        {
            this.model = model;
            this.view = view;
            this.view.ViewControlActivated += HandleViewControlActivated;
        }

        public void HandleViewControlActivated(Object sender, EventArgs args)
        {
            SatNavView.ControlEventArgs satnavArgs
								= (SatNavView.ControlEventArgs)args;
            if (satnavArgs.direction
								!= SatNavModel.TravelDirection.Still)
            {
                model.Direction = satnavArgs.direction;
                view.enableAllowedButtons();
            }
            else
            {
                model.Speed = satnavArgs.speed;
            }
        }
    }
}
