/* Program     : Lab02
 * Description : Creating and Sorting lists of structs
 * Date        : 26 Feb. 2025
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
using System.IO;
using System.Diagnostics;

namespace Lab02_SanjayK
{
    public partial class Form1 : Form
    {
        // Create a new stopwatch instance to measure sorting time
        Stopwatch sw = new Stopwatch();

        // Struct to hold Employee details: ID, First Name, and Last Name
        private struct Employee
        {
            public int _employeeId; // Employee ID
            public string _firstName; // First Name of the Employee
            public string _lastName; // Last Name of the Employee
        }

        // Lists to store Employee objects
        List<Employee> LocalList = new List<Employee>();
        List<Employee> ProvidedList = new List<Employee>();

        // Arrays to hold sample employee data
        int[] employeeIds = { 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
        string[] firstNames = { "Emily", "Michael", "Olivia", "Daniel", "Sophia", "Ethan", "Ava", "Benjamin", "Isabella", "Jacob",
                                "Mia", "William", "Emma", "Alexander", "Charlotte", "James", "Amelia", "Logan", "Harper", "Elijah",
                                "Grace", "Noah", "Lily", "Lucas" };
        string[] lastNames = { "Johnson", "Smith", "Williams", "Brown", "Jones", "Davis", "Miller", "Wilson", "Moore", "Taylor",
                               "Anderson", "Thomas", "Jackson", "Moore", "Harris", "Martin", "Thompson", "Garcia", "Martinez",
                               "Robinson", "Smith", "Rodriguez", "Lewis", "Clark" };

        public Form1()
        {
            InitializeComponent(); // Initialize the form components
        }

        // Method to create a new Employee object from employee ID, first name, and last name
        private Employee CreateEmployee(int employeeId, string firstName, string lastName)
        {
            Employee employee;
            employee = new Employee { _employeeId = employeeId, _firstName = firstName, _lastName = lastName };
            return employee;
        }

        // Button click event to display unsorted data in DataGridView
        private void UI_DisplayUnsorted_Btn_Click(object sender, EventArgs e)
        {
            LocalList.Clear(); // Clear the LocalList

            // Create Employee objects and add to LocalList
            for (int i = 0; i < employeeIds.Length; i++)
            {
                LocalList.Add(CreateEmployee(employeeIds[i], firstNames[i], lastNames[i]));
            }

            // Populate the DataGridView with LocalList data if the provided list radio button is checked
            if (UI_ProvidedList_Radio.Checked)
            {
                if (UI_UnsortedData_DGV.Rows.Count == 0)
                {
                    PopulateDataGridView(LocalList, UI_UnsortedData_DGV); // Populate DataGridView with unsorted data
                }
            }
        }

        // Button click event to clear the unsorted data from DataGridView and reset the timer
        private void UI_ClearUnsorted_Btn_Click(object sender, EventArgs e)
        {
            UI_UnsortedData_DGV.Rows.Clear(); // Clear the DataGridView
            UI_Timer_Tbx.Text = "0"; // Reset the timer textbox to 0
        }

        // Button click event to open a file dialog and load employee data from file
        private void UI_OFD_Btn_Click(object sender, EventArgs e)
        {
            // Open the file dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fname = openFileDialog.FileName; // Get the selected file name
                string data = File.ReadAllText(fname); // Read all text from the file

                // Parse employee data from the file
                ProvidedList = ParseEmployeeData(data);

                // Populate the DataGridView with the provided employee data
                PopulateDataGridView(ProvidedList, UI_UnsortedData_DGV);
            }
        }

        // Button click event to sort data by Employee ID using selection sort and display the sorted data
        private void UI_SortByEmployeeID_Btn_Click(object sender, EventArgs e)
        {
            sw.Restart(); // Restart the stopwatch to measure sorting time
            UI_SortedData_DGV.Rows.Clear(); // Clear the sorted data in DataGridView

            // Sort the data by Employee ID
            if (UI_ProvidedList_Radio.Checked)
            {
                SelectionSort(LocalList); // Sort the LocalList
                PopulateDataGridView(LocalList, UI_SortedData_DGV); // Display the sorted data
            }
            else
            {
                SelectionSort(ProvidedList); // Sort the ProvidedList
                PopulateDataGridView(ProvidedList, UI_SortedData_DGV); // Display the sorted data
            }

            sw.Stop(); // Stop the stopwatch after sorting
            UI_Timer_Tbx.Text = $"{sw.ElapsedMilliseconds}"; // Display sorting time in the textbox
        }

        // Button click event to sort data by Last Name using insertion sort and display the sorted data
        private void UI_SortByLastNames_Btn_Click(object sender, EventArgs e)
        {
            sw.Restart(); // Restart the stopwatch to measure sorting time
            UI_SortedData_DGV.Rows.Clear(); // Clear the sorted data in DataGridView

            // Sort the data by Last Name
            if (UI_ProvidedList_Radio.Checked)
            {
                InsertionSort(LocalList); // Sort the LocalList by Last Name
                PopulateDataGridView(LocalList, UI_SortedData_DGV); // Display the sorted data
            }
            else
            {
                InsertionSort(ProvidedList); // Sort the ProvidedList by Last Name
                PopulateDataGridView(ProvidedList, UI_SortedData_DGV); // Display the sorted data
            }

            sw.Stop(); // Stop the stopwatch after sorting
            UI_Timer_Tbx.Text = $"{sw.ElapsedMilliseconds}"; // Display sorting time in the textbox
        }

        // Button click event to clear the sorted data from DataGridView and reset the timer
        private void UI_ClearSorted_Btn_Click(object sender, EventArgs e)
        {
            UI_SortedData_DGV.Rows.Clear(); // Clear the DataGridView
            UI_Timer_Tbx.Text = "0"; // Reset the timer textbox to 0
        }

        // Event to handle drag and drop operation to the unsorted DataGridView
        private void UI_UnsortedData_DGV_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged data is a file (FileDrop) and allow copy if true
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Allow copy operation
            else
                e.Effect = DragDropEffects.None; // Disallow drop if it's not a file
        }

        // Event to handle file drop into the unsorted DataGridView
        private void UI_UnsortedData_DGV_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First(); // Get the dropped file path
            string data = File.ReadAllText(fname); // Read the content of the dropped file

            ProvidedList = ParseEmployeeData(data); // Parse the employee data from the file
            PopulateDataGridView(ProvidedList, UI_UnsortedData_DGV); // Display the parsed data in the DataGridView
        }

        // Radio button checked change event to enable file drop functionality and open file dialog button
        private void UI_FileData_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_FileData_Radio.Checked)
            {
                UI_UnsortedData_DGV.AllowDrop = true; // Enable drag-and-drop for the DataGridView
                UI_OFD_Btn.Enabled = true; // Enable the open file dialog button
            }
            else
            {
                UI_UnsortedData_DGV.AllowDrop = false; // Disable drag-and-drop
                UI_OFD_Btn.Enabled = false; // Disable the open file dialog button
            }
        }

        // Selection Sort algorithm to sort Employee list by Employee ID
        static private void SelectionSort(List<Employee> list1)
        {
            int n = list1.Count;

            for (int pass = 0; pass < n - 1; pass++)
            {
                int max_posn = 0; // To keep track of the position of the maximum value
                int last_posn = n - 1 - pass; // Last unsorted position

                for (int j = 0; j <= last_posn; j++)
                {
                    // Find the maximum Employee ID in the unsorted part of the list
                    if (list1[j]._employeeId > list1[max_posn]._employeeId)
                    {
                        max_posn = j; // Update the maximum position
                    }
                }

                // Swap the maximum element found with the last unsorted element
                Swap(list1, max_posn, last_posn);
            }
        }

        // Method to swap two elements in the list
        static private void Swap(List<Employee> list2, int posn1, int posn2)
        {
            Employee temp = list2[posn1];
            list2[posn1] = list2[posn2];
            list2[posn2] = temp;
        }

        // Insertion Sort algorithm to sort Employee list by Last Name
        static private void InsertionSort(List<Employee> emp)
        {
            int n = emp.Count;

            // pp is the pass number, starting from 1
            for (int p = 1; p < n; p++)
            {
                Employee temp = emp[p]; // Temporarily store the Employee object
                int j = p - 1; // Look behind the current element

                // Shift elements that are lexicographically larger than temp to the right
                while (j >= 0 && emp[j]._lastName.CompareTo(temp._lastName) > 0)
                {
                    emp[j + 1] = emp[j]; // Shift element one position to the right
                    j = j - 1; // Move j back one position
                }

                // Place the temporary employee at the correct position
                emp[j + 1] = temp;
            }
        }

        // Method to populate the DataGridView with employee data
        private void PopulateDataGridView(List<Employee> employeeList, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear(); // Clear existing rows in DataGridView

            // Loop through the employee list and add rows to DataGridView
            foreach (Employee emp in employeeList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = emp._employeeId });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = emp._firstName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = emp._lastName });
                dataGridView.Rows.Add(row); // Add the row to DataGridView
            }
        }

        // Method to parse employee data from a string
        private List<Employee> ParseEmployeeData(string data)
        {
            List<Employee> employeeList = new List<Employee>();

            // Split the data by lines to process each employee record
            string[] lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim(); // Trim whitespace from the line
                string[] parts = trimmedLine.Split(','); // Split the line by commas

                // Ensure the line contains exactly 3 parts: ID, First Name, and Last Name
                if (parts.Length == 3)
                {
                    // Parse the values and assign to the Employee struct
                    int employeeId = int.Parse(parts[0].Trim());
                    string firstName = parts[1].Trim();
                    string lastName = parts[2].Trim();

                    Employee emp = new Employee();
                    emp._employeeId = employeeId;
                    emp._firstName = firstName;
                    emp._lastName = lastName;

                    // Add the Employee to the list
                    employeeList.Add(emp);
                }
            }

            return employeeList; // Return the parsed list of employees
        }
    }
}
