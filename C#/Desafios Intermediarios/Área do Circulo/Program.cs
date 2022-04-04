using System; 
using System.Globalization;

class Classe {

    static void Main(string[] args)
    {
        double area, raio;
        double pi = 3.14159;

        //para ler os valores em double, recebidos com '.' entre a casa inteira e decimal, de forma correta
        NumberFormatInfo provider = new NumberFormatInfo();
        provider.NumberDecimalSeparator = ".";

        raio = double.Parse(Console.ReadLine(),provider);

        area = pi * (Math.Pow(raio,2));

        System.Console.WriteLine("A={0:F4}",area.ToString("G",CultureInfo.InvariantCulture));

        Console.ReadKey();
    }

}