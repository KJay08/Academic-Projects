/* Program     : ICA05
 * Description : Struct with GDI
 * Date        : 7 Feb. 2025
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
using GDIDrawer;
using static System.Windows.Forms.LinkLabel;

namespace ICA05_SanjayK
{
    // Define the Form class, which is the main window of the application
    public partial class Form1 : Form
    {
        // Structure to represent a line
        private struct SLine
        {
            public Point _Start;     // Starting point of the line
            public Point _End;       // Ending point of the line
            public Color _Color;     // Color of the line
            public byte _Thickness;  // Thickness of the line
        }

        // Create a canvas (drawing surface) to render lines
        CDrawer canvas = new CDrawer(800, 800, false);

        // Define variables for storing points and line information
        Point xStart;  
        Point xEnd;

        // List to store all the drawn lines
        List<SLine> lines = new List<SLine>();

        // Define the possible states of the application (Idle or Armed for drawing)
        private enum eState { State_Idle, State_Armed };
        eState state = eState.State_Idle; // Initial state is Idle

        // Temporary variable to store the current line being drawn
        SLine Line = new SLine();

        // Random object for generating random colors and line thickness
        Random random = new Random();

        // Constructor to initialize the form
        public Form1()
        {
            InitializeComponent();
        }

        // Timer event that continuously checks for user interactions (mouse clicks)
        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            // Point variable to store the mouse position when a click occurs
            Point P;

            // Check if the user clicked the left mouse button
            if (canvas.GetLastMouseLeftClick(out P))
            {
                // If in idle state, start drawing the line
                if (state == eState.State_Idle)
                {
                    // Set the start point of the line and store it
                    xStart = P;
                    Line._Start = xStart;

                    // Change state to Armed (ready to capture the endpoint)
                    state = eState.State_Armed;
                    Text = "State Armed";
                }
                else
                {
                    // If in armed state, set the end point of the line
                    xEnd = P;
                    Line._End = xEnd;

                    // Set the line color to red and thickness to 5 (as per the requirements)
                    Line._Color = Color.Red;
                    Line._Thickness = 5;

                    // Render the current line and add it to the list of lines
                    Render(Line);
                    // Update the canvas to show the new line
                    canvas.Render();
                    lines.Add(Line);

                    // Change state back to Idle
                    state = eState.State_Idle;
                    Text = "State Idle";
                }
            }
            // Check if the user clicked the right mouse button to clear the canvas
            else if(canvas.GetLastMouseRightClick(out P))
            {
                Random rand = new Random();
                List<SLine> newLines = new List<SLine>();

                // Using a for loop to iterate through the lines collection
                for (int i = 0; i < lines.Count; i++)
                {
                    SLine modifiedLine = lines[i];
                    modifiedLine._Color = RandColor.GetColor();
                    modifiedLine._Thickness = (byte)rand.Next(1, 17);
                    lines[i] = modifiedLine;
                }

                Render(); // Render all lines
            }
        }

        // Method to render a single line on the canvas
        private void Render(SLine line)
        {
            // Draw the line on the canvas with the specified start and end points, color, and thickness
            canvas.AddLine(line._Start.X, line._Start.Y, line._End.X, line._End.Y, line._Color, line._Thickness);

        }

        // Method to render all lines stored in the 'lines' list on the canvas
        private void Render()
        {
            // Clear the canvas before redrawing
            canvas.Clear();

            // Loop through each line in the list and render it on the canvas
            foreach (SLine line in lines)
            {
                Render(line);
            }

            // Update the canvas to show the redrawn lines
            canvas.Render();
        }
    }
}
