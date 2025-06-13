/* Program     : ICA13
 * Description : Fntify
 * Date        : 19 March 2025
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

namespace ICA13_SanjayK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Giving text to heading
            this.Text = "Fontify,  ************Sample*********";
        }

        /// <summary>
        /// By Clicking open new ModalDialogForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_FontColour_Label_Click(object sender, EventArgs e)
        {
            //Declare ModalDialogForm type variable
            ModalDialogForm dialog = new ModalDialogForm();

            //Declare Font type variable
            Font defaultFont = UI_FontColour_Label.Font;

            //Declare Color type variable
            Color defaultColor = UI_FontColour_Label.ForeColor;

            //Setting default value for label
            dialog.Default(defaultFont, defaultColor);

            //Open dialong
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Displaying Font value through label
                UI_FontColour_Label.Font = dialog.FontFamily();

                //Displaying color value through label
                UI_FontColour_Label.ForeColor = dialog.Color();

                //UI_FontColour_Label.AutoSize = true;
            }
        }
    }
}
