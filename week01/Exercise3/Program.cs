using System;

class Program
{
    static void Main(string[] args)
    {   
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int guessedNumber = 101;
        int numberGuesses = 0;
        string keyword = "yes";

        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        while (keyword == "yes")
        {
            while (guessedNumber != number)
            {
                Console.WriteLine("What is the magic number? ");
                guessedNumber = int.Parse(Console.ReadLine());
                numberGuesses++;
                if (guessedNumber < number)
                {
                    Console.WriteLine("Higher");
                }

                else if (guessedNumber > number)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine($"You did it!. It took you {numberGuesses} guesses.");
            number = randomGenerator.Next(1,100);
            guessedNumber = 101;
            numberGuesses = 0;
            Console.WriteLine("Do you want to play again?");
            keyword = Console.ReadLine();
        }
        

        
    }
}