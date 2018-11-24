using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
   
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();
            var list = new List<int>();
            var result = 0;
            var count = 0;


            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);

            }

            for (int i = 0; i < num; i++)
            {
               

                for (int j = i + 1; j < num; j++)
                {
                    if (list[i] == list[j])
                    {
                        result = list[i];
                        count++;
                    }
                }


                if (count % 2 == 0)
                {
                    Console.WriteLine(result);
                    return;
                }

                else
                {
                    count = 0;
                }
            }



        }
       
    }
}
