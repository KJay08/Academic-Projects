/* Program     : ICA03
 * Description : Stopwatch
 * Date        : 27 Jan. 2025
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
using System.Diagnostics;

namespace ICA03_SanjayK
{
    public partial class Form1 : Form
    {
        // assigning stopwatch
        private static Stopwatch sw = new Stopwatch();

        //Using splitSet to make count intially zero to display 
        bool splitSet = true;

        // declaring count for split count
        private int count;
        public Form1()
        {
            InitializeComponent();
            count = 0;
        }

        //This event tracking time and displaying on label
        private void UI_Change_Timer_Tick(object sender, EventArgs e)
        {
            UI_Time_Lbl.Text = DisplayTime(count);
        }

        //This event check for start button clicks
        private void UI_StartWatch_Btn_Click(object sender, EventArgs e)
        {
            sw.Start();
        }

        //This event check for stop button clicks
        private void UI_StopWatch_Btn_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }

        //This event check for reset button clicks
        private void UI_ResetWatch_Btn_Click(object sender, EventArgs e)
        {
            sw.Reset();

            //Again assigning the count and splitset to zero and true respectively to reset count
            count = 0;
            splitSet = true;

            //Clearing the listbox
            UI_Time_Lbx.Items.Clear();
        }

        //This event check for split button clicks display the count split on listbox
        private void UI_SplitWatch_Btn_Click(object sender, EventArgs e)
        {
            string newTime = DisplayTime(count);

            //Checking that list box contains same string, if not then display the time in list box 
            if (!UI_Time_Lbx.Items.Contains(newTime))
            {
                if (count == 0 && splitSet)
                {
                    count = 0;
                    splitSet = false;
                }
                else
                {
                    count++;
                }

                //Displaying the time in list box
                UI_Time_Lbx.Items.Add(DisplayTime(count));
            }
        }

        /// <summary>
        /// Method  :  private string DisplayTime()
        /// Purpose : to display time on label and list box
        /// </summary>
        /// <returns>formatted time : time to display</returns>
        private string DisplayTime(int count)
        {
            //Getting milliseconds value from stopwatch
            double ms = sw.ElapsedMilliseconds;

            // Dividing for seconds
            int sec = (int)ms / 1000;

            //Dividing for minutes
            int min = sec/60;

            //Dividing for hours
            int hour = min/60;

            ms %= 1000;
            sec %= 60;
            min %= 60;

            int hundredths = (int)ms / 10;

            //Formatting time to display
            string formattedTime = $"({count}) {hour:D2}:{min:D2}:{sec:D2}.{hundredths:D2}";
            return formattedTime;
        }
    }
}
