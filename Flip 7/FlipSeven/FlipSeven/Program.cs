namespace FlipSeven;

class Program
{
    static void main(string[] args)
    {
        Deck newDeck = new Deck();
        Console.WriteLine(newDeck.DrawCard().Number);

    }
}