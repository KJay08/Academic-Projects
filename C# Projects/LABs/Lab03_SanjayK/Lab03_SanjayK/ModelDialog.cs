using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace Lab03_SanjayK
{
    public partial class ModelDialog : Form
    {
        // Default difficulty level is set to "easy"
        string DifficultyLevel = "easy";

        // Constructor: Initializes the form and sets the window title
        public ModelDialog()
        {
            InitializeComponent();               // Initialize all components defined in the designer
            this.Text = "Select Difficulty";     // Set the form's title bar text
        }

        // Event handler: Triggered when the user clicks the "OK" button
        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;      // Set the dialog result to OK to indicate user confirmed selection
        }

        // Event handler: Triggered when the user clicks the "Cancel" button
        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;  // Set the dialog result to Cancel to indicate user canceled the dialog
        }

        // Event handler: Triggered when any of the radio buttons are checked/unchecked
        private void UI_DifficultyLevel_Radio_CheckedChanged(object sender, EventArgs e)
        {
            // Update the selected difficulty level based on the checked radio button
            if (UI_Easy_Radio.Checked)
            {
                DifficultyLevel = "easy";
            }
            else if (UI_Medium_Radio.Checked)
            {
                DifficultyLevel = "medium";
            }
            else if (UI_Hard_Radio.Checked)
            {
                DifficultyLevel = "hard";
            }
        }

        /// <summary>
        /// This method return difficulty level according user choice
        /// </summary>
        /// <returns></returns>
        public string dificulty()
        {
            return DifficultyLevel;
        }

    }
}
