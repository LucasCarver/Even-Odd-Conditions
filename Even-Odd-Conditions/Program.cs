using System;

namespace Even_Odd_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            bool isEven;
            int number = 0;
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            string evenOddString;
            string input = "y";
            while (input == "y")
            {
                valid = false;
                while (!valid)
                {
                    Console.WriteLine($"\n{name}, please enter a number between 1 and 100.");
                    input = Console.ReadLine();
                    number = int.Parse(input);

                    if ((number >= 1) && (number <= 100))
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input. Please try again, {name}.");
                    }
                }

                //CHECK EVEN OR ODD
                isEven = number % 2 == 0;
                if (isEven)
                {
                    evenOddString = "even";
                }
                else
                {
                    evenOddString = "odd";
                }

                if ((number < 25) && isEven)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if ((number < 60) && isEven)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine($"{number} {evenOddString}");
                }

                valid = false;
                while (!valid)
                {
                    Console.WriteLine($"Would you, {name}, like to try again? (y/n)");
                    input = Console.ReadLine();
                    input = input.Substring(0, 1);

                    if (input == "y" | input == "n")
                    {
                        valid = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input. {name}, please try again.");
                    }
                }
            }
            Console.WriteLine("Thank you for participating.");
        }
    }
}