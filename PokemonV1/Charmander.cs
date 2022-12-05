namespace pokemonApp;

class Charmander : Pokemon , ICapturable
{
    public int dexNumber = 4;
    string type = "fire";
    string[] abilities = {"ember", "flamethrower"};

    public int getHealth()
    {
        throw new NotImplementedException();
    }

    public void isCaptured()
    {
        throw new NotImplementedException();
    }

    public override void Sound()
    {
         Console.WriteLine("*charmander noises*");
    }
    public void isCaptured()
    {
        Console.WriteLine("I've been captured!")
    }
}