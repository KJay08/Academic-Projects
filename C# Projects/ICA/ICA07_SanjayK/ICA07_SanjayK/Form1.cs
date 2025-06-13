/* Program     : ICA07
 * Description : File Processing and Sorting
 * Date        : 12 Feb. 2025
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
using System.Diagnostics;

namespace ICA07_SanjayK
{
    public partial class Form1 : Form
    {
        // List to hold integer values read from the file
        List<int> list = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_DragAndDrop_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Allow the copy effect for file drag
            else
                e.Effect = DragDropEffects.None; // No effect for non-file drag
        }

        private void UI_DragAndDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            // Get the file path of the first file dropped
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();

            // Read the content of the file (assuming integers are comma-separated)
            string integer = File.ReadAllText(fname);

            // Display the content in the initial values textbox
            if (UI_InitialValues_Tbx.Text.Length > 0)
            {
                UI_InitialValues_Tbx.Clear();
                UI_InitialValues_Tbx.Text = integer;
            }
            else
            {
                UI_InitialValues_Tbx.Text = integer;
            }

            // Split the string by commas to get individual integers
            string[] integers = integer.Split(',');

            int numbers;
            for (int i = 0; i < integers.Length; i++)
            {
                int.TryParse(integers[i], out numbers); // Convert string to integer
                list.Add(numbers); // Add integer to the list
            }
        }

        private void UI_SetValues_Btn_Click(object sender, EventArgs e)
        {
            // Create a new stopwatch instance to measure sorting time
            Stopwatch sw = new Stopwatch();

            if (UI_SelectionSort_Radio.Checked || UI_InsertionSort_Radio.Checked)
            {
                // Start the stopwatch to measure sorting time
                sw.Restart();

                if (UI_SelectionSort_Radio.Checked)
                {
                    list.Add(1); // Optional: add a test value for Selection Sort
                    SelectionSort(list); // Perform Selection Sort
                }
                if (UI_InsertionSort_Radio.Checked)
                {
                    list.Remove(1); // Optional: remove the test value for Insertion Sort
                    InsertionSort(list); // Perform Insertion Sort
                }

                // Display the sorted values in the sorted values textbox
                UI_SortedValues_Tbx.Text = $"{string.Join(", ", list)}";

                // Stop the stopwatch after sorting
                sw.Stop();

                // Display the sorting time in the sorting time textbox (in milliseconds)
                UI_SortingTime_Tbx.Text = $"{sw.ElapsedMilliseconds}";
            }
        }

        private void UI_ClearSortedTbx_Btn_Click_1(object sender, EventArgs e)
        {
            UI_SortedValues_Tbx.Clear(); // Clear the sorted values textbox
        }

        /// <summary>
        /// Sorts the list using the Selection Sort algorithm.
        /// </summary>
        private void SelectionSort(List<int> list)
        {
            int n = list.Count;

            // Traverse the list for n-1 passes
            for (int pass = 0; pass < n - 1; pass++)
            {
                int max_posn = 0; // Initialize the position of the maximum element
                int last_posn = n - 1 - pass; // The last unsorted position

                // Find the maximum element in the unsorted part of the list
                for (int j = 0; j <= last_posn; j++)
                {
                    if (list[j] > list[max_posn])
                    {
                        max_posn = j; // Update the position of the maximum element
                    }
                }

                // Swap the maximum element with the element at the last unsorted position
                Swap(list, max_posn, last_posn);
            }
        }

        /// <summary>
        /// Swaps two elements in the list.
        /// </summary>
        private void Swap(List<int> list, int maxPos, int LastPos)
        {
            int temp = list[maxPos];
            list[maxPos] = list[LastPos];
            list[LastPos] = temp;
        }

        /// <summary>
        /// Sorts the list using the Insertion Sort algorithm.
        /// </summary>
        private void InsertionSort(List<int> list)
        {
            int n = list.Count;

            // Traverse through the list and sort each element in place
            for (int p = 0; p < n; p++)
            {
                int temp = list[p];
                int j = p - 1;

                // Shift elements of list[0..p-1] that are greater than temp
                while (j >= 0 && list[j] > temp)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }

                // Place temp in its correct position
                list[j + 1] = temp;
            }
        }
    }
}
