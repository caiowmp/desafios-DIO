using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c;
            string[] valor = Console.ReadLine().Split('.');
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
        
            double resultado;

            if( (b - c < a) && (a < b + c) && ( a - c  < b) && (b < a + c) && ( a - b  < c) && (c < a + b))
            {
                resultado = (a+b+c);
                Console.WriteLine("Perimetro = {0}", resultado);
            }else{
                resultado = (((a+b)*c)/2.0);
                Console.WriteLine("Area = {0}", resultado);
            }

    }

}