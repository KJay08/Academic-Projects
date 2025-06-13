/* Program     : ICA06
 * Description : File Processing
 * Date        : 10 Feb. 2025
 * Author      : Sanjay Kumar
 * Course      : CMPE1666 - Intermediate Programming
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
using System.IO;

namespace ICA06_SanjayK
{
    public partial class Form1 : Form
    {
        // List to store integers read from the file
        List<int> List = new List<int>();

        // Constructor that initializes the form
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for drag-and-drop behavior on the text box
        private void UI_DisplayData_Tbx_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged data contains a file (FileDrop) and allow copying if true
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Allow copy of file
            else
                e.Effect = DragDropEffects.None; // Disallow drop if it's not a file
        }

        // Event handler for when the file is dropped onto the text box
        private void UI_DisplayData_Tbx_DragDrop(object sender, DragEventArgs e)
        {
            // Get the file path of the dropped file
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();

            // Read the contents of the file as a string (expected to be a list of integers)
            string integers = File.ReadAllText(fname);

            // If there is any text already in the text box, clear it and reset the list
            if (UI_DisplayData_Tbx.Text.Length > 0)
            {
                UI_DisplayData_Tbx.Clear();
                List.Clear();
                UI_DisplayData_Tbx.Text = integers;
            }
            else
            {
                UI_DisplayData_Tbx.Text = integers;
            }

            // Split the input string by commas to separate the numbers
            string[] integer = UI_DisplayData_Tbx.Text.Split(',');

            // Temporary variable for parsing each integer
            int castInteger;

            // Loop through each element in the array and parse it into an integer
            for (int i = 0; i < integer.Length; i++)
            {
                // Try to parse each string into an integer and add it to the list
                int.TryParse(integer[i], out castInteger);
                List.Add(castInteger);
            }
        }

        // Event handler to count the number of integers in the list and display it
        private void UI_DisplayCount_Btn_Click(object sender, EventArgs e)
        {
            // Set the text box to display the count of numbers in the list
            UI_DisplayCount_Tbx.Text = List.Count.ToString();
        }

        // Event handler to find and display the minimum value from the list
        private void UI_DisplayMinimum_Btn_Click(object sender, EventArgs e)
        {
            // Find the minimum value in the list and display it
            UI_DisplayMinimum_Tbx.Text = $"{List.Min()}";
        }

        // Event handler to find and display the maximum value from the list
        private void UI_DisplayMaximum_Btn_Click(object sender, EventArgs e)
        {
            // Find the maximum value in the list and display it
            UI_DisplayMaximum_Tbx.Text = $"{List.Max()}";
        }
    }
}
