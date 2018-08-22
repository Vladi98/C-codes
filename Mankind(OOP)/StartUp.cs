using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            string[] tokensStudent = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            try
            {
                var student = new Student(tokensStudent[0], tokensStudent[1], tokensStudent[2]);
                result.AppendLine(student.ToString());
                result.AppendLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                Environment.Exit(0);
            }

            string[] tokensWorker = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var worker = new Worker(tokensWorker[0], tokensWorker[1], double.Parse(tokensWorker[2]), double.Parse(tokensWorker[3]));
                result.AppendLine(worker.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                Environment.Exit(0);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
