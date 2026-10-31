using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum;
        double average;
        int i;
        int largest = 0;
        average = 0;
        sum = 0;
        number = 1;
        i = 0;
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
                i++;
                
                if(number > largest)
                {
                    largest = number;
                }
            }
        }
        while(number != 0);
        average = (double)sum/i;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The sum is: {average}");
        Console.WriteLine($"The largest number is: {largest}.");
    }
}