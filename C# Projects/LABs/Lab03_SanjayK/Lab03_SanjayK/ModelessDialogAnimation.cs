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
    // Delegate to notify when the animation speed changes
    public delegate void delChangeAnimation(int speed);

    // Delegate to notify the main form when the modeless dialog is closed (hidden)
    public delegate void delFormAnimationClosingDelegate();

    public partial class ModelessDialogAnimation : Form
    {
        // Delegate instance to notify main form when this dialog is hidden
        public delFormAnimationClosingDelegate _dFormAnimationClosing = null;

        // Delegate instance to notify main form when the animation speed changes
        public delChangeAnimation _delChangeSpeed = null;

        // Constructor: Initializes form and sets title
        public ModelessDialogAnimation()
        {
            InitializeComponent();        // Initialize controls and components
            this.Text = "Animation Speed"; // Set the title of the dialog window
        }

        // Event handler: Called when the user attempts to close the form
        private void ModelessDialogAnimation_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the user manually tries to close the form (e.g., clicking [X])
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;    // Prevent the form from actually closing
                Hide();             // Instead, hide the form to preserve its state

                // Notify the main form that this dialog is being hidden
                // This allows the main form to uncheck the corresponding checkbox
                if (_dFormAnimationClosing != null)
                {
                    try
                    {
                        _dFormAnimationClosing(); // Invoke the callback
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        // Event handler: Called when the user moves the animation speed slider
        private void UI_AnimationSpeed_Bar_Scroll(object sender, EventArgs e)
        {
            // Notify the main form about the new speed value
            if (_delChangeSpeed != null)
            {
                try
                {
                    _delChangeSpeed(UI_AnimationSpeed_Bar.Value); // Send the updated speed value
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }

}

