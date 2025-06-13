/* Program     : ICA13
 * Description : Fontify
 * Date        : 19 March 2025
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

namespace ICA13_SanjayK
{
    public partial class ModalDialogForm : Form
    {
        //Declaring font type variable
        Font fontFamily;

        //Declaring font type variable
        Color textColor;

        public ModalDialogForm()
        {
            InitializeComponent();

            //Giving text to ModalDialogForm
            this.Text = "Select Font/Colour";
        }

        /// <summary>
        /// Hiting ok send the value Main Form and change the color and font of text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// This method display the default color and font of text
        /// </summary>
        /// <param name="font"></param>
        /// <param name="color"></param>
        public void Default(Font font, Color color)
        {
            UI_Font_Lbl.Text = font.ToString();
            UI_Colour_Lbl.Text = color.ToString();

            fontFamily = font;
            textColor = color;
        }

        /// <summary>
        /// After hiting button ask user to select font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_SelectFont_Btn_Click(object sender, EventArgs e)
        {
            if (UI_FontDialog.ShowDialog() == DialogResult.OK)
            {
                fontFamily = UI_FontDialog.Font;

                UI_Font_Lbl.Text = fontFamily.ToString();
            }
        }

        /// <summary>
        /// After hiting button ask user to select color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_SelectColour_Btn_Click(object sender, EventArgs e)
        {
            if (UI_ColorDialog.ShowDialog() == DialogResult.OK)
            {
                textColor = UI_ColorDialog.Color;

                UI_Colour_Lbl.Text = textColor.ToString();
            }
        }

        /// <summary>
        /// This method sets font of text
        /// </summary>
        /// <returns></returns>
        public Font FontFamily()
        {
            Font font = fontFamily;

            return font;
        }

        /// <summary>
        /// This method sets color of text
        /// </summary>
        /// <returns></returns>
        public Color Color()
        {
            Color color = textColor;

            return color;
        }
    }
}
