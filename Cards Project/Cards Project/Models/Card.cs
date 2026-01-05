using CardsProject.Models;
using System;
public class Card
{
	public Rank Rank { get; }
	public Suit Suit { get; }
	public Card(Rank cardRank, Suit cardSuit)
	{
		Rank = cardRank;
		Suit = cardSuit;

	}
    public override string ToString()
    {
		return $"{Rank} of {Suit}";
    }
}
