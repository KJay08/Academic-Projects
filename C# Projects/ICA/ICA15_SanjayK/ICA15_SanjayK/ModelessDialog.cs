/* Program     : ICA15
 * Description : Color This
 * Date        : 31 March 2025
 * Author      : Sanjay Kumar
 * Course      : CMPE1666 - Intermediate Programing
 * Class       : CNTA01
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA15_SanjayK
{
    //Declaring delegates
    public delegate void delChangeColor(Color col);

    public delegate void delChangeOpacity(int op);
    public partial class ModelessDialog : Form
    {
        //we create an object reference for delegate type delChangeColor
        public delChangeColor _dChangeColor = null;

        //we create an object reference for delegate type delChangeOpacity
        public delChangeOpacity _dChangeOpacity = null;

        public ModelessDialog()
        {
            InitializeComponent();

            //Changing the modalessDialog form heading
            this.Text = "Select Colour/Opacity";
        }

        /// <summary>
        /// This method check for cancel and hide the dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModelessDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verify if user is trying to close. if so, cancel the default behaviour(cancel the action of closing)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        /// <summary>
        /// The consolidate event take value from trackbar and assign them color to delegate type delChangeColor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_RGB_Track_Scroll(object sender, EventArgs e)
        {
            int red = UI_Red_Track.Value;
            int green = UI_Green_Track.Value;
            int blue = UI_Blue_Track.Value;

            Color col = Color.FromArgb(red, green, blue);

            _dChangeColor(col);
        }

        /// <summary>
        /// The event take value from trackbar and assign the value to delegate type delChangeOpacity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_OP_Track_Scroll(object sender, EventArgs e)
        {
            int op = UI_OP_Track.Value;

            if (_dChangeOpacity != null)
            {
                _dChangeOpacity(op);
            }
        }

        /// <summary>
        /// This method set trackbars according form intial background color and opacity
        /// </summary>
        /// <param name="col"></param>
        /// <param name="opacity"></param>
        public void Default(Color col, double opacity)
        {
            // Set the RGB trackbars to the color components
            UI_Red_Track.Value = col.R;
            UI_Green_Track.Value = col.G;
            UI_Blue_Track.Value = col.B;

            // Set the opacity trackbar to the provided opacity value
            UI_OP_Track.Value = (int)opacity * 100;
        }
    }
}
