/* Program     : ICA18
 * Description : Slow Drawer
 * Date        : 14 April, 2025
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
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA18_SanjayK
{
    public partial class Form1 : Form
    {
        //Creating canvas
        CDrawer canvas = new CDrawer(800, 600, true);

        //Declaring Queue collection of type Point
        Queue<Point> queuePoint = new Queue<Point>();

        //Initializing the stopwatch
        Stopwatch sw = new Stopwatch();

        //Declaring delegates
        Action<Point> delEnqueue;
        Action updateStatusAction;

        //Declaring point
        Point lastPoint;

        // Declare a Random object once
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            //For heading
            this.Text = "slow Draw";

            //Initial display on label
            UI_Display_Lbl.Text = "0 Segs in Queue, estimate time to draw : 0 seconds";

            //Subscribing canvas events
            canvas.MouseMove += Canvas_MouseMove;
            canvas.MouseRightClick += Canvas_MouseRightClick;

            //Assigning delegates to methods
            delEnqueue = EnqueuePoint;

            //renderAction = ProcessQueue;
            updateStatusAction = UpdateStatus;

            //Creating thread and assigning, setting to start
            Thread renderThread = new Thread(RenderLoop);
            renderThread.IsBackground = true;
            renderThread.Start();
        }

        /// <summary>
        /// The event takes user right-mouse click and triggers burst
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="dr"></param>
        private void Canvas_MouseRightClick(Point pos, CDrawer dr)
        {
            try
            {
                Point center = pos;

                // Generate 250 points around the center for the burst
                for (int i = 0; i < 250; i++)
                {
                    // Generate a random angle and calculate a new point in a circular pattern
                    double angle = rand.NextDouble() * 2 * Math.PI;
                    int x = center.X + (int)(50 * Math.Cos(angle));
                    int y = center.Y + (int)(50 * Math.Sin(angle));

                    // Enqueue the points
                    Invoke(delEnqueue, center);
                    Invoke(delEnqueue, new Point(x, y));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Canvas_MouseRightClick Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// The event takes input of user's mouse movement and enqueues the point
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="dr"></param>
        private void Canvas_MouseMove(Point pos, CDrawer dr)
        {
            try
            {
                // Invoking the delegate to enqueue the point
                Invoke(delEnqueue, pos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// The method inserts value to the queue
        /// </summary>
        /// <param name="pos"></param>
        private void EnqueuePoint(Point pos)
        {
            queuePoint.Enqueue(pos);
        }

        /// <summary>
        /// This method renders the canvas
        /// </summary>
        private void RenderLoop()
        {
            sw.Start();
            bool firstPoint = true;

            while (true)
            {
               

                if (queuePoint.Count > 0)
                {
                    try
                    {
                        // Dequeue the point directly inside the RenderLoop thread
                        Point current = queuePoint.Dequeue();

                        if (!firstPoint)
                        {
                            // Draw a line from the last point to the current point
                            canvas.AddLine(lastPoint.X, lastPoint.Y, current.X, current.Y, Color.Red, 2);
                        }

                        lastPoint = current;
                        firstPoint = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                while (sw.ElapsedMilliseconds < 50)
                {
                    Thread.Sleep(1); // Sleep to prevent overloading CPU
                }

                try
                {
                    Invoke(updateStatusAction); // Update the status in the UI thread
                }
                catch (Exception ex)
                {
                    Console.WriteLine("RenderLoop Exception: " + ex.Message);
                }

                sw.Restart(); // Reset stopwatch
            }
        }

        /// <summary>
        /// Updating the label
        /// </summary>
        private void UpdateStatus()
        {
            int segs = queuePoint.Count;
            double time = (segs * 50) / 1000.0;

            UI_Display_Lbl.Text = $"{segs} Segs in Queue, estimate time to draw : {time:F2} seconds";
        }


    }
}
