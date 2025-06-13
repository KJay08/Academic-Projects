/* Program     : ICA10
 * Description : FloodFill Algorithm
 * Date        : 12 March 2025
 * Author      : Sanjay Kumar
 * Course      : CMPE1666 - Intermediate Programing
 * Class       : CNTA01
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA10_SanjayK
{
    public partial class Form1: Form
    {
        CDrawer canvas = new CDrawer(800, 600, false);

        // Create a 2D array of Color values with dimentions 80x60
        private Color[,] color = new Color[80, 60];

        Color fillColor = Color.Lavender;

        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();

            // Set the Scale of the GDIDrawer window to 10
            canvas.Scale = 10;
        }

        private void UI_Generate_Btn_Click(object sender, EventArgs e)
        {
            Generate(canvas, UI_Trackbar_Bar.Value);
            canvas.Render();
        }

        private void UI_FillColor_Btn_Click(object sender, EventArgs e)
        {
            if (UI_ColorDialog.ShowDialog() == DialogResult.OK)
            {
                fillColor = UI_ColorDialog.Color;
                UI_ColorDialog_Lbl.BackColor = fillColor;
            }
        }

        /// <summary>
        /// This method generate random grid position for canvas window and fill red colour
        /// </summary>
        /// <param name="canvas"></param>
        /// <param name="numBlocks"></param>
        private void Generate(CDrawer canvas, int numBlocks)
        {
            // placing the color black in each location to clear the contents of the array
            for (int x = 0; x < 80; x++)
            {
                for (int y = 0; y < 60; y++)
                {
                    color[x, y] = Color.Black;  // Initialize with black
                }
            }

            // Drawing a boundary around the outer edges of the screen using Red
            for (int x = 0; x < 80; x++)
            {
                color[x, 0] = Color.Red;        // Top boundary
                color[x, 59] = Color.Red;       // Bottom boundary
            }

            for (int y = 0; y < 60; y++)
            {
                color[0, y] = Color.Red;        // Left boundary
                color[79, y] = Color.Red;       // Right boundary
            }

            // Place random red blocks inside the boundary
            Random rand = new Random();
            
            for (int i = 0; i < numBlocks; i++)
            {
                int randX = rand.Next(1, 79);         // Avoid boundary and go number less
                int randY = rand.Next(1, 59);         // Avoid boundary and go number less
                color[randX, randY] = Color.Red;
            }

            // Display the updated array in the drawing window
            for (int x = 0; x < 80; x++)
            {
                for (int y = 0; y < 60; y++)
                {
                    canvas.SetBBScaledPixel(x, y, color[x, y]);
                }
            }
        }

        /// <summary>
        /// This Recursive method check for targetColor and replace with new color and also replace the color of connected grid
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="targetColor"></param>
        /// <param name="replacementColor"></param>
        private void FloodFill(int x, int y, Color targetColor, Color replacementColor)
        {
            // Base Cases
            if (x < 0 || x >= 80 || y < 0 || y >= 60)
            {
                return; // Out of bounds
            }

            if (color[x, y] != targetColor)
            {
                return;     // Not the target 
            }

            if (color[x, y] == replacementColor)
            {
                return; // Already filled
            }

            //If they fail replace the color in that location of
            //the array with the replacement color
            color[x, y] = replacementColor;
            canvas.SetBBScaledPixel(x, y, replacementColor);

            // Recursive Calls in 4 Times
            FloodFill(x - 1, y, targetColor, replacementColor); // Left
            FloodFill(x + 1, y, targetColor, replacementColor); // Right
            FloodFill(x, y - 1, targetColor, replacementColor); // Up
            FloodFill(x, y + 1, targetColor, replacementColor); // Down
            return;
        }

        private void UI_Fill_Btn_Click(object sender, EventArgs e)
        {
            UI_Timer.Enabled = false;
            UI_Timer.Start();
        }

        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            UI_Timer.Enabled = true;

            // Continuously check for mouse clicks in the drawing window
            Point P;
            if (canvas.GetLastMouseLeftClickScaled(out P))
            {
                if (color[P.X, P.Y] == Color.Black)
                {
                    FloodFill(P.X, P.Y, Color.Black, fillColor);  // Fill black area with the selected color
                    UI_Timer.Stop();
                }

                canvas.Render();
            }

        }
    }
}
