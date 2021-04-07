using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            while(true)
            {
                Console.WriteLine("Card Dealer!\nENTER to create a new deck\nQ to Quit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        deck.newDeck();
                        //deck.shuffle();
                        //deck.dealerMenu();
                        break;
                    case "q":
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
        }
    }
}
