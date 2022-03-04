using System;
using System.Globalization;

class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c;

            //para ler os valores em double, recebidos com '.' entre a casa inteira e decimal, de forma correta
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
        
            double resultado;

            a = Convert.ToDouble(Console.ReadLine(),provider);
            b = Convert.ToDouble(Console.ReadLine(),provider);
            c = Convert.ToDouble(Console.ReadLine(),provider);

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);

            if( (b - c < a) && (a < b + c) && ( a - c  < b) && (b < a + c) && ( a - b  < c) && (c < a + b))
            {
                resultado = (a+b+c);
                Console.WriteLine("Perimetro = {0}", resultado.ToString("G",CultureInfo.InvariantCulture));
                //ToString para sair no formato correto (uma casa decimal, sendo ela indicada por '.')
            }else{
                resultado = (((a+b)*c)/2.0);
                Console.WriteLine("Area = {0}", Math.Round(resultado, 2));
            } 

    }

}