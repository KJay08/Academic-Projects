/* Program     : ICA04
 * Description : Car Rental
 * Date        : 4 Feb. 2025
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

namespace ICA04_SanjayK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Creating event handlers for insurance and discount checkbox change events
            UI_Insurance_Cbx.CheckedChanged += UI_PerDay_Radio_CheckedChanged;
            UI_Discount_Cbx.CheckedChanged += UI_PerDay_Radio_CheckedChanged;
        }

        // Event handler for when the name text box (UI_Name_Tbx) text changes
        // This method enables or disables other components based on whether the name field is filled
        private void UI_Name_Tbx_TextChanged(object sender, EventArgs e)
        {
            // If the name field is not empty, enable the input components for rental options
            if (UI_Name_Tbx.Text.Length > 0)
            {
                UI_GroupBox.Enabled = true;
                UI_Discount_Cbx.Enabled = true;
                UI_Insurance_Cbx.Enabled = true;
                UI_NumDays_Lbl.Enabled = true;
                UI_NumDays_UpDown.Enabled = true;
                UI_Insurance_Cbx.Enabled = true;
                UI_Total_Lbl.Enabled = true;
            }
            else
            {
                // If the name field is empty, disable all the rental option components
                UI_GroupBox.Enabled = false;
                UI_Discount_Cbx.Enabled = false;
                UI_Insurance_Cbx.Enabled = false;
                UI_NumDays_Lbl.Enabled = false;
                UI_NumDays_UpDown.Enabled = false;
                UI_Insurance_Cbx.Enabled = false;
                UI_Total_Lbl.Enabled = false;
            }

            // If the group box is enabled, display a default total of $40
            if (UI_GroupBox.Enabled)
            {
                UI_Total_Lbl.Text = $"Total    :    {40:C2}";
            }
            else
            {
                UI_Total_Lbl.Text = $"Total    :    {0:C2}"; // Otherwise, show a total of $0
            }
        }

        // Event handler for the per-day rent radio buttons (UI_PerDay_Radio)
        // This method checks which radio button is selected to set the appropriate per-day rental price
        private void UI_PerDay_Radio_CheckedChanged(object sender, EventArgs e)
        {
            // If the name field is not empty, enable the input components for rental options
            if (UI_Name_Tbx.Text.Length > 0)
            {
                UI_GroupBox.Enabled = true;
                UI_Discount_Cbx.Enabled = true;
                UI_Insurance_Cbx.Enabled = true;
                UI_NumDays_Lbl.Enabled = true;
                UI_NumDays_UpDown.Enabled = true;
                UI_Insurance_Cbx.Enabled = true;
                UI_Total_Lbl.Enabled = true;
            }
            else
            {
                // If the name field is empty, disable all the rental option components
                UI_GroupBox.Enabled = false;
                UI_Discount_Cbx.Enabled = false;
                UI_Insurance_Cbx.Enabled = false;
                UI_NumDays_Lbl.Enabled = false;
                UI_NumDays_UpDown.Enabled = false;
                UI_Insurance_Cbx.Enabled = false;
                UI_Total_Lbl.Enabled = false;
            }

            // If the group box is enabled, display a default total of $40
            if (UI_GroupBox.Enabled)
            {
                UI_Total_Lbl.Text = $"Total    :    {40:C2}";
            }
            else
            {
                UI_Total_Lbl.Text = $"Total    :    {0:C2}"; // Otherwise, show a total of $0
            }

            // Initializing variables to calculate the total rent, per day rent, discount, and insurance
            double perDay = 0, discount, insurance;
            int numDays;

            // Get the number of days from the numeric up-down control
            numDays = (int)UI_NumDays_UpDown.Value;

            // Set the per day rent based on the selected radio button
            if (UI_40PerDay_Radio.Checked)
            {
                perDay = 40;
            }
            else if (UI_50PerDay_Radio.Checked)
            {
                perDay = 50;
            }
            else if (UI_60PerDay_Radio.Checked)
            {
                perDay = 60;
            }

            // If the discount checkbox is checked, apply 10% discount
            if (UI_Discount_Cbx.Checked)
            {
                discount = 0.10;
            }
            else
            {
                discount = 0; // No discount if unchecked
            }

            // If the insurance checkbox is checked, apply insurance charges of $15 per day
            if (UI_Insurance_Cbx.Checked)
            {
                insurance = 15;
            }
            else
            {
                insurance = 0; // No insurance charge if unchecked
            }

            // Recalculate and update the total after changing the per-day rent
            UI_Total_Lbl.Text = $"Total    :    {Calculate(perDay, insurance, discount, numDays):C2}";
        }
        

        /// </summary>
        /// Method: Calculate()
        /// Purpose: To calculate the total rental cost based on the user’s preferences
        ///          including the selected per-day rent, number of days, any discount, and insurance.
        /// </summary>
        /// <param name="perDay"></param>
        /// <param name="insurance"></param>
        /// <param name="discount"></param>
        /// <param name="numDays"></param>
        /// <returns>Total: The calculated total cost as a double value</returns>
        public double Calculate(double perDay, double insurance, double discount, int numDays)
        {
            // Calculate the initial total by multiplying per day rent by the number of days
            double total = perDay * numDays;

            // If insurance is applied, add the insurance charge to the total cost
            if (insurance > 0)
            {
                total = total + (insurance * numDays);
            }

            // If a discount is applied, subtract the discount percentage from the total cost
            if (discount > 0)
            {
                total = total - (total * discount);
            }

            // Return the final total
            return total;
        }
    }
}

