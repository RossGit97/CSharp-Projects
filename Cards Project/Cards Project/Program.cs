namespace CardsProject;

using Models;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Card");
        Deck new_deck = new Deck();
        new_deck.Shuffle();
        while (new_deck.DeckSize > 0)
        {
            Console.WriteLine(new_deck.DrawCard().ToString());
            Console.WriteLine(new_deck.DeckSize);
        }
        
    }
}