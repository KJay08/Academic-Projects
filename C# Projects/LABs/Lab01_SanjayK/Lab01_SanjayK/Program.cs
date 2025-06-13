/* Program     : Lab01
 * Description : Dinero Facil
 * Date        : 1 Feb. 2025
 * Author      : Sanjay Kumar
 * Course      : CMPE1666 - Intermediate Programing
 * Class       : CNTA01
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Lab01_SanjayK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a drawer window
            CDrawer canvas = new CDrawer();

            //Asking user to run program again
            string ask;

            do
            {
                Console.Clear();
                canvas.Clear();

                //Assigning arrays
                string[] currNames = { "Fifty", "Twenty", "Ten", "Five", "Toonie", "Loonie", "Quarter", "Dime", "Nickel" };
                double[] dollarArray = { 50, 20, 10, 5, 2, 1, 0.25, 0.10, 0.05 };
                Color[] colors = { Color.LightPink, Color.LightGreen, Color.AliceBlue, Color.LightSkyBlue, Color.LightYellow, Color.Gold, Color.Silver, Color.Silver, Color.Silver };

                //Calling UserInput() to make an input
                double input = UserInput();

                //Calling RoundValue() to make input to nearest nickel
                double converted = RoundValue(input); // Round to the nearest nickel

                Console.WriteLine($"User entry of {input} interpreted and rounded to {converted:F2}");

                //Calling Message() to print rounded value on drawer window
                Message(canvas, $"${converted:F2}");

                double remainingBalance = converted; // Use a separate variable to keep track of the remaining balance
                                                     //Calling Denomination() to calculate denomination
                int[] currencyCount = Denomination(remainingBalance, dollarArray);

                //Calling DisplayConsole() to display denomination console window
                DisplayConsole(currNames, currencyCount);

                //Calling DrawCurrency() to display denomination on drawer window
                DrawCurrency(canvas, currencyCount, dollarArray, colors);

                //Taking user input
                Console.Write("Do you want to run again program : ");
                ask = Console.ReadLine();
            } while (ask == "y");

            Console.ReadKey();
        }

        /// <summary>
        /// Method  : UserInput()
        /// Purpose : To make a valid and positive input by user
        /// </summary>
        /// <returns>input by user</returns>
        public static double UserInput()
        {
            bool success;
            double input;
            do
            {
                Console.Write("How much do you wish to convert? : ");
                string userInput = Console.ReadLine();

                userInput = userInput.Replace("$", "").Trim();

                success = double.TryParse(userInput, out input);

                if (!success || input < 0)
                {
                    Console.WriteLine("You gave a wrong input, input again");
                    Console.WriteLine();
                }
            } while (!success || input < 0);

            input = Math.Truncate(input * 100) / 100;
            return input;
        }

        /// <summary>
        /// Method  : RoundValue(double input)
        /// Purpose : To round the value, which was input by user
        /// </summary>
        /// <param name="input">user input</param>
        /// <returns>Rounded value</returns>
        public static double RoundValue(double input)
        {
            return Math.Round(input * 20) / 20.0;
        }

        /// <summary>
        /// Method  : Denomination(double remainingBalance, double[] dollarArray)
        /// Purpose : To calculate denomination
        /// </summary>
        /// <param name="remainingBalance"> remaining balance is rounded value</param>
        /// <param name="dollarArray">array of dollar from 50s to nickel</param>
        /// <returns>currencyCount array, which is denomination of dollars</returns>
        public static int[] Denomination(double remainingBalance, double[] dollarArray)
        {
            int[] currencyCount = new int[dollarArray.Length];
            for (int i = 0; i < dollarArray.Length; i++)
            {
                currencyCount[i] = (int)(remainingBalance / dollarArray[i]);

                remainingBalance %= dollarArray[i];

                remainingBalance = Math.Round(remainingBalance * 20) / 20.0;
            }

            return currencyCount;
        }

        /// <summary>
        /// Method  : DisplayConsole(string[] currNames, int[] currencyCount)
        /// Purpose : To display on console window 
        /// </summary>
        /// <param name="currNames">Currency names array</param>
        /// <param name="currencyCount">currency denomination array</param>
        public static void DisplayConsole(string[] currNames, int[] currencyCount)
        {
            for (int i = 0; i < currNames.Length; i++)
            {
                Console.WriteLine($"{currNames[i]} x {currencyCount[i]}");
            }
        }

        /// <summary>
        /// Method  : Message(CDrawer canvas, string message)
        /// Purpose : To display rounded user input on drawer window
        /// </summary>
        /// <param name="canvas">Drawer window</param>
        /// <param name="message">rounded user input</param>
        public static void Message(CDrawer canvas, string message)
        {
            canvas.AddText(message, 20, 350, 30, 200, 50, Color.Yellow);
        }

        /// <summary>
        /// Method  : DollarNote(CDrawer canvas, string text, int xStart, int yStart, Color color)
        /// Purpose : To display denomination on drawer window NOTES
        /// </summary>
        /// <param name="canvas">Drawer window</param>
        /// <param name="text">currency X currency count</param>
        /// <param name="xStart">x position</param>
        /// <param name="yStart">y position</param>
        /// <param name="color">Color of currency</param>
        public static void DollarNote(CDrawer canvas, string text, int xStart, int yStart, Color color)
        {
            int width = 150;
            int height = 70;
            int textSize = 15;
            int borderThickness = 3;
            canvas.AddRectangle(xStart, yStart, width, height, color, borderThickness, Color.Gray);
            canvas.AddText(text, textSize, xStart, (yStart + 10), width, (height - 20));
        }

        /// <summary>
        /// Method  : DollarCoin(CDrawer canvas, string text, int xStart, int yStart, Color color)
        /// Purpose : To display denomination on drawer window COINS
        /// </summary>
        /// <param name="canvas">Drawer window</param>
        /// <param name="text">currency X currency count</param>
        /// <param name="xStart">x position</param>
        /// <param name="yStart">y position</param>
        /// <param name="color">Color of currency</param>
        public static void DollarCoin(CDrawer canvas, string text, int xStart, int yStart, Color color)
        {
            int width = 100;
            int height = 100;
            int textSize = 15;
            int borderThickness = 3;
            canvas.AddEllipse(xStart, yStart, width, height, color, borderThickness, Color.Gray);
            canvas.AddText(text, textSize, (xStart - 25), (yStart + 25), (width + 50), (height - 50));
        }

        /// <summary>
        /// Method  : DrawCurrency(CDrawer canvas, int[] currencyCount, double[] dollarArray, Color[] colors)
        /// Purpose : To give positions to notes and coins
        /// </summary>
        /// <param name="canvas">Drawer window</param>
        /// <param name="currencyCount">currency denomination array</param>
        /// <param name="dollarArray">array of dollar from 50s to nickel</param>
        /// <param name="color">Color of currency</param>
        public static void DrawCurrency(CDrawer canvas, int[] currencyCount, double[] dollarArray, Color[] colors)
        {
            int xStart = 50;
            int yStart = 130;
            bool resetPosition = false;

            for (int i = 0; i < currencyCount.Length; i++)
            {
                if (currencyCount[i] > 0)
                {
                    if (i < 4)
                    {
                        string text = $"${dollarArray[i]} X {currencyCount[i]}";
                        DollarNote(canvas, text, xStart, yStart, colors[i]);
                        yStart += 80;
                    }
                    else
                    {
                        string text = $"${dollarArray[i]:F2} X {currencyCount[i]}";
                        if (xStart == 50)
                        {
                            xStart = 75;
                        }
                        if (yStart > (canvas.m_ciHeight - 100) && !resetPosition)
                        {
                            xStart = 600;
                            yStart = 130;
                            resetPosition = true;
                        }

                        DollarCoin(canvas, text, xStart, yStart, colors[i]);
                        yStart += 110;
                    }
                }
            }
        }
    }
}
