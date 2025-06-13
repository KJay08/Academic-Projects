using System;
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
    // Delegate to send score updates to the main form (if needed)
    public delegate void delChangeScore(string score);

    // Delegate to notify the main form when this score dialog is closed (hidden)
    public delegate void delFormScoreClosingDelegate();

    public partial class ModelessDialongScore : Form
    {
        // Delegate instance for notifying when the form is hidden
        public delFormScoreClosingDelegate _dFormScoreClosing = null;

        // Delegate instance for notifying score updates (optional, not used here)
        public delChangeScore _delChangeScore = null;

        // Constructor: Initializes the form and sets default values
        public ModelessDialongScore()
        {
            InitializeComponent();                            // Initialize all UI components (Designer-generated)
            this.Text = "Score";                              // Set the window title to "Score"
            UI_Score_Lbl.Text = "Score \t\t\t\t\t 0000";      // Initialize score label with default value
        }

        // Event handler: Triggered when the user attempts to close the score form
        private void ModelessDialongScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is being closed by the user (clicking [X])
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;      // Prevent the form from actually closing
                Hide();               // Hide the form to preserve its current state

                // Notify the main form that this score window has been hidden
                if (_dFormScoreClosing != null)
                {
                    try
                    {
                        _dFormScoreClosing();  // Call the callback method to uncheck the checkbox on the main form
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// This method updates score on label
        /// </summary>
        /// <param name="score"></param>
        public void updateScore(int score)
        {
            // Display the new score using formatting for alignment
            UI_Score_Lbl.Text = $"Score \t\t\t\t\t {score}";
        }
    }

}

