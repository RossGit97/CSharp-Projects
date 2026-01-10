using System;
using System.Collections.Generic;
using System.Text;

public class Deck
{
    private List<Card> NewDeck;
    public int DeckSize => NewDeck.Count;
    public bool IsEmpty => NewDeck.Count == 0;
    private readonly Random rng = new Random();

    public Deck()
    {
        CreateDeck();
    }
    private void CreateDeck()
    {
        NewDeck = new List<Card>();
        for (int x = 12; x > 0; x--)
        {
            for (int y = x; y > 0; y--)
            {
                NewDeck.Add(new Card(y));
            }
        }
        NewDeck.Add(new Card(0));
    }

    public Card DrawCard()
    {
        return NewDeck[0];
    }
}

