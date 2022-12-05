namespace pokemonApp;
class Program
{
    static void Main(string[] args)
    {
          // first, just have the values .. the refactor to use a collection.
        int userChoice;
        int compChoice;
        
         Random randumNum = new Random();

        //Object instantiation
        //Pokemon pokeman1 = new Pokemon("charmander", "fire",);
       // Pokemon pokeman2 = new Pokemon("squirtle", "water");
        //Pokemon pokeman3 = new Pokemon("bulbasaur", "grass" );

        //int charmander =1;
       // int squirtle =2;
       // int bulbasaur =3;

       
        //Choose Pokemon
        Console.WriteLine("Choose your Pokemon\n\t1 Charmander, \n\t2 Squirtle, or \n\t3 Bulbasaur");
        string? userInput = Console.ReadLine();
        Console.WriteLine($"The user inputted: {userInput}");

        //generate the computers random
        compChoice = randumNum.Next(1,4);
        Console.WriteLine(compChoice);

        //TODO: error check the input
        bool success = int.TryParse(userInput, out userChoice);
        


        /* if (userChoice == compChoice)
        {
            Console.WriteLine("It's a tie, try again");
        }
        else if (userChoice == charmander && compChoice == bulbasaur|| userChoice == bulbasaur && compChoice == squirtle|| userChoice == squirtle && compChoice == charmander)
        {
            Console.WriteLine("You win");
        }
        else 
        {
            Console.WriteLine("You lose");
        }


       // int charmander = 1;
       // int squirtle = 2;
       // int Bulbasaur = 3;

       /* charmander.type = "fire";
        charmander.dexNumber = 4;
        squirtle.type = "Water";
        squirtle.dexNumber = 7;
        bulbasaur.type = "grass";
        bulbasaur.dexNumber = 1;
        Console.WriteLine(charmander.ToString());
        Console.WriteLine(squirtle.ToString());
        Console.WriteLine(bulbasaur.ToString());*/



        //comparing input to the expected string values, then assign the value to its corresponding string.
        //int isCharmander = String.Compare(userInput, "CHARNANDER");
        //int isSquirtle = String.Compare(userInput, "SQUIRTLE");
        //int isBulbasaur = String.Compare(userInput, "BULBSAUR");
        


        
        //You can use dot notation to access fields and methods available to an object of that class.
        //charmander.type = "fire";
       // charmander.dexNumber = 4;
        //
        //This is how you call an instance method. It "belongs to" objects of that class.
        //You must instantiate an object of that class to call it.
        //charmander.IsPokemon();

        //This is how you call a Class/static method. It "belongs to" the class. You do not need 
        //to instantiate an object to call it. 
        //Pokemon.Sound();



        
    }
}


