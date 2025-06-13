using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA08_SanjayK
{
    public partial class Form1 : Form
    {
        // Define the structure to represent a Card
        private struct Card
        {
            public Suits _suit;        // Suit of the card (Heart, Diamond, Club, Spade)
            public int _rank;          // Rank of the card (2-14 for 2 to Ace)
            public int _points;        // Points associated with the card
            public string _symbol;     // Symbol for the card (e.g., 2, J, Q, K, A)
        }

        // Define an enum for card suits
        private enum Suits { Heart, Diamond, Club, Spade };

        // Declare arrays to hold the card deck and player hands
        private Card[] cardDeck = new Card[52];         // Array to store the full deck of 52 cards
        private Card[,] playerHands = new Card[10, 5];   // Array to store the hands of 10 players (5 cards each)
        private int[] playerPoints = new int[10];        // Array to store points for each of the 10 players

        Card card = new Card();  // Temporary card for use in card creation

        public Form1()
        {
            InitializeComponent();

            int index = 0;

            // Loop through each suit and rank to create the deck of cards
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                for (int rank = 2; rank <= 14; rank++)
                {
                    // Create a card using the createCard method
                    card = createCard(suit, rank);

                    // Store the created card in the deck
                    cardDeck[index] = card;
                    index++;
                }
            }
        }

        // Method to create a card with a specific suit and rank
        private Card createCard(Suits suit, int rank)
        {
            Card card = new Card();  // Create a new card object
            card._suit = suit;       // Set the suit of the card
            card._rank = rank;       // Set the rank of the card

            // Assign points based on the suit and rank
            int suitWeight = 0;

            // Assign a weight based on the suit (for points calculation)
            if (suit == Suits.Heart) suitWeight = 4;
            else if (suit == Suits.Diamond) suitWeight = 3;
            else if (suit == Suits.Club) suitWeight = 2;
            else if (suit == Suits.Spade) suitWeight = 1;

            // Calculate points for the card (suitWeight * rank)
            card._points = suitWeight * rank;

            // Assign symbol (e.g., "2" for rank 2, "J" for Jack, "Q" for Queen, etc.)
            card._symbol = (rank >= 2 && rank <= 10) ? rank.ToString() :
                           (rank == 11) ? "J" :
                           (rank == 12) ? "Q" :
                           (rank == 13) ? "K" : "A";
            return card;
        }

        // Method to convert a card to a formatted string for display
        private string CardToString(Card card)
        {
            // Format the card as "Card:<Suit> <Symbol> Points:<Points>"
            string formattedCard = $"Card:{card._suit} {card._symbol}";
            string formattedPoint = $"Points:{card._points}";
            return $"{formattedCard} \t {formattedPoint}";
        }

        // Fisher-Yates Shuffling Algorithm to shuffle the deck
        private void Shuffling(Card[] deck)
        {
            Random rand = new Random();  // Create a random number generator
            int n = deck.Length;         // Get the number of cards in the deck

            // Loop through the deck in reverse order and swap cards randomly
            for (int i = n - 1; i > 0; i--)
            {
                int randPosn = rand.Next(i); // Generate a random position in the range of 0..i-1

                Swap(deck, i, randPosn);    // Swap the current card with the random card
            }
        }

        // Method to swap two cards in the deck
        private void Swap(Card[] cards, int posn1, int posn2)
        {
            Card temp = cards[posn1];         // Store the first card in a temporary variable
            cards[posn1] = cards[posn2];      // Swap the cards
            cards[posn2] = temp;              // Set the second card to the first card's original position
        }

        // Method to deal hands to players from the shuffled deck
        private void DealHands(Card[] cardDeck, Card[,] playerHands, int[] playerPoints)
        {
            int cardIndex = 0;  // Start from the first card in the shuffled deck

            // Round-robin dealing of 5 cards to each of 10 players
            for (int i = 0; i < 5; i++)  // Deal 5 cards
            {
                for (int player = 0; player < 10; player++)  // Iterate through each player
                {
                    playerHands[player, i] = cardDeck[cardIndex];  // Assign the current card to the player
                    cardIndex++;  // Move to the next card in the deck
                }
            }

            // After dealing, calculate the total points for each player
            for (int player = 0; player < 10; player++)
            {
                int totalPoints = 0;  // Reset total points for the player

                // Sum the points of the player's hand
                for (int i = 0; i < 5; i++)
                {
                    totalPoints += playerHands[player, i]._points;
                }

                // Store the total points for this player
                playerPoints[player] = totalPoints;
            }

            // Display each player's hand and total points in the ListBox
            UI_PlayersHands_Lbx.Items.Clear();  // Clear any previous hands

            for (int i = 0; i < 10; i++)  // Loop through each player
            {
                UI_PlayersHands_Lbx.Items.Add($"Player {i + 1}:"); // Display player number
                UI_PlayersHands_Lbx.Items.Add($"-------------");   // Separator line

                // Loop through each card in the player's hand
                for (int j = 0; j < 5; j++)
                {
                    UI_PlayersHands_Lbx.Items.Add(CardToString(playerHands[i, j]));  // Display the card
                }

                // Display the total points for this player
                UI_PlayersHands_Lbx.Items.Add($"Total Points: {playerPoints[i]}\n");
                UI_PlayersHands_Lbx.Items.Add($"\n");  // Blank line for separation
            }
        }

        // Method to determine the winner based on the highest points
        private void DetermineWinner(int[] playerPoints)
        {
            int maxPoints = playerPoints.Max();  // Find the highest points
            int winnerIndex = Array.IndexOf(playerPoints, maxPoints);  // Find the player with the highest points

            // Display the winner's index (Player number) and their points
            UI_Winner_Tbx.Text = $"Player {winnerIndex + 1} - Points: {maxPoints}";
        }

        // Event handler for loading the starting deck into the ListBox
        private void UI_LoadCards_Btn_Click(object sender, EventArgs e)
        {
            // Clear the ListBox before displaying the cards
            UI_StartingDeck_Lbx.Items.Clear();

            // Loop through all the cards in the deck and display them
            foreach (Card card in cardDeck)
            {
                UI_StartingDeck_Lbx.Items.Add(CardToString(card));  // Add each card as a string to the ListBox
            }
        }

        // Event handler for shuffling the deck and displaying the shuffled cards
        private void UI_ShuffleCards_Btn_Click(object sender, EventArgs e)
        {
            if (UI_StartingDeck_Lbx.Items.Count > 0)
            {
                // Shuffle the deck
                Shuffling(cardDeck);

                // Clear the ListBox before displaying the shuffled cards
                UI_ShuffledDeck_Lbx.Items.Clear();

                // Loop through all the shuffled cards and display them
                foreach (Card card in cardDeck)
                {
                    UI_ShuffledDeck_Lbx.Items.Add(CardToString(card));  // Add each shuffled card to the ListBox
                }
            }
        }

        // Event handler for dealing hands to the players and displaying their hands
        private void UI_DealHands_Btn_Click(object sender, EventArgs e)
        {
            if (UI_ShuffledDeck_Lbx.Items.Count > 0)
            {
                DealHands(cardDeck, playerHands, playerPoints);
            }
        }

        // Event handler for determining and displaying the winner based on points
        private void UI_DetermineWinner_Btn_Click(object sender, EventArgs e)
        {
            // Call the method to determine and display the winner
            if (UI_PlayersHands_Lbx.Items.Count > 0)
            {
                DetermineWinner(playerPoints);
            }
        }

        // Helper method to adjust the visibility of the scrollbar based on ListBox size and item count
        private void AdjustScrollbarVisibility(ListBox listBox)
        {
            // Get the height of the ListBox and the number of items in it
            int listBoxHeight = listBox.ClientSize.Height;
            int itemHeight = listBox.ItemHeight;
            int totalItemHeight = itemHeight * listBox.Items.Count;

            // If all items fit, remove the scrollbar (set ScrollAlwaysVisible to false)
            if (totalItemHeight <= listBoxHeight)
            {
                listBox.ScrollAlwaysVisible = false;
            }
            else
            {
                listBox.ScrollAlwaysVisible = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Check if the ListBox is large enough to fit all items
            AdjustScrollbarVisibility(UI_StartingDeck_Lbx);
            AdjustScrollbarVisibility(UI_ShuffledDeck_Lbx);
        }
    }
}
