using ClassesIerarchy.Interfaces;
using System;

namespace ClassesIerarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
           
           

            string command = Console.ReadLine();


            while (command!="End")
            {
                string []array = command.Split();

                if (array[0] == "Private")
                {
                    var privat = new Private(int.Parse(array[1]), array[2], array[3], decimal.Parse(array[4]));

                    Console.WriteLine(privat.ToString());

                }

                if (array[0] == "Commando")
                {
                    if (Enum.TryParse(array[5], true, out CorpType corp))
                    {

                        var privat = new Commando(int.Parse(array[1]), array[2], array[3], decimal.Parse(array[4]), corp);

                        Console.WriteLine(privat.ToString());
                    }
                }

               

            }
        }
    }
}
