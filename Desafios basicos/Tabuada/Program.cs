using System;

namespace Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i<11; i++)
            {
                Console.WriteLine(string.Format(i + " x " + n + " = " + i*n));
            }
        }
    }
}