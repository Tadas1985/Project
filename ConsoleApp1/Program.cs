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
        }
    }
}
