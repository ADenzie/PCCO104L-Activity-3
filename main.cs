using System;

class Program
{
    static void Main()
    {
        int number;
        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= 0)
            {
                if (number == 0)
                {
                    Console.WriteLine("Closing Program...");
                    break;
                }

                for (int a = 0; a < number; a++)
                {
                    for (int b = 0; b < number - a - 1; b++)
                    {
                        Console.Write(" ");
                    }
                    for (int c = 0; c < 2 * a + 1; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Invalid value: {input}");
            }
        }
    }
}
