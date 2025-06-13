/* Program     : ICA09
 * Description : Basic forms of Recursion
 * Date        : 9 March 2025
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

namespace ICA09_SanjayK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the string in preorder traversal from the character array.
        /// </summary>
        /// <param name="chars">Character array to process</param>
        /// <param name="start">Index from which recursion starts</param>
        /// <param name="end">End index of the array</param>
        private string GetPreOrder(char[] chars, int start, int end)
        {
            if (start > end)
            {
                return "";
            }
            return chars[start] + GetPreOrder(chars, start + 1, end);
        }

        /// <summary>
        /// Gets the string in postorder traversal from the character array.
        /// </summary>
        /// <param name="chars">Character array to process</param>
        /// <param name="start">Index from which recursion starts</param>
        /// <param name="end">End index of the array</param>
        private string GetPostOrder(char[] chars, int start, int end)
        {
            if (start > end)
            {
                return "";
            }
            return GetPostOrder(chars, start + 1, end) + chars[start];
        }

        /// <summary>
        /// Finds all the factors of a given number starting from a given position.
        /// </summary>
        /// <param name="num">Number to find factors of</param>
        /// <param name="pos">Current position to check for a factor</param>
        private string FindFactors(int num, int pos)
        {
            string factors = "";

            if (pos > num)
            {
                return "";
            }

            if (num % pos == 0)
            {
                factors = pos + " ";
            }

            return factors + FindFactors(num, pos + 1);
        }

        /// <summary>
        /// Counts the number of uppercase letters in a string using recursion.
        /// </summary>
        /// <param name="str">Input string to check</param>
        /// <param name="low">Starting index</param>
        /// <param name="high">Ending index</param>
        private int CountUppercase(string str, int low, int high)
        {
            if (low > high)
            {
                return 0;
            }

            if (low == high)
            {
                if (char.IsUpper(str[low])) return 1;
                else return 0;
            }
            else
            {
                int mid = (low + high) / 2;
                int leftCount = CountUppercase(str, low, mid);
                int rightCount = CountUppercase(str, mid + 1, high);
                return leftCount + rightCount;
            }
        }

        /// <summary>
        /// Handles the event for the RecShow button click
        /// Processes the input string and displays its preorder traversal.
        /// </summary>
        private void UI_RecShow_Btn_Click(object sender, EventArgs e)
        {
            UI_OutputString_Tbx.Clear();

            char[] inputChars = UI_InputString_Tbx.Text.ToCharArray();
            string result = GetPreOrder(inputChars, 0, inputChars.Length - 1);

            UI_OutputString_Tbx.Text = result;
        }

        /// <summary>
        /// Handles the event for the RecReverse button click
        /// Processes the input string and displays its postorder traversal.
        /// </summary>
        private void UI_RecReverse_Btn_Click(object sender, EventArgs e)
        {
            UI_OutputString_Tbx.Clear();

            char[] inputChars = UI_InputString_Tbx.Text.ToCharArray();
            string result = GetPostOrder(inputChars, 0, inputChars.Length - 1);

            UI_OutputString_Tbx.Text = result;
        }

        /// <summary>
        /// Handles the event for the FindFactors button click
        /// Finds and displays all the factors of a given number.
        /// </summary>
        private void UI_FindFactors_Btn_Click(object sender, EventArgs e)
        {
            UI_OutputFactor_Tbx.Clear();

            int number = (int)UI_NumericUpDown.Value;
            string result = FindFactors(number, 1);

            UI_OutputFactor_Tbx.Text = result.Trim();
        }

        /// <summary>
        /// Handles the event for the FindUpperCase button click
        /// Counts and displays the number of uppercase letters in the input string.
        /// </summary>
        private void UI_FindUpperCase_Btn_Click(object sender, EventArgs e)
        {
            string userInput = UI_InputUpper_Tbx.Text;
            int upperCount = CountUppercase(userInput, 0, userInput.Length - 1);

            UI_OutputUpper_Tbx.Text = $"There are {upperCount} uppercase letters";
        }
    }
}
