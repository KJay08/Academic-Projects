/* Program     : ICA12
 * Description : QuickSort
 * Date        : 17 March 2025
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
using System.Collections.Concurrent;
using System.Diagnostics;

namespace ICA12_SanjayK
{
    public partial class UI_ClearUnsorted_Btn: Form
    {
        // Stopwatch to measure the performance of sorting
        Stopwatch sw = new Stopwatch();

        // Employee structure containing ID and Salary
        private struct Employee
        {
            public int _ID;    // Employee ID
            public int _Salary; // Employee Salary
        }

        // Lists to hold employee data
        List<Employee> LocalList = new List<Employee>();
        List<Employee> ProvidedList = new List<Employee>();

        // Sample employee data (IDs and Salaries)
        int[] empID = new int[] { 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
        int[] empSalary = new int[] { 4500, 2800, 1900, 3100, 7000, 3500, 2200, 2800, 2850, 3150, 4000, 4500, 6000, 7200, 3700, 2100, 2450, 2500, 3250, 3700, 3800, 4200, 4100, 3900 };

        // Constructor to initialize components
        public UI_ClearUnsorted_Btn()
        {
            InitializeComponent();
        }

        // Convert employee data into an Employee struct
        private Employee ConvertStruct(int empID, int empSalary)
        {
            return new Employee { _ID = empID, _Salary = empSalary };
        }

        // Format Employee struct into a string for displaying in the UI
        private string EmployeeToString(Employee emp)
        {
            return $"{emp._ID} : \t\t {emp._Salary}";
        }

        // Populate the listbox with employee data (either from LocalList or ProvidedList)
        private void DisplayList(List<Employee> list, ListBox listBox, int[] id, int[] salary)
        {
            // Clear the list before adding new items
            list.Clear();

            // Add employees from empID and empSalary arrays
            for (int i = 0; i < empID.Length; i++)
            {
                list.Add(ConvertStruct(id[i], salary[i]));
            }

            // Display each employee in the ListBox
            foreach (Employee emp in LocalList)
            {
                listBox.Items.Add(EmployeeToString(emp));
            }
        }

        // Button click event to display unsorted employee data
        private void UI_DisplayUnsorted_Btn_Click(object sender, EventArgs e)
        {
            // Clear previous items from the ListBox
            UI_UnsortedData_Lbx.Items.Clear();

            // Check if the ProvidedList is selected to display
            if (UI_ProvidedList_Radio.Checked)
            {
                // Display LocalList
                DisplayList(LocalList, UI_UnsortedData_Lbx, empID, empSalary);
            }
            else
            {
                // Display ProvidedList if radio button is not checked
                foreach (Employee emp in ProvidedList)
                {
                    UI_UnsortedData_Lbx.Items.Add(EmployeeToString(emp));
                }
            }
        }

        // Clear the unsorted data list box
        private void UI_UnsortedClear_Btn_Click(object sender, EventArgs e)
        {
            UI_UnsortedData_Lbx.Items.Clear();
        }

        // Handle drag event for file drop (for reading employee data from a file)
        private void UI_DragAndDrop_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Allow file drop
            else
                e.Effect = DragDropEffects.None; // Prevent drop if it's not a file
        }

        // Handle drop event (reading the file and adding employee data)
        private void UI_DragAndDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            ProvidedList.Clear(); // Clear previous data

            // Get the file name from the dropped files
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();

            // Read the lines of the file
            string[] empData = File.ReadAllLines(fname);

            // Parse each line and add employee data to ProvidedList
            for (int i = 0; i < empData.Length; i++)
            {
                string[] splitData = empData[i].Split(',');

                int id;
                int salary;

                // Try parsing the ID and Salary values from the file
                int.TryParse(splitData[0], out id);
                int.TryParse(splitData[1], out salary);

                // Add employee to the list
                ProvidedList.Add(ConvertStruct(id, salary));
            }
        }

        // Button click event to display sorted employee data
        private void UI_DisplaySort_Btn_Click(object sender, EventArgs e)
        {
            sw.Restart(); // Start the stopwatch to measure sorting time

            // Clear the sorted list box before displaying new data
            UI_SortedData_Lbx.Items.Clear();

            // Check if ProvidedList is selected
            if (UI_ProvidedList_Radio.Checked)
            {
                // Sort the LocalList using QuickSort and display the sorted data
                QuickSort(LocalList, 0, LocalList.Count - 1);
                foreach (Employee emp in LocalList)
                {
                    UI_SortedData_Lbx.Items.Add(EmployeeToString(emp));
                }
            }
            else
            {
                // Sort the ProvidedList using QuickSort and display the sorted data
                QuickSort(ProvidedList, 0, ProvidedList.Count - 1);
                foreach (Employee emp in ProvidedList)
                {
                    UI_SortedData_Lbx.Items.Add(EmployeeToString(emp));
                }
            }

            sw.Stop(); // Stop the stopwatch after sorting

            // Display the time taken to sort the data
            UI_Timer_Tbx.Text = $"{sw.ElapsedMilliseconds} ms";

            //LocalList.Clear();
            //ProvidedList.Clear();
        }

        // QuickSort algorithm for sorting the list of employees
        private void QuickSort(List<Employee> list, int low, int high)
        {
            if (low < high)
            {
                // Find the partition index and recursively sort both halves
                int pi = Partition(list, low, high);

                QuickSort(list, low, pi - 1); // Sort the left part
                QuickSort(list, pi + 1, high); // Sort the right part
            }
        }

        // Partition function used by QuickSort to rearrange the elements
        private int Partition(List<Employee> myList, int lowIndex, int highIndex)
        {
            int pivot = myList[highIndex]._ID; // Using _ID as the pivot for comparison

            int i = lowIndex - 1;

            // Loop to compare and rearrange elements based on pivot
            for (int j = lowIndex; j < highIndex; j++)
            {
                if (myList[j]._ID < pivot) // If current element is less than pivot
                {
                    i++;
                    Swap(myList, i, j); // Swap elements
                }
            }

            // Place pivot in the correct position and return the index
            Swap(myList, i + 1, highIndex);
            return i + 1;
        }

        // Swap two elements in the list
        private void Swap(List<Employee> list1, int posn1, int posn2)
        {
            Employee temp = list1[posn1];
            list1[posn1] = list1[posn2];
            list1[posn2] = temp;
        }

        // Clear the sorted data list box
        private void UI_SortedClear_Btn_Click(object sender, EventArgs e)
        {
            UI_SortedData_Lbx.Items.Clear();
        }
    }
}
