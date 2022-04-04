using System; 

class Problem {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            
        int lados = int.Parse(v[0]);
        int comprimento = int.Parse(v[1]);

        int perimetro = lados * comprimento;

        System.Console.WriteLine(perimetro);

    }

}