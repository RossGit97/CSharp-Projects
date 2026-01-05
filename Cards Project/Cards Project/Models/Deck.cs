using CardsProject.Models;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;

public class Deck
{
    private List<Card> _cards;    
    public int DeckSize => _cards.Count;
    public bool IsEmpty => _cards.Count == 0;
    
    private readonly Random rng = new Random(); //seed only once, when the deck is created

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
        //Random rng = new();
        //_cards = _cards.OrderBy(_ => rng.Next()).ToList();

        //Using Fisher-Yates shuffle
        int rndm;
        Card temp;
        for(int x  = _cards.Count - 1; x > 0; x--)
        {
            rndm = rng.Next(x + 1);
            temp = _cards[x];
            _cards[x] = _cards[rndm];
            _cards[rndm] = temp;
        }
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

