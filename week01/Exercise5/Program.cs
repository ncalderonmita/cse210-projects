using System;

class Program
{

    static void DisplayWelcome ()
        {
            Console.WriteLine($"Welcome to the Program!");
        }
    static string PromptUserName ()
        {   
            string name;
            Console.WriteLine($"What is your name?");
            name = Console.ReadLine();

            return name;

        }

    static int PromptUserNumber()
        {
            int number;
            Console.WriteLine($"What is your favorite number?");
            number = int.Parse(Console.ReadLine());

            return number;
        }

    static int SquareNumber(int number)
    {
        int square;
        square = number * number;
        return square;
    }


    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {square}.");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);


    }


}