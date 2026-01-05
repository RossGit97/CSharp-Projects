using CardsProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

public class Deck
{
    private List<Card> _cards;    
    public int DeckSize => _cards.Count;
    public bool IsEmpty => _cards.Count == 0;

    public Deck()
    {
        CreateDeck();
    }

    private void CreateDeck()
    {
        _cards = new List<Card>();
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                _cards.Add(new Card(rank, suit));
            }
        }
    }

    public void Shuffle()
    {
        Random rng = new();
        _cards = _cards.OrderBy(_ => rng.Next()).ToList();
    }

    public Card DrawCard()
    {
        if (_cards.Count == 0)
            throw new InvalidOperationException("Deck is empty");

        Card card = _cards.First();
        _cards.Remove(card);
        return card;
    }

    public void Reset()
    {
        CreateDeck();
        Shuffle();

    }
}

