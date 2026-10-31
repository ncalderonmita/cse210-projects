using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {   

        int grade;
        string letter;
        string sign;

        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage?");
        grade = int.Parse(Console.ReadLine());
        letter = "Unkown";

        if (grade < 60)
        {
            letter = "F";
        }

        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }

        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }

        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }

        else if (grade >= 90)
        {
            letter = "A";
        }

        if (grade%10 >= 7 && (letter != "A" && letter != "F" ))
        {
            sign = "+";
        }

        else if (grade%10 < 3 && letter != "F")

        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}");
        if (grade >= 70)
        {
            Console.WriteLine("You pass the class.");
        }

        else
        {
            Console.WriteLine("You do not pass the class");
        }
    }
}