/* Program     : ICA02
 * Description : Form Events
 * Date        : 17 Jan. 2025
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

namespace ICA02_SanjayK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Constructor has been called");
        }

        //This event occurs when form get loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "ICA02 - SanjayK";
            Console.WriteLine("Form has loaded");

        }

        //This event occurs when form is closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Form is closing");
        }

        //This event occurs when form gets activated
        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Form is activated");
        }

        //This event occurs when form gets paint
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Form is painted");
        }

        //This event occurs when form gets closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Form has been closed");
        }

        //This event occurs when form gets deactivated
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Console.WriteLine("Form is deactivated");
        }

        //This event occurs when Form has shown
        private void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Form shown event");
        }
    }
}
