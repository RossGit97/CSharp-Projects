namespace CardsProject;

using Models;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Card");
        Deck new_deck = new Deck();
        new_deck.Shuffle();
        string name = Console.ReadLine();
        Player p1 = new Player(name);
        //while (new_deck.DeckSize > 0)
        //{
        //    Console.WriteLine(new_deck.DrawCard().ToString());
        //    Console.WriteLine(new_deck.DeckSize);
        //}
        Console.WriteLine($"Player name is {p1.Name}");
        p1.DrawFromDeck( new_deck );
        Console.WriteLine($"{p1.Name} has {p1.HandSize} cards");
        p1.ShowHand();
    }
}