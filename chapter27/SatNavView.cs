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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter27
{
    public partial class SatNavView : Form
    {
        private SatNavModel model;
        public event EventHandler ViewControlActivated;

        public SatNavView(SatNavModel model)
        {
            InitializeComponent();
            this.model = model;
            this.model.ModelChanged += HandleModelChanged;
        }

        private void SatNavView_Load(object sender, EventArgs e)
        {
            northButton.Enabled = false;
            feedbackLabel.Text = "You are pointing " + model.Direction +
                " but not yet moving. Use buttons and speed control";
        }


        public void HandleModelChanged(Object sender, EventArgs args)
        {
            feedbackLabel.Text = "Direction: " + model.Direction + ", speed: " + model.Speed;
        }

        private void eastButton_Click(object sender, EventArgs e)
        {
            if (ViewControlActivated != null)
            {
                ControlEventArgs args = new ControlEventArgs();
                args.direction = SatNavModel.TravelDirection.East;
                ViewControlActivated(this, args);
            }
        }

        private void northButton_Click(object sender, EventArgs e)
        {
            if (ViewControlActivated != null)
            {
                ControlEventArgs args = new ControlEventArgs();
                args.direction = SatNavModel.TravelDirection.North;
                ViewControlActivated(this, args);
            }
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            if (ViewControlActivated != null)
            {
                ControlEventArgs args = new ControlEventArgs();
                args.direction = SatNavModel.TravelDirection.South;
                ViewControlActivated(this, args);
            }
        }

        private void westButton_Click(object sender, EventArgs e)
        {
            if (ViewControlActivated != null)
            {
                ControlEventArgs args = new ControlEventArgs();
                args.direction = SatNavModel.TravelDirection.West;
                ViewControlActivated(this, args);
            }
        }

        private void speedControl_ValueChanged(object sender, EventArgs e)
        {
            if (ViewControlActivated != null)
            {
                ControlEventArgs args = new ControlEventArgs();
                args.speed = (int)speedControl.Value;
                ViewControlActivated(this, args);
            }
        }

        internal void enableAllowedButtons()
        {
            // Enable all direction buttons
            eastButton.Enabled = true;
            northButton.Enabled = true;
            southButton.Enabled = true;
            westButton.Enabled = true;

            // Disable current direction button
            if (model.Direction == SatNavModel.TravelDirection.East)
			{
				eastButton.Enabled = false;
			}
            else if (model.Direction == SatNavModel.TravelDirection.North)
			{
				northButton.Enabled = false;
			}
            else if (model.Direction == SatNavModel.TravelDirection.South)
			{
				southButton.Enabled = false;
			}
            else if (model.Direction == SatNavModel.TravelDirection.West)
			{
				westButton.Enabled = false;
			}
        }


        // Nested class for change of direction or speed
        public class ControlEventArgs : EventArgs
        {
            public SatNavModel.TravelDirection direction;
            public int speed;
        }

    }
}
