using System; 
 
class DIO{
 
    static void Main(string[] args) {
		
        string[] input;  
        //recebe a entrada toda em uma linha e separado por ' '
        input = Console.ReadLine().Split(' ');
        
        int cod1 = int.Parse(input[0]);
        int n1 = int.Parse(input[1]);
        double valor1 = double.Parse(input[2]);
    
 	    input = Console.ReadLine().Split(' ');
        
        int cod2 = int.Parse(input[0]);
	    int n2  = int.Parse(input[1]);
        double valor2 = double.Parse(input[2]);

        double total = (n1 * valor1) + (n2 * valor2);

        //imprime com duas casas decimais
        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
    }

}