/* Program     : Lab  - 04
 * Description : StackyQueueDraw
 * Date        : 23 April, 2025
 * Author      : Sanjay Kumar
 * Course      : CMPE1666 - Intermediate Programing
 * Class       : CNTA01
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace Lab04_SanjayK
{
    public partial class Form1 : Form
    {
        // Define a structure to represent a line segment with its properties
        public struct LineSeg
        {
            public Point _pStart;     // Starting point of the line
            public Point _pEnd;       // Ending point of the line
            public byte _thickness;   // Thickness of the line
            public float _alpha;      // Transparency value of the line (from 0.0 to 1.0)
            public Color _color;      // Color of the line
        }

        // Queue to hold the line segments for the current drawing
        Queue<LineSeg> lineQueue = new Queue<LineSeg>();

        // Stack to store completed lines (as a queue of line segments)
        Stack<Queue<LineSeg>> Queuestack = new Stack<Queue<LineSeg>>();

        // Canvas object to render the drawings
        CDrawer canvas = new CDrawer(1024, 768, true);

        // Boolean flag to indicate if we are currently drawing
        bool drawing = false;

        // Last position where the mouse was
        Point lastP;

        // Initial alpha (transparency) and thickness of the lines
        float currentAlpha = 0.2f;
        byte currentThickness = 2;

        // Initial color selected for drawing
        Color currentColor = RandColor.GetColor();

        public Form1()
        {
            InitializeComponent();

            this.Text = "StackyListDraw"; // Set the title of the window

            canvas.BBColour = Color.Aqua; // Set the background color of the canvas

            UI_Timer.Interval = 10; // Timer interval to refresh UI regularly

            // Event listeners for mouse actions on the canvas
            canvas.MouseLeftClick += Canvas_MouseLeftClick;
            canvas.MouseRightClick += Canvas_MouseRightClick;
            canvas.MouseMove += Canvas_MouseMove;

            // Mouse wheel event for adjusting alpha (transparency)
            this.MouseWheel += Form1_MouseWheel;
        }

        /// <summary>
        /// Event handler for left mouse click: Start a new line.
        /// </summary>
        private void Canvas_MouseLeftClick(Point pos, CDrawer dr)
        {
            // Check if the mouse position has changed and if we are not already drawing
            if (lastP != pos && !drawing)
            {
                drawing = true; // Start drawing
                lastP = pos;    // Set the last point to the current position
                lineQueue = new Queue<LineSeg>(); // Clear the queue for new line segments
                return;
            }
        }

        /// <summary>
        /// Event handler for mouse movement: Draw the line as the mouse moves.
        /// </summary>
        private void Canvas_MouseMove(Point pos, CDrawer dr)
        {
            // If we are drawing and the mouse position has changed
            if (drawing && pos != lastP)
            {
                // Create a new line segment
                LineSeg seg = new LineSeg
                {
                    _pStart = lastP,  // Start point is the previous position
                    _pEnd = pos,      // End point is the current position
                    _thickness = currentThickness,  // Set the current thickness
                    _alpha = currentAlpha,  // Set the current alpha (transparency)
                                            // Apply alpha to the color to adjust transparency
                    _color = Color.FromArgb((int)(currentAlpha * 255), currentColor.R, currentColor.G, currentColor.B)
                };

                // Add the new segment to the line queue
                lineQueue.Enqueue(seg);

                // Draw the line on the canvas
                canvas.AddLine(seg._pStart.X, seg._pStart.Y, seg._pEnd.X, seg._pEnd.Y, seg._color, seg._thickness);

                // Update the last point for the next movement
                lastP = pos;
            }
        }

        /// <summary>
        /// Event handler for right mouse click: Complete the current line and save it to the stack.
        /// </summary>
        private void Canvas_MouseRightClick(Point pos, CDrawer dr)
        {
            drawing = false; // Stop drawing

            // If there are any segments in the current line, push it to the stack
            if (lineQueue.Count > 0)
            {
                Queuestack.Push(lineQueue); // Save the completed line to the stack
                lineQueue = new Queue<LineSeg>(); // Clear the current queue for a new line
            }
        }

        /// <summary>
        /// Event handler for mouse wheel: Adjust the alpha (transparency) of the line.
        /// </summary>
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Increase alpha if scrolling up and the alpha is less than 1
            if (e.Delta > 0)
            {
                if (currentAlpha < 1.0f)
                {
                    currentAlpha += 0.05f;
                }
            }
            // Decrease alpha if scrolling down and the alpha is more than 0
            else
            {
                if (currentAlpha > 0.0f)
                {
                    currentAlpha -= 0.05f;
                }
            }
        }

        /// <summary>
        /// Method to render all the lines from the stack and the current line queue.
        /// </summary>
        private void RenderAllLines()
        {
            canvas.Clear(); // Clear the canvas before re-rendering

            // Render lines from the stack (completed lines)
            foreach (Queue<LineSeg> line in Queuestack)
            {
                foreach (LineSeg seg in line)
                {
                    // Convert alpha to 0-255 range for display and apply it when drawing
                    Color lineColor = Color.FromArgb((int)(seg._alpha * 255), seg._color.R, seg._color.G, seg._color.B);
                    canvas.AddLine(seg._pStart.X, seg._pStart.Y, seg._pEnd.X, seg._pEnd.Y, lineColor, seg._thickness);
                }
            }

            // Render segments from the current line queue
            foreach (LineSeg seg in lineQueue)
            {
                // Convert alpha to 0-255 range for display and apply it when drawing
                Color lineColor = Color.FromArgb((int)(seg._alpha * 255), seg._color.R, seg._color.G, seg._color.B);
                canvas.AddLine(seg._pStart.X, seg._pStart.Y, seg._pEnd.X, seg._pEnd.Y, lineColor, seg._thickness);
            }

            // Update the canvas with the new lines
            canvas.Render();
        }

        /// <summary>
        /// Method to update the UI labels showing the current number of lines, segments, thickness, and alpha.
        /// </summary>
        private void UpdateLabel()
        {
            int linecount = Queuestack.Count; // Get the number of completed lines
            int segcount = 0; // Total number of segments

            // Count the total number of segments in the stack
            foreach (Queue<LineSeg> queue in Queuestack)
            {
                segcount += queue.Count;
            }

            // Update the labels displaying the count of lines and segments
            UI_SegInfoDisplay_Lbl.Text = $"{linecount} lines, {segcount} total segments";
            UI_Thickness_Lbl.Text = $"Thickness : {UI_ThicknessTrackbar.Value}";
            UI_Alpha_Lbl.Text = $"Alpha : {(int)(currentAlpha * 255)}"; // Display alpha in the range 0-255
        }

        /// <summary>
        /// Event handler for thickness trackbar change: Adjust the thickness of the line.
        /// </summary>
        private void UI_ThicknessTrackbar_Scroll(object sender, EventArgs e)
        {
            currentThickness = (byte)UI_ThicknessTrackbar.Value; // Update the thickness based on the trackbar value
        }

        /// <summary>
        /// Event handler for undo button (undo the last drawn line).
        /// </summary>
        private void UI_UndoLine_Btn_Click(object sender, EventArgs e)
        {
            // If there are any completed lines in the stack, pop the top one
            if (Queuestack.Count > 0)
            {
                Queuestack.Pop();
                UpdateLabel(); // Update the UI labels
                RenderAllLines(); // Re-render the canvas
            }
            else
            {
                UI_SegInfoDisplay_Lbl.Text = "No Lines left to undo"; // Display message if no lines to undo
            }
        }

        /// <summary>
        /// Event handler for undo segment button (undo the last drawn segment of the current line).
        /// </summary>
        private void UI_UndoSegment_Btn_Click(object sender, EventArgs e)
        {
            // If there are completed lines in the stack
            if (Queuestack.Count > 0)
            {
                // Pop the top queue and check if it has more than one segment
                Queue<LineSeg> topQueue = Queuestack.Pop();

                if (topQueue.Count > 1)
                {
                    // Create a new queue to hold all but the last segment
                    Queue<LineSeg> newQueue = new Queue<LineSeg>();

                    while (topQueue.Count > 1)
                    {
                        newQueue.Enqueue(topQueue.Dequeue()); // Remove the last segment
                    }

                    // Push the modified queue back to the stack
                    Queuestack.Push(newQueue);
                }

                UpdateLabel(); // Update the UI labels
                RenderAllLines(); // Re-render the canvas
            }
        }

        /// <summary>
        /// Event handler for the reduce complexity button: Merge adjacent line segments if possible.
        /// </summary>
        private void ReduceComplexityButton_Click(object sender, EventArgs e)
        {
            // If there are completed lines in the stack
            if (Queuestack.Count > 0)
            {
                Queue<LineSeg> topQueue = Queuestack.Peek();
                Queue<LineSeg> newQueue = new Queue<LineSeg>();
                LineSeg? lastSegment = null;

                // Iterate over each segment and try to merge adjacent ones
                while (topQueue.Count > 0)
                {
                    LineSeg currentSegment = topQueue.Dequeue();

                    if (lastSegment.HasValue)
                    {
                        // Check if the two segments can be merged
                        if (CanMerge(lastSegment.Value, currentSegment))
                        {
                            LineSeg mergedSegment = MergeSegments(lastSegment.Value, currentSegment);
                            newQueue.Enqueue(mergedSegment);
                            lastSegment = null; // Reset to indicate merge
                        }
                        else
                        {
                            newQueue.Enqueue(lastSegment.Value);
                            lastSegment = currentSegment;
                        }
                    }
                    else
                    {
                        lastSegment = currentSegment;
                    }
                }

                // If there is a remaining segment, add it to the new queue
                if (lastSegment.HasValue)
                {
                    newQueue.Enqueue(lastSegment.Value);
                }

                // Replace the top queue with the new merged queue
                Queuestack.Pop();
                Queuestack.Push(newQueue);
                UpdateLabel(); // Update the UI labels
                RenderAllLines(); // Re-render the canvas
            }
        }

        /// <summary>
        /// Check if two line segments are adjacent and can be merged.
        /// </summary>
        private bool CanMerge(LineSeg seg1, LineSeg seg2)
        {
            return seg1._pEnd == seg2._pStart; // Segments are adjacent if the end of the first matches the start of the second
        }

        /// <summary>
        /// Merge two adjacent line segments into one.
        /// </summary>
        private LineSeg MergeSegments(LineSeg seg1, LineSeg seg2)
        {
            return new LineSeg
            {
                _pStart = seg1._pStart,
                _pEnd = seg2._pEnd,
                _thickness = (byte)((seg1._thickness + seg2._thickness) / 2), // Average the thickness
                _alpha = (seg1._alpha + seg2._alpha) / 2, // Average the alpha (transparency)
                //_color = Color.FromArgb((seg1._color.A + seg2._color.A) / 2, Color.Red) // Merge color (simplified here for example)
                _color = currentColor
            };
        }

        /// <summary>
        /// Event handler for color button: Allow the user to select a new color for drawing.
        /// </summary>
        private void UI_Colour_Btn_Click(object sender, EventArgs e)
        {
            // Open the color dialog to let the user choose a color
            if (UI_ColorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = UI_ColorDialog.Color; // Set the selected color
            }
        }

        /// <summary>
        /// Timer tick event handler to refresh the UI regularly.
        /// </summary>
        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            UI_Timer.Start(); // Restart the timer
            UpdateLabel(); // Update the labels
        }
    }


}
