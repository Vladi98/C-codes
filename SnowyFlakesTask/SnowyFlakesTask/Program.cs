using System;
using System.Text.RegularExpressions;

namespace SnowyFlakesTask
{
    class Program
    {
        static void Main()
        {
            string Surface = @"^[^A-Za-z0-9]+$";
            string mantle = @"^[0-9_]+$";
            string core = @"^[A-Za-z]+$";
            string mixed = @"^[^A-Za-z0-9]+[0-9_]+[A-Za-z]+[0-9_]+[^A-Za-z0-9]+$";
            bool match = false;
            var length = 0;
            int count = 0;
            for (int i = 0; i < 1; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, Surface) == false)
                {
                    Console.WriteLine("Invalid");
                    match = true;
                    break;
                }
                input = Console.ReadLine();
                if (Regex.IsMatch(input, mantle) == false)
                {
                    Console.WriteLine("Invalid");
                    match = true;
                    break;
                }


                input = Console.ReadLine();
                if (Regex.IsMatch(input, mixed))
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] >= 'A' && input[j] <= 'Z' || input[j] >= 'a' && input[j] <= 'z')
                        {
                            count++;
                        }
                    }
                }

                if (Regex.IsMatch(input, mixed) == false)
                {
                    Console.WriteLine("Invalid");
                    match = true;
                    break;
                }
                input = Console.ReadLine();
                if (Regex.IsMatch(input, mantle) == false)
                {
                    Console.WriteLine("Invalid");
                    match = true;
                    break;
                }
                input = Console.ReadLine();
                if (Regex.IsMatch(input, Surface) == false)
                {
                    Console.WriteLine("Invalid");
                    match = true;
                    break;
                }

            }

            if (match == false)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(count);
            }
        }
    }
}


