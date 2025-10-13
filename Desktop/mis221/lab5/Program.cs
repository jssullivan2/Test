﻿//main
using System.Globalization;

string userChoice = GetMenuChoice();
while (userChoice != "3")
{
    RouteEm(userChoice);
    userChoice = GetMenuChoice();
}
SayGoodbye();

//end main

static string GetMenuChoice()
{
    Console.Clear();
    System.Console.WriteLine("Please select a menu option (1-3)");
    System.Console.WriteLine("1. Display a deck of cards\n2. Display shuffled deck of cards\n3. Exit");
    return Console.ReadLine();
}

static void RouteEm(string userChoice)
{
    string[] deck = CreateDeck();
    switch (userChoice)
    {
        case "1":
            //Make method call here
            DisplayCards(deck);
            break;
        case "2":
            //Make method call here
            CardShuffle(deck);
            DisplayCards(deck);
            break;
        default:
            System.Console.WriteLine("Invalid menu choice...try again");
            break;
    }
    Pause();
}

static string[] CreateDeck()
{
    // Build and return a full deck of 52 cards
    // Each card should combine a value and a suit
    // (e.g., "Ace of Hearts", "Ten of Spades", etc.)
    // Use the provided suits and values arrays

    string[] suits = { "Heart", "Diamond", "Club", "Spade" };
    string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

    string[] cards = new string[52];

    // Your code here
    int number = 0;

    for (int i = 0; i < suits.Length; i++)
    {
        for (int j = 0; j < values.Length; j++)
        {
            cards[number] = " a " + values[j] + " of " + suits[i]; number++;
        }
    }

    return cards;

    
}

static void CardShuffle(string[] deck)
{
    // Rearrange the elements in the deck so the order is different each time the program runs
    // Your code here
    Random rand = new Random();
    for (int i = 0; i < deck.Length; i++)
    {
        int newNum = rand.Next(deck.Length);
        Swap(deck, i, newNum);
    }
    


}

//method to swap two cards
static void Swap(string[] deck, int x, int y)
{
    // swap logic here
    string temp = deck[x];
    deck[x] = deck[y];
    deck[y] = temp;
}

static int GetRandomNum(int lower, int upper)
{
    Random rnd = new Random();
    return rnd.Next(lower, upper);
}

static void DisplayCards(string[] cards)
{
    // Display every card in the array
    // Each card should print on its own line
    // Your code here

    System.Console.WriteLine("Your new deck" + cards.Length);
    for (int i = 0; i < cards.Length; i++)
    {
        System.Console.WriteLine($"Cards{cards[i]}");
    }

    
}

static void SayGoodbye() //runs when the user exits the program
{
    System.Console.WriteLine("Thanks for visiting, bye!");
}

static void Pause()
{
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey(); //forces the program to "pause" enter the user selects any key
}