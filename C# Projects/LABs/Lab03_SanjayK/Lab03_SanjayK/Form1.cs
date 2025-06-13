/* Program     : Lab03
 * Description : BallZ
 * Date        : 10 April, 2025
 * Author      : Sanjay Kumar
 * Course      : CMPE1666 - Intermediate Programing
 * Class       : CNTA01
 */
using GDIDrawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab03_SanjayK
{
    public partial class Form1 : Form
    {
        // --- Game Constants ---
        private int BallSize = 50;              // Diameter of each ball in pixels
        private int ScreenWidth = 800;          // Width of the game canvas
        private int ScreenHeight = 600;         // Height of the game canvas

        // --- Drawing and Dialogs ---
        private CDrawer canvas;                // GDIDrawer canvas for rendering balls
        ModelessDialogAnimation speed = null;  // Modeless dialog for animation speed
        ModelessDialongScore score = null;     // Modeless dialog for live score display

        // --- Game Variables ---
        private string difficulty;              // Selected difficulty level (easy, medium, hard)
        private int rows;                       // Number of rows in the grid
        private int cols;                       // Number of columns in the grid
        private Ball[,] gameGrid;               // 2D array to represent ball states and colors
        private int updatedScore = 0;           // Current score of the player
        private int currentDelay = 10;          // Animation delay between steps (ms)
        private int numColorsToUse = 3;         // Number of colors based on difficulty (3 by default)
        private Color[] availableColors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Purple }; // Available colors
        private int stepDroppedCount = 0; // shared between StepDown and FallDown

        // --- Ball States ---
        public enum BallState { Alive, Dead }   // Enum to track the status of each ball

        // --- Ball Structure ---
        public struct Ball
        {
            public BallState state;             // Alive or Dead
            public Color color;                 // Color of the ball
        }

        // --- Constructor ---
        public Form1()
        {
            InitializeComponent();
            this.Text = "CMPE1666 - Lab 3 - Ballz";

            canvas = new CDrawer(ScreenWidth, ScreenHeight);
            canvas.ContinuousUpdate = false;

            rows = ScreenHeight / BallSize;
            cols = ScreenWidth / BallSize;
            gameGrid = new Ball[cols, rows];

            UI_Timer.Interval = 100;            // UI Timer tick rate (ms)
        }

        /// <summary>
        /// This event check for animation speed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_AnimationSpeed_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_AnimationSpeed_Cbx.Checked)
            {
                if (speed == null)
                {
                    speed = new ModelessDialogAnimation();
                    speed._dFormAnimationClosing = CallBackAnimationFormClosing; // Close handler
                    speed._delChangeSpeed = CallBackCurrentDelay;               // Speed change callback
                }
                speed.Show();
            }
            else
            {
                speed.Hide();
            }
        }

        /// <summary>
        /// This method to set value to checkbox
        /// </summary>
        private void CallBackAnimationFormClosing()
        {
            UI_AnimationSpeed_Cbx.Checked = false;
        }

        /// <summary>
        /// callback method to set value to animation speed
        /// </summary>
        /// <param name="value"></param>
        private void CallBackCurrentDelay(int value)
        {
            currentDelay = value;
        }

        /// <summary>
        /// This event checks for score dialog 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ShowScore_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowScore_Cbx.Checked)
            {
                if (score == null)
                {
                    score = new ModelessDialongScore();
                    score._dFormScoreClosing = CallBackScoreFormClosing; // Close handler
                }

                score.Show();
                score.updateScore(updatedScore); // Show current score
            }
            else
            {
                score.Hide();
            }
        }

        /// <summary>
        /// This callback method set value to show score check box
        /// </summary>
        private void CallBackScoreFormClosing()
        {
            UI_ShowScore_Cbx.Checked = false;
        }

        /// <summary>
        /// This event open difficulty dialog draw balls on canvas according to difficulty level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Play_Btn_Click(object sender, EventArgs e)
        {
            updatedScore = 0;

            ModelDialog difficultyDialog = new ModelDialog();

            // Show difficulty selection dialog
            if (difficultyDialog.ShowDialog() == DialogResult.OK)
            {
                difficulty = difficultyDialog.dificulty();

                if (difficulty == null)
                {
                    MessageBox.Show("Difficulty Level was not selected");
                    return;
                }

                UI_Play_Btn.Enabled = false; // Disable Play button during gameplay

                // Set number of colors based on difficulty
                if (difficulty == "easy") numColorsToUse = 3;
                else if (difficulty == "medium") numColorsToUse = 4;
                else if (difficulty == "hard") numColorsToUse = 5;

                Randomize(); // Populate grid with random balls

                Display();   // Render initial grid

                UI_Timer.Start(); // Begin game loop
            }
        }

        /// <summary>
        /// This method to randomize the colors
        /// </summary>
        private void Randomize()
        {
            Random rand = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    gameGrid[x, y].state = BallState.Alive;
                    gameGrid[x, y].color = availableColors[rand.Next(numColorsToUse)];
                }
            }
        }

        /// <summary>
        /// This method draws balls
        /// </summary>
        private void Display()
        {
            canvas.Clear();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (gameGrid[x, y].state == BallState.Alive)
                    {
                        canvas.AddEllipse(x * BallSize, y * BallSize, BallSize, BallSize, gameGrid[x, y].color);
                    }
                }
            }
            canvas.Render();
        }

        /// <summary>
        /// This method check that ball is alive or not and return value according to it
        /// </summary>
        /// <returns></returns>
        private int BallsAlive()
        {
            int count = 0;
            foreach (Ball ball in gameGrid)
            {
                if (ball.state == BallState.Alive)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// This recursive method check for balls and target them
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <param name="targetColor"></param>
        /// <returns></returns>
        private int CheckBalls(int col, int row, Color targetColor)
        {
            if (col < 0 || col >= cols || row < 0 || row >= rows)
                return 0;
            if (gameGrid[col, row].state == BallState.Dead || gameGrid[col, row].color != targetColor)
                return 0;

            gameGrid[col, row].state = BallState.Dead;
            int killed = 1;

            // Recursively check in 4 directions
            killed += CheckBalls(col + 1, row, targetColor);
            killed += CheckBalls(col - 1, row, targetColor);
            killed += CheckBalls(col, row + 1, targetColor);
            killed += CheckBalls(col, row - 1, targetColor);

            return killed;
        }

        /// <summary>
        /// this method drop balls 
        /// </summary>
        /// <returns></returns>
        private int StepDown()
        {
            int dropped = 0;

            for (int x = 0; x < cols; x++)
            {
                for (int y = rows - 1; y > 0; y--)
                {
                    if (gameGrid[x, y].state == BallState.Dead &&
                        gameGrid[x, y - 1].state == BallState.Alive)
                    {
                        gameGrid[x, y] = gameGrid[x, y - 1];
                        gameGrid[x, y - 1].state = BallState.Dead;
                        dropped++;
                    }
                }

                Display();
                Thread.Sleep(currentDelay); // Delay to animate falling
            }

            return dropped;
        }

        /// <summary>
        /// this method make them down
        /// </summary>
        /// <returns></returns>
        private int FallDown()
        {
            int totalDropped = 0;
            while (true)
            {
                int dropped = StepDown();
                if (dropped == 0) break;
                totalDropped += dropped;
            }
            return totalDropped;
        }

        /// <summary>
        /// this method clear the balls according to user click
        /// </summary>
        /// <returns></returns>
        private int Pick()
        {
            if (!canvas.GetLastMouseLeftClick(out Point click))
                return 0;

            int col = click.X / BallSize;
            int row = click.Y / BallSize;

            if (gameGrid[col, row].state == BallState.Dead)
            {
                System.Media.SystemSounds.Beep.Play(); // Invalid click
                return 0;
            }

            Color targetColor = gameGrid[col, row].color;
            int killed = CheckBalls(col, row, targetColor);

            if (killed > 0)
            {
                // Score formula: base + bonus for combos
                int score = 50 * killed + (killed > 1 ? (int)Math.Pow(2, killed - 2) * 10 : 0);
                FallDown(); // Let remaining balls fall
                return score;
            }

            return 0;
        }

        /// <summary>
        /// This method for thread to work
        /// </summary>
        private void forThread()
        {
            updatedScore += Pick();
        }

        /// <summary>
        /// this event check for timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            if (BallsAlive() == 0)
            {
                // Game ends when no balls are alive
                UI_Timer.Stop();
                canvas.AddText("Game Over", 50, Color.White);
                canvas.Render();
                UI_Play_Btn.Enabled = true;
                CheckAndSaveHighScore(); // Evaluate high score
            }
            else
            {
                //int totalscore = Pick(); // Check for player action

                Thread thread = new Thread(forThread);
                thread.IsBackground = true;
                thread.Start();

                if (updatedScore > 0)
                {
                    // Update live score dialog if it's open
                    if (score != null)
                    {
                        score.updateScore(updatedScore);
                    }
                }
            }
        }

       /// <summary>
       /// this method is writing the file
       /// </summary>
        private void CheckAndSaveHighScore()
        {
            string filePath = "../../../highscores.txt";
            string bestName = "";
            int bestScore = 0;
            string bestMode = "";

            // If file doesn't exist, create it with a header
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Player-Name : Score : Difficulty\n");
            }

            // Read existing scores
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                // Start from line 1 to skip the header
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    if (parts.Length == 3)
                    {
                        string name = parts[0].Trim();
                        string scoreStr = parts[1].Trim();
                        string mode = parts[2].Trim();

                        // Match the score with current difficulty
                        if (mode == difficulty && int.TryParse(scoreStr, out int score))
                        {
                            if (score > bestScore)
                            {
                                bestScore = score;
                                bestName = name;
                                bestMode = mode;
                            }
                        }
                    }
                }

                // If player beat the previous best
                if (bestScore == 0 || updatedScore > bestScore)
                {
                    ModalDialogHighScore nameDialog = new ModalDialogHighScore();

                    if (nameDialog.ShowDialog() == DialogResult.OK)
                    {
                        string playerName = nameDialog.PlayerName();

                        // Append new high score to the file
                        File.AppendAllText(filePath, $"{playerName} : {updatedScore} : {difficulty}\n");

                        MessageBox.Show("🎉 New High Score Saved!", "High Score");
                    }
                }
                else
                {
                    MessageBox.Show("No new high score. Try again!", "Info");
                }
            }
        }


    }
}
