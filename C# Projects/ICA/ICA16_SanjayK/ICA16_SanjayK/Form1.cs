/* Program     : ICA16
 * Description : PallyThread : Palindrome Hunter!
 * Date        : 7 April 2025
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
using System.Threading;


namespace ICA16_SanjayK
{
    public partial class Form1 : Form
    {
        //Declaring stopwatch, list of string, and thread
        Stopwatch sw = new Stopwatch();
        List<string> _lines = null;
        Thread Th = null;

        //Declaring delegate 
        Action<List<string>, long> delShowTbx = null;
        public Form1()
        {
            InitializeComponent();

            this.Text = "Pally Hunter!";

            //Assigning delegate to method 
            delShowTbx = DisplayPalindrome;
        }

        /// <summary>
        /// This recursive method return true or false according to palindrome nature of string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="lowI"></param>
        /// <param name="highI"></param>
        /// <returns></returns>
        public bool RIsPalindrome(string str, int lowI, int highI)
        {
            if (highI <= lowI)
            {
                return true;
            }

            if (str[lowI] != str[highI])
            {
                return false;
            }
            else
            {
                return RIsPalindrome(str, lowI + 1, highI - 1);
            }
        }

        /// <summary>
        /// This event test for sample
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_SimpleTest_Btn_Click(object sender, EventArgs e)
        {
            string test = UI_Test_Tbx.Text;

            bool palindrome = RIsPalindrome(test, 0, test.Length - 1);

            if (palindrome)
            {
                UI_Test_Tbx.Text = $"\'{test}\' is a palindrome!";
            }
            else
            {
                UI_Test_Tbx.Text = $"\'{test}\' is not a palindrome!";
            }
        }

        /// <summary>
        /// This event load the file and add it list of string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_LoadFile_Btn_Click(object sender, EventArgs e)
        {
            if (UI_OFD.ShowDialog() == DialogResult.OK)
            {
                _lines = new List<string>(File.ReadAllLines(UI_OFD.FileName));
            }

            UI_DisplayFile_Tbx.Text = $"Loaded {_lines.Count} words!";
        }

        /// <summary>
        /// This event find all the palindrome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Find_Btn_Click(object sender, EventArgs e)
        {
            if (_lines == null)
            {
                MessageBox.Show("Please load a file first");
                return;
            }

            UI_DisplayFile_Tbx.Text = "Working....";
            sw.Restart();
            Th = new Thread(GetPalindrome);
            Th.IsBackground = true;
            Th.Start();
        }

        /// <summary>
        /// This method display the palindrome string from loaded file usig delegate
        /// </summary>
        /// <param name="palindromeList"></param>
        /// <param name="time"></param>
        private void DisplayPalindrome(List<string> palindromeList, long time)
        {
            UI_DisplayFile_Tbx.Text = $"{string.Join(", ", palindromeList)} ----Found {palindromeList.Count} in {time}ms!";
        }

        /// <summary>
        /// This method search for palindromes from loaded file
        /// </summary>
        private void GetPalindrome()
        {
            bool isPal;
            List<string> palindromeList = new List<string>();

            for (int i = 0; i < _lines.Count; i++)
            {
                isPal = RIsPalindrome(_lines[i], 0, _lines[i].Length - 1);

                if (isPal)
                {
                    palindromeList.Add(_lines[i]);
                }
            }

            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            Invoke(delShowTbx, palindromeList, time) ;
        }
    }
}
