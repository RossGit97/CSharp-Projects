using CardsProject.Models;
using System;

public class Player
{
    public String Name { get; }

    private List<Card> Hand;

    public int HandSize => Hand.Count;

    public Player(String name)
    {
        Name = name; 
        Hand = new List<Card>();
    }

    public void DrawFromDeck(Deck deck)
    {
        Hand.Add(deck.DrawCard());
    }

    public void ShowHand()
    {
        for (int x = 0; x < HandSize; x++)
        {
            Console.WriteLine(Hand[x].ToString());
        }
    }
}

