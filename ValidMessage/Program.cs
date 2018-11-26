using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace TheVLogger
{


    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            //string pattern = (@"^s:([^;]+);r:([^;]+);m--([""A - Za - z ""]+)$");
            var newSender = "";

            for (int i = 0; i < inputNumber; i++)
            {
                string input = Console.ReadLine();

                string[] parts = input.Split(';');
                if (parts.Length == 3)
                { 
                   var sender = parts[0];
                   var reciever = parts[1];
                   var massage = parts[2];

                   newSender = null;
                    
             
                    if (!sender.Contains(';') && sender.StartsWith("s:") && !reciever.Contains(';')
                        && reciever.StartsWith("r:") && Regex.IsMatch(massage, @"^m--[""A-Za-z0-9 ""]+$"))
                    {
                        for (int j = 2; j < sender.Length; j++)
                        {
                            if (char.IsDigit(sender[j]))
                            {
                                int num = int.Parse(sender[j].ToString());
                                sum += num;

                            }

                            if (Char.IsLetter(sender[j]) ||sender[j]==' ')
                            {
                                newSender += (sender[j]);
                            }
                        }
                        newSender += " says ";
                        newSender+=@"""";
                        for (int j = 2; j < massage.Length; j++)
                        {

                            if (massage[3] == '"' && massage[massage.Length - 1] == '"' && Char.IsLetter(massage[j]) || Char.IsWhiteSpace(massage[j]))
                            {

                                newSender +=(massage[j]);
                            }
                        }
                        newSender += @"""";

                        newSender += " to ";
                        for (int j = 2; j < reciever.Length; j++)
                        {
                            if (char.IsDigit(reciever[j]))
                            {
                                int num = int.Parse(reciever[j].ToString());
                                sum += num;
                            }

                            if (Char.IsLetter(reciever[j]) || reciever[j] == ' ')
                            {
                                newSender += (reciever[j]);
                            }
                        }

                        Console.WriteLine(newSender);


                    }
                }
                
            }

            Console.WriteLine($"Total data transferred: {sum}MB");

        }
    }


  
}
