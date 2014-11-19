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
using Chapter29.Database;

namespace Chapter29
{
    public partial class ManageEngines : Form
    {
        public ManageEngines()
        {
            InitializeComponent();
            BusinessFacade.Instance.EngineAdded += HandleEngineAdded;
            BusinessFacade.Instance.EnginesRestored
								+= HandleEnginesRestored;
        }

        private void ManageEngines_Load(object sender, EventArgs e)
        {
            // Create some sample data
            BusinessFacade.Instance.AddEngine
								(EngineFactory.Type.Standard, 1300);
            BusinessFacade.Instance.AddEngine
								(EngineFactory.Type.Standard, 1600);
            BusinessFacade.Instance.AddEngine
								(EngineFactory.Type.Standard, 2000);
            BusinessFacade.Instance.AddEngine
								(EngineFactory.Type.Turbo, 2500);
        }

        private void addEngineButton_Click(object sender,
											EventArgs e)
        {
            Form addEngineForm = new AddEngineForm();
            addEngineForm.ShowDialog(this);
        }
        
        public void HandleEngineAdded(Object sender, EventArgs args)
        {
            EntityTable.EntityAddedEventArgs entityArgs =
							(EntityTable.EntityAddedEventArgs)args;
            enginesList.Items.Add(entityArgs.objectAdded.ToString());
        }

        public void HandleEnginesRestored(Object sender,
											EventArgs args)
        {
            enginesList.Clear();
            foreach (object engine in
								BusinessFacade.Instance.AllEngines)
            {
                enginesList.Items.Add(engine.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BusinessFacade.Instance.SaveEngines();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            BusinessFacade.Instance.RestoreEngines();
        }

    }
}
