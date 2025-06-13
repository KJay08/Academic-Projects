/* Program     : ICA19
 * Description : Stacky Posts
 * Date        : 16 April, 2025
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
using System.Diagnostics;

namespace ICA19_SanjayK
{
    public partial class Form1 : Form
    {
        // Declare a Stack to store the messages and other necessary variables
        Stack<string> msgStk = new Stack<string>(); // Stack to store the messages in reverse order
        int idCounter = 1; // Counter to keep track of message IDs
        Stopwatch sw = new Stopwatch(); // Stopwatch to measure elapsed time since the application started

        public Form1()
        {
            InitializeComponent(); // Initializes the form components (UI elements)

            this.Text = "ICA 19 - Creating Posts"; // Set the title of the form
            this.AcceptButton = UI_AddPost_Btn; // Set the default "AcceptButton" to the Add Post button

            sw.Start(); // Start the stopwatch to track the elapsed time
        }

        // Event handler for when the "Add Post" button is clicked
        private void UI_AddPost_Btn_Click(object sender, EventArgs e)
        {
            if (UI_NewPost_Tbx.Text.Length > 0) // Ensure the textbox is not empty before adding the post
            {
                // Create a message with a unique ID, the content of the post, and the time elapsed since the app started
                string message = $"ID:{idCounter++} - Message : {UI_NewPost_Tbx.Text} - Posted at : {sw.ElapsedMilliseconds / 1000} seconds";

                msgStk.Push(message); // Push the newly created message to the stack

                UI_NewPost_Tbx.Clear(); // Clear the input textbox after the post is added

                DisplayMessage(); // Update the ListBox to show the new list of messages
            }
        }

        // Event handler for when the "Delete Last Post" button is clicked
        private void UI_DeleteLastPost_Btn_Click(object sender, EventArgs e)
        {
            if (msgStk.Count > 0) // Check if there are any posts to delete
            {
                msgStk.Pop(); // Remove the last post from the stack

                DisplayMessage(); // Update the ListBox to reflect the change
            }
        }

        // Event handler for when the "Delete Post by ID" button is clicked
        private void UI_DeleteById_Btn_Click(object sender, EventArgs e)
        {
            if (UI_IdInput_Tbx.Text.Length > 0) // Ensure the user has entered an ID in the textbox
            {
                int idToDel;
                if (int.TryParse(UI_IdInput_Tbx.Text, out idToDel)) // Try parsing the ID from the textbox input
                {
                    Stack<string> tempStk = new Stack<string>(); // Temporary stack to hold messages while searching for the ID
                    bool found = false; // Flag to check if the post with the given ID is found

                    // Loop through the stack to find the message with the given ID
                    while (msgStk.Count > 0)
                    {
                        string message = msgStk.Pop(); // Pop the top message from the stack

                        // Check if the message ID matches the one provided by the user
                        if (message.StartsWith($"ID:{idToDel}"))
                        {
                            found = true; // Set the flag to true if the post is found
                            break; // Exit the loop once the post is found
                        }
                        else
                        {
                            tempStk.Push(message); // Push the message to the temporary stack if it doesn't match
                        }
                    }

                    // Push all the messages back from the temporary stack to the original stack
                    while (tempStk.Count > 0)
                    {
                        msgStk.Push(tempStk.Pop());
                    }

                    DisplayMessage(); // Update the ListBox to reflect the change

                    // If the post with the given ID wasn't found, display an error message
                    if (!found)
                    {
                        MessageBox.Show("Post ID not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number"); // If the entered ID is not a valid number
                }

                UI_IdInput_Tbx.Clear(); // Clear the ID input textbox after processing
            }
        }

        // Method to update the ListBox with the current posts from the stack
        private void DisplayMessage()
        {
            UI_PostedMessage_Lbx.Items.Clear(); // Clear the ListBox before updating it

            // Loop through each message in the stack and add it to the ListBox
            foreach (string msg in msgStk)
            {
                UI_PostedMessage_Lbx.Items.Add(msg); // Add each message to the ListBox
            }
        }

        // Event handler for when the user types something in the ID input textbox
        private void UI_IdInput_Tbx_TextChanged(object sender, EventArgs e)
        {
            // If there's text in the ID input textbox, change the AcceptButton to "Delete by ID" button
            if (UI_IdInput_Tbx.Text.Length > 0)
            {
                this.AcceptButton = UI_DeleteById_Btn;
            }
            else
            {
                // If the ID input textbox is empty, reset the AcceptButton back to the "Add Post" button
                this.AcceptButton = UI_AddPost_Btn;
            }
        }
    }
}
