/* Program     : ICA11
 * Description : Binary Search
 * Date        : 11 March 2025
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

namespace ICA11_SanjayK
{
    public partial class Form1 : Form
    {
        // Create a List to hold names
        List<string> nameList = new List<string>();

        // Form1 constructor: Initializes the form components
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the "Add Name" button
        private void UI_AddName_Btn_Click(object sender, EventArgs e)
        {
            // Check if the input text box is not empty
            if (UI_InputSearch_Tbx.Text.Length > 0)
            {
                // Store the entered name from the input box
                string name = UI_InputSearch_Tbx.Text;

                // Add the name to the nameList (unsorted list)
                nameList.Add(name);

                // Add the name to the unsorted list box in the UI
                UI_EntryNames_Lbx.Items.Add(name);

                // Clear the input text box after adding the name
                UI_InputSearch_Tbx.Clear();

                // Sort the nameList alphabetically
                nameList.Sort();

                // Clear the sorted list box before updating with sorted names
                UI_SortedNames_Lbx.Items.Clear();

                // Add each sorted name to the sorted list box in the UI
                foreach (string nameValue in nameList)
                {
                    UI_SortedNames_Lbx.Items.Add(nameValue);
                }
            }
        }

        // Event handler for the "Search Name" button
        private void UI_SearchName_Btn_Click(object sender, EventArgs e)
        {
            // Check if the input text box is not empty
            if (UI_InputSearch_Tbx.Text.Length > 0)
            {
                // Call the BinarySearch method to search for the entered name
                int test = BinarySearch(nameList, 0, nameList.Count - 1, UI_InputSearch_Tbx.Text);

                // If the name is found (index >= 0), show a message with the index
                if (test >= 0)
                {
                    MessageBox.Show($"{UI_InputSearch_Tbx.Text}, found at index {test}");
                }
                else
                {
                    // If the name is not found, show a message saying it's not found
                    MessageBox.Show($"{UI_InputSearch_Tbx.Text}, not found");
                }

                // Clear the input text box after searching
                UI_InputSearch_Tbx.Clear();
            }
        }

        // Binary search method to search for a name in the sorted list
        private int BinarySearch(List<string> list, int low, int high, string searchString)
        {
            // While the low index is less than or equal to the high index
            if (high >= low)
            {
                // Calculate the middle index of the current search range
                int mid = (low + high) / 2;

                // If the middle value matches the search string, return the index
                if (list[mid] == searchString)
                {
                    return mid;
                }

                // If the middle value is greater than the search string, search the left half
                if (list[mid].CompareTo(searchString) > 0)
                {
                    return BinarySearch(list, low, mid - 1, searchString);
                }
                // If the middle value is less than the search string, search the right half
                else
                {
                    return BinarySearch(list, mid + 1, high, searchString);
                }
            }
            else
            {
                // If the search range is invalid (low > high), the item was not found
                return -1;
            }
        }
    }
}
