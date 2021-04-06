using System;
using System.Collections.Generic;
using System.Linq;
namespace cards
{
    public class Deck
    {
        /*
        This class handles all things to do with the deck of cards
        Methods included in this :
        newDeck() - This creates a new deck in for of a stack and adds the cards to the stack
        isEmpty() - Checks if the stack is empty and returns a boolean
        shuffle() - Shuffles the "deck" (Rearanges the stack in a random fashion)
        deal() - Pops the top of the stack
        dealerMenu() - this handles user inputs to interact with the deck

        One question may be why I have chosen to use a stack as the datatype for the deck
        Well in real life a deck of cards acts just like a stack , popping the fist one on top and removing it from the deck
        */
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
        public void shuffle()
        {
            List<Card> list = deck.ToList();  //Converts stack to list for ease of use
            int n = list.Count;
            while(n>1)
            {
                n--;
                int randomItem  = random.Next(n+1);
                Card value = list[randomItem]; 
                list[randomItem] = list[n];
                list[n]= value;
            }
            deck = new Stack<Card>(list);
            Console.WriteLine("\nDeck Shuffled");
        }
        public void deal()
        {
            //Removes top value of stack and returns the value in a formatted string
            Console.WriteLine($"{deck.Peek().Value} of {deck.Peek().Suit}'s");
            deck.Pop(); 
        }
        public void dealerMenu()
        {
            while(isEmpty() != true) //Checks if the stack has values inside
            {
                Console.WriteLine("ENTER to deal a new card | S to Shuffle | Q to Quit");
                //This switch statement handles all user inputs , it also turns the input into lowercase for ease of use and to avoid any errors
                switch (Console.ReadLine().ToLower())
                { 
                    case "":
                        deal();
                        break;
                    case "s":
                        shuffle();
                        break;
                    case "q":
                        deck = new Stack<Card>(); //Resets stack so the stack doesnt contain anything, this breaks the loop
                        break;
                    default:
                        break;
                }
                
            }
            
        }
    }
}