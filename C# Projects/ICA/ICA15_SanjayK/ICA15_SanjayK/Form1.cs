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
    public partial class Form1 : Form
    {
        //Declraing variable for modeless dialog
        ModelessDialog dialog = null;
        public Form1()
        {
            InitializeComponent();

            //Changing heading of form 
            this.Text = "Colour This! ****SAMPE****";
        }

        /// <summary>
        /// This event open modeless dialog when user clicks form and also assign callback functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click(object sender, EventArgs e)
        {
            //If dialong is null we create instance of it
            if (dialog == null)
            {
                dialog = new ModelessDialog();

                dialog._dChangeColor = CallBackChangeColor;

                dialog._dChangeOpacity = CallBackChangeOpacity;
            }

            dialog.Default(this.BackColor, this.Opacity);
            dialog.Show();
        }

        /// <summary>
        /// This method change the color of form
        /// </summary>
        /// <param name="col"></param>
        private void CallBackChangeColor(Color col)
        {
            this.BackColor = col;
        }

        /// <summary>
        /// This method change the opacity of form
        /// </summary>
        /// <param name="op"></param>
        private void CallBackChangeOpacity(int op)
        {
            this.Opacity = (double)op / 100;
        }
    }
}
