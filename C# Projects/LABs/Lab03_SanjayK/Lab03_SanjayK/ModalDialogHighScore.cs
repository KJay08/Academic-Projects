﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_SanjayK
{
    public partial class ModalDialogHighScore : Form
    {
        // Constructor for the ModalDialogHighScore form
        public ModalDialogHighScore()
        {
            InitializeComponent();        // Initialize the form's components (auto-generated by the designer)

            this.Text = "High Score";     // Set the window title to "High Score"
        }

        // Event handler for the OK button click
        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;   // Set dialog result to OK to indicate successful submission
        }

        // Event handler for the Cancel button click
        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;   // Set dialog result to Cancel if the user cancels the dialog
        }

        /// <summary>
        /// This method returns player name
        /// </summary>
        /// <returns></returns>
        public string PlayerName()
        {
            return UI_PlayerName_Tbx.Text;    // Return the text the user typed into the name textbox
        }

    }
}
