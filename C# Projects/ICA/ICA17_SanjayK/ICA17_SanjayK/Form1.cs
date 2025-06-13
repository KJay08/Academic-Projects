/* Program     : ICA17
 * Description : Thready Colour Analyzer
 * Date        : 9 April, 2025
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
using System.Xml.Linq;
using System.Threading;

namespace ICA17_SanjayK
{
    public partial class Form1 : Form
    {
        //Declaring List of string for files Names and List of Thread
        List<string> files;
        List<Thread> threadList = new List<Thread>();

        Action<string, double, double, double> delDisplayLbx;
        public Form1()
        {
            InitializeComponent();

            this.Text = "Image Info Scanner";

            delDisplayLbx = displayLbx;
        }

        private void UI_Go_Btn_Click(object sender, EventArgs e)
        {
            // Open file dialog to select images
            if (UI_OFD.ShowDialog() == DialogResult.OK)
            {
                // Show "Starting..." in the ListBox (append it instead of clearing)
                UI_PicInfo_Lbx.Items.Add("Starting...");
                threadList.Clear();

                files = new List<string>(UI_OFD.FileNames);

                // No need to clear the thread list, keep all previous threads intact
                foreach (string fileName in files)
                {
                    // Create a new thread for each image and pass the file name as a parameter
                    Thread t = new Thread(PicInfo);
                    t.IsBackground = true;  // Make thread background
                    t.Name = fileName;      // Set the thread's name to the file name for easy tracking
                    threadList.Add(t);      // Add to thread list
                    t.Start(fileName);      // Start the thread and pass the file name
                }

                // Enable the timer to check thread status
                UI_Timer.Enabled = true;
            }
        }

        /// <summary>
        /// This method calculates the color RGB 
        /// </summary>
        /// <param name="obj"></param>
        private void PicInfo(object obj)
        {
            //Casting the obj
            string fName = (string)obj;

            try
            {
                //Bitmap to get pixel of the image
                Bitmap bm = (Bitmap)Bitmap.FromFile(fName);

                int totalPixel = bm.Width * bm.Height;

                double redTotal = 0, greenTotal = 0, blueTotal = 0;

                //Looping through every pixel and accumlate rgb values
                for (int x = 0; x < bm.Width; x++)
                {
                    for (int y = 0; y < bm.Height; y++)
                    {
                        Color pixelColor = bm.GetPixel(x, y);

                        redTotal += pixelColor.R;
                        greenTotal += pixelColor.G;
                        blueTotal += pixelColor.B;
                    }
                }

                double totalColor = redTotal + greenTotal + blueTotal;

                //Calculating Composition of red, green and blue
                double RedP = (redTotal / totalColor);
                double GreenP = (greenTotal / totalColor);
                double BlueP = (blueTotal / totalColor);

                Invoke(delDisplayLbx, fName, RedP, GreenP, BlueP);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        /// <summary>
        /// This method display the values of color and file name on listbox
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="RedP"></param>
        /// <param name="GreenP"></param>
        /// <param name="BlueP"></param>
        private void displayLbx(string fName, double RedP, double GreenP, double BlueP)
        {
            UI_PicInfo_Lbx.Items.Add($"(R:{RedP:P1}, G:{GreenP:P1}, B:{BlueP:P1}) : {fName}");
        }

        /// <summary>
        /// This event use timer and iterate through threadList and check that all thread must be stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            if (threadList == null || threadList.Count == 0)
            {
                return; // Guard clause to prevent null or empty list access
            }

            int count = 0;

            // Check each thread in the thread list to see if it is still running
            foreach (Thread t in threadList)
            {
                if (t.ThreadState == ThreadState.Stopped)
                {
                    count++;
                }
            }

            // If all threads are done, stop the timer and show "Done"
            if (count == threadList.Count)
            {
                // Disable the timer as all threads are finished
                UI_Timer.Enabled = false;

                // Update the ListBox with the "Done..." message
                UI_PicInfo_Lbx.Items.Add("Done...");
            }
        }
    }
}
