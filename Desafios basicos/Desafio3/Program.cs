using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                
              Console.WriteLine("{0} {1} {2}",i,i*i,i*i*i);
                
            }
        }
    }
}