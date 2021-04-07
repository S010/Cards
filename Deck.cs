using System;
using System.Collections.Generic;
using System.Linq;
namespace cards
{
    public class Deck
    {
        private Random random = new Random(); //The random functionality is used later in Shuffle
        public List<string> Suits = new List<string>{"Diamond","Heart","Spade","Club"}; //List of Suits for the cards
        public List<string> Values = new List<string>{"2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace"}; //List of values for the cards
        public Stack<Card> deck {get; set;} // Property to handle the deck
        public void newDeck()
        {
            deck = new Stack<Card>(); //Sets deck to a new stack 
            foreach (string suit in Suits) // Iteratess through each suit value then value values
            {
                foreach (string val in Values)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Value = val;
                    deck.Push(card); //Pushes new card to the top of the stack
                }
            }
            Console.WriteLine("\n!!New deck created!!\n");
        }
        public bool isEmpty()
        {
            if (deck.Count == 0) //Checks if the stack count is nill
            {
                Console.WriteLine("\nDeck is empty!");
                return true;
            }
            return false;
        }
    }
}