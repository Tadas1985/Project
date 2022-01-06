using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int r = 6371;

            var area = 4 * (22 / 7) * r * r;

            // Task 2
           var volume = (float)(4.0 / 3 * Math.PI * r * r * r);

           // Task 3
           int side_1 = 15;
           int side_2 = 10;

           var solution = Math.Sqrt(Math.Pow(side_1, 2) + Math.Pow(side_2, 2));

           Console.WriteLine(solution);
        }
    }
}
