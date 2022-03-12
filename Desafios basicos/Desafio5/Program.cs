using System;
using System.Globalization;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            //para ler os valores em double, recebidos com '.' entre a casa inteira e decimal, de forma correta
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            A = double.Parse(Console.ReadLine(),provider);
            B = double.Parse(Console.ReadLine(),provider);
            C = double.Parse(Console.ReadLine(),provider);
            
            double media;
            media = ((A*2)+(B*3)+(C*5))/10;
            
            Console.WriteLine($"MEDIA = {media}", media.ToString("G",CultureInfo.InvariantCulture));
            //Console.WriteLine("MEDIA = {0:F2}", media);
            Console.ReadKey();
        }
    }
}