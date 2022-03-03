using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
        
            double resultado;

            if( (b - c < a) && (a < b + c) && ( a - c  < b) && (b < a + c) && ( a - b  < c) && (c < a + b))
            {
                resultado = (a+b+c);
                Console.WriteLine("Perimetro = " + resultado);
            }else{
                resultado = (((a+b)*c)/2.0);
                Console.WriteLine("Area = {0}", + resultado);
            }

    }

}