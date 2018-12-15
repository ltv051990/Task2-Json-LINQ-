using System;
using System.Collections.Generic;

namespace MyOutput
{
    public class ResultOutput
    {
        public static void Print(int []arrayToPrint, string output)
        {
            Console.WriteLine(output);

            if (arrayToPrint != null)
            {
                Array.ForEach(arrayToPrint, x => Console.Write("| {0} |", x));
                Console.WriteLine();
            }
            else
                Console.WriteLine("Emty data");

            Console.WriteLine(Environment.NewLine);
        }


        public static void Print(Dictionary<int, int> dictionary, string output)
        {
            Console.WriteLine(output);

            if (dictionary != null)
            {
                foreach (var t in dictionary)
                {
                    Console.Write("| Value -> {0} repeat {1} |", t.Key.ToString(), t.Key.ToString());
                }
                Console.WriteLine();
            }
        }


        public static void Print(int sum, string output)
        {
            Console.WriteLine("{0}{1}Sum = {2}", output, Environment.NewLine, sum);
        }
    }
}
