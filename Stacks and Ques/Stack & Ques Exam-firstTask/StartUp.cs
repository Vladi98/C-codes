using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Exersices
{
    public class StartUp
    {
        public static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());

            var listOfBullets = Console.ReadLine().Split().Select(int.Parse).ToList();
            var listOfLocks = Console.ReadLine().Split().Select(int.Parse).ToList();
            int money = int.Parse(Console.ReadLine());

            var bullets = new Stack<int>(listOfBullets);
            var locks = new Queue<int>(listOfLocks);
            int count = 0;

            var bulletsCount = 0;

            while (true)
            {
                count++;


                if (bullets.Peek() > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                    
                    bulletsCount++;
                    bullets.Pop();
                }

                else if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    
                    bulletsCount++;
                    locks.Dequeue();
                    bullets.Pop();
                }


                if (count == sizeOfGunBarrel)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }

                if (locks.Count == 0)
                {
                    var moneyResult = money - bulletsCount * bulletPrice;

                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyResult}");
                    break;
                }

                else if (bullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }

                
                 
            }
        }
    }
}
