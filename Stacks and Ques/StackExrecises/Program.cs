using System;
using System.Collections.Generic;
using System.Linq;

namespace StackExrecises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine();

            var stack = new Stack<char>();
            
            var flag = true;

            
            foreach (char para in input)

            {

                switch (para)

                {

                    case '[':

                    case '(':

                    case '{':

                        stack.Push(para);

                        break;
                        
                    case '}':

                        if (!stack.Any())

                            flag = false;

                        
                        else if (stack.Pop() != '{')

                            flag = false;

                        break;
                        

                    case ')':

                        if (!stack.Any())

                            flag = false;



                        else if (stack.Pop() != '(')

                            flag = false;

                        break;
                        

                    case ']':

                        if (!stack.Any())

                            flag = false;



                        else if (stack.Pop() != '[')

                            flag = false;

                        break;

                }



                if (!flag)

                    break;

            }
            
            Console.WriteLine(flag ? "YES" : "NO");



        }
    }
}

//5 2 32 
//1 13 45 32 4