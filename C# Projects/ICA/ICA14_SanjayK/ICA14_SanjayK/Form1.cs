/* Program     : ICA14
 * Description : StringBender (Early Delegates)
 * Date        : 24 March 2025
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

namespace ICA14_SanjayK
{
    public partial class Form1 : Form
    {
        //Declaring delegate
        public delegate string delString(string str);

        //Assgning delegate to null
        private delString delIntial = null;
        public Form1()
        {
            InitializeComponent();

            Console.WriteLine($"{Flipcase("tHis is Me")}");
        }

        /// <summary>
        /// This method take string as parameter return uppercase version of it
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Uppercase(string s)
        {
            return s.ToUpper();
        }

        /// <summary>
        /// This method take string as parameter return lowercase version of it
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Lowercase(string s)
        {
            return s.ToLower();
        }

        /// <summary>
        /// This method take string as parameter retrun flipcase version of it
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Flipcase(string s)
        {
            //assign string
            string newString = "";

            for (int i = 0; i < s.Length; i++)
            {
                //assigning character
                char c = ' ';

                if (char.IsLower(s[i]))
                {
                    c = char.ToUpper(s[i]);
                }
                else if (char.IsUpper(s[i]))
                {
                    c = char.ToLower(s[i]);
                }

                //Adding character to string
                newString += c;
            }

            return newString;
        }

        /// <summary>
        /// This method update the output according to invoke of user selection 
        /// </summary>
        private void Update()
        {
            ProgChoice();
            del(UI_InputString_Tbx.Text);
        }

        /// <summary>
        /// This method assign delegate according radio button(user choice)
        /// </summary>
        private void ProgChoice()
        {
            // Check which radio button is selected and assign the delegate accordingly
            if (UI_Uppercase_Radio.Checked)
            {
                delIntial = new delString(Uppercase);
                Console.WriteLine("Delegate assigned to Uppercase");
            }
            else if (UI_LowerCase_Radio.Checked)
            {
                delIntial = new delString(Lowercase);
                Console.WriteLine("Delegate assigned to Lowercase");
            }
            else
            {
                delIntial = new delString(Flipcase);
                Console.WriteLine("Delegate assigned to Flipcase");
            }
        }

        /// <summary>
        /// This method 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string del(string str)
        {
            string output = "";
            if (delIntial != null)
            {
                output = delIntial.Invoke(str);
            }
            return UI_OutputString_Tbx.Text = output;
        }

        /// <summary>
        /// Consolidate of radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ControlChanged(object sender, EventArgs e)
        {
            Update();
        }

        /// <summary>
        /// Consolidate of textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_InputString_Tbx_TextChanged(object sender, EventArgs e)
        {
            Update();
        }
    }
}
