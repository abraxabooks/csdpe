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
using Chapter29.Business;

namespace Chapter29
{
    public partial class AddEngineForm : Form
    {
        public AddEngineForm()
        {
            InitializeComponent();
        }

        private void AddEngineForm_Load(object sender, EventArgs e)
        {
            // Load engine types combo
            object[] engineTypes = BusinessFacade.Instance.EngineTypes;
            foreach (object obj in engineTypes)
            {
                typeCombo.Items.Add(obj.ToString());
            }
            typeCombo.SelectedIndex = 0;

            // Load engine size combo
            sizeCombo.Items.Add(1300);
            sizeCombo.Items.Add(1600);
            sizeCombo.Items.Add(2000);
            sizeCombo.Items.Add(2500);
            sizeCombo.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            BusinessFacade.Instance.AddEngine
							(typeCombo.SelectedItem,
                            (int)sizeCombo.SelectedItem);
            this.Close();
        }
    }
}
