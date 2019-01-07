using System;
using System.Linq;


namespace Random_Number
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your name (case-sensitive)");

            string user = Console.ReadLine();
            bool valid = true;

            while (valid)
            {
                if (!String.IsNullOrEmpty(user) && Char.IsUpper(user[0]))
                {
                    Console.WriteLine("Valid User");
                    Console.WriteLine();
                    valid = false;
                    EnterUser(user);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("User is not Valid! Please try again");
                    user = Console.ReadLine();
                    Console.ResetColor();

                }

            }
            
            GenerateNumber();
            
        }

        private static void EnterUser(string user)
        {

           
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine($"Welcome {user}!");
            Console.ResetColor();
        }


        public static void GenerateNumber()
        {
            
            Console.WriteLine("Guess the number you have 3 attempts");

            int number =0;
            Random random = new Random();
            var machineNumber = random.Next(1,11);
            NumberDescribtion(machineNumber);
            int cnt = 0;
            
            

           
            while (number != machineNumber)
            {
                string input = (Console.ReadLine());

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Please use a number");
                    continue;
                }

               
                if (cnt == 3)
                {
                    cnt++;

                    Console.WriteLine("Sorry! Better luck next time");
                    return;
                }

                if (number == machineNumber)
                {

                    Console.WriteLine($"Well done you guessed it. The number is {number}");
                    
                    
                }

                else Console.WriteLine("Try again!");

                
            }

          
            
        }

        private static int NumberDescribtion(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("It is neither composite nor a prime number!");
                    break;
                case 2: Console.WriteLine("The number is the smallest even number");
                    break;
                case 3: Console.WriteLine("The number is the result of a++ +a (a=1)");
                    break;
                case 4: Console.WriteLine("The number is the second trimorphic number");
                    break;
                case 5: Console.WriteLine("The number is the only prime number which equals the sum of two consequative prime numbers");
                    break;
                case 6: Console.WriteLine("The number is is the only even perfect number that is not the sum of successive odd cubes");
                    break;
                case 7: Console.WriteLine("The number is the lowest natural number that cannot be represented as the sum of the squares of three integers. ");
                    break;
                case 8: Console.WriteLine("The number is the highest possible dimension of a normed division algebra ");
                    break;
                case 9: Console.WriteLine("The number is the highest single-digit number in the decimal system.");
                    break;
                case 10: Console.WriteLine("The number is the sum of the first four factorials.");
                    break;

            }

            return number;
        }






    }
}
