using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while(x != 0)
            {
              int soma = 0;
              
              if(x % 2 != 0)
              {
                x++;
              }
              
              for(int  i = 0; i < 10; i+=2)
              {
                soma += x + i;
              }
              Console.WriteLine(soma);
              x = int.Parse(Console.ReadLine());
            }
        }
    }
  }
