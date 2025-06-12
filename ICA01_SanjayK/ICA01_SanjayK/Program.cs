/* Program     : ICA01
 * Description : Linear search in arrays
 * Date        : 9 Jan. 2025
 * Author      : Sanjay Kumar
 * Course      : CMPE1666 - Intermediate Programing
 * Class       : CNTA01
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ICA01_SanjayK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title
            string title = "CMPE1666 - ICA01 winter 2025 - Sanjay Kumar";
            Console.CursorLeft = (Console.WindowWidth  - title.Length) / 2;
            Console.WriteLine(title);

            Console.WriteLine();

            //Calling GetValue method to get arraysize from user
            int size = GetValue("Input the size of the array to generate (10 - 100) : ", 10, 100);

            //Calling GetRange method to get minimum or maximum value of array element from user
            GetRange(out int minimum, out int maximum);

            //Calling GenerateArray to create an array with provided size, minimum and maximum values by user, and assign to variable
            int[] array = GenerateArray(size, minimum, maximum);

            //Calling DisplayArray to display the array to user
            DisplayArray(array);

            //User preference
            string ask;

            //Using do-while to run program again according to user
            do
            {
                //Calling GetValue method to get integer to be searched in array by user
                int search = GetValue("Enter a valid value to be searched : ", minimum, maximum);

                //Calling CountOccurrences to get the occurrence of searched integer in array
                int count = CountOccurrences(array, search);

                //If multiple occurence then display number of occurrences
                if(count > 0)
                {
                    Console.WriteLine($"Number of occurrence of {search} is {count}");
                }
                //If searching value is not in array
                else
                {
                    Console.WriteLine($"{search} not found in array");
                }

                //Using do-while to make sure user input is correct
                do
                {
                    //Display prompt
                    Console.Write("Do you want to search for another value (Y/N, y/n) : ");
                    //Ask user to run again
                    ask = Console.ReadLine().ToLower();

                    //If value is not Y/y or N/n then display the correct response
                    if (ask != "y" && ask != "n")
                    {
                        Console.WriteLine("You should respond by : Y,y,N, or n. Please input again");
                        Console.WriteLine();
                    }
                    
                } while(ask != "y" && ask != "n");
                
            } while (ask == "y");

            Console.ReadKey();
        }

        /// <summary>
        /// Method  : public static int GetValue(string prompt, int minimum, int maximum)
        /// Purpose : To make validated input for user
        /// </summary>
        /// <param name="prompt">Prompt to be provided by the caller for user input</param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <returns> size : validated value input by user </returns>
        public static int GetValue(string prompt, int minimum, int maximum)
        {
            //Array size
            int size;

            //Variable for validation
            bool success;

            //Using do-while to get validated and in range input by user
            do 
            {
                //Displaying Prompt and input value
                Console.Write(prompt);
                success = int.TryParse(Console.ReadLine(), out size);

                //Checking for validation
                if (!success)
                {
                    Console.WriteLine("The input value is not valid. You have to input another value");
                    Console.WriteLine();
                }

                //Checking input is not less than minimum value
                else if(size < minimum)
                {
                    Console.WriteLine($"The input value is out of range. You have to input value in the range {minimum} - {maximum}");
                    Console.WriteLine();
                }

                //Checking input is not higher than maximum value
                else if(size > maximum)
                {
                    Console.WriteLine($"The input value is out of range. You have to input value in the range {minimum} - {maximum}");
                    Console.WriteLine();
                }

            } while ((!success) || (size < minimum) || (size > maximum));

            return size;
        }

        /// <summary>
        /// Method  : public static void GetRange(out int minimum, out int maximum)
        /// Purpose : To make input for range values
        /// </summary>
        /// <param name="minimum">minimum value input by user</param>
        /// <param name="maximum">maximum value input by user</param>
        public static void GetRange(out int minimum, out int maximum)
        {
            //Calling GetValue to make input for minimum value
            minimum = GetValue("Enter the lower limit of the range of values to generate (0 - 100) : ", 0, 100);

            //Calling GetValue to make input for maximum value
            maximum = GetValue("Enter the lower limit of the range of values to generate (0 - 100) : ", minimum, 100);
        }

        /// <summary>
        /// Method  : public static int[] GenerateArray(int size, int lower, int upper)
        /// Purpose : To generate an array
        /// </summary>
        /// <param name="size">size of the array</param>
        /// <param name="lower">lowest value of array element</param>
        /// <param name="upper">highest value of array element</param>
        /// <returns>array : generate an array with provided size, lower, and upper values by user</returns>
        public static int[] GenerateArray(int size, int lower, int upper)
        {
            //Create an array
            int[] array = new int[size];

            //Random number generator
            Random rand = new Random();

            //Using for loop to assign random values to array
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(lower, upper);
            }

            return array;
        }

        /// <summary>
        /// Method  : public static void DisplayArray(int[] array)
        /// Purpose : To display array to user
        /// </summary>
        /// <param name="array"> array to iterate through</param>
        public static void DisplayArray(int[] array)
        {
            Console.Write("The generate values are : ");

            //Using for loop to iterate through array and display it to user
            for (int i = 0;i < array.Length;i++) 
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method  : public static int CountOccurrences(int[] array, int search) 
        /// Purpose : To search a value in array and find its occurrence
        /// </summary>
        /// <param name="array">array to iterate through</param>
        /// <param name="search">integer value to be searched in array</param>
        /// <returns>count : the number of occurrence of searched value</returns>
        public static int CountOccurrences(int[] array, int search) 
        {
            //Count for occurrence
            int count = 0;

            //Using foreach loop to count the occurence of searched value
            foreach (int val in array)
            {
                if (val == search)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
