using System;
using System.Collections.Generic;

class MinhaClasse {
    public static void Main (string[] args) {
        var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
   
        var k = 0;

        while(k != totalDeCasosDeTeste)
        {
            string frase = Console.ReadLine();

            List<string> subString = new List<string>();
                
            string[] aux = frase.Split(' ');

            subString.AddRange(aux);

            for(int i = 0; i < subString.Count - 1; i++)
            {
                for(int j = i+1; j < subString.Count; j++)
                {
                    if (subString[i] == subString[j])
                    {
                        //System.Console.WriteLine("item removido: {0} ; posição: {1}",subString[j],j);
                        subString.RemoveAt(j);
                        j--;
                        
                        /*for(int f = 0; f < subString.Count; f++)
                        {
                            Console.Write(subString[f] + " ");
                        }
                        System.Console.WriteLine();
                    }else{
                        System.Console.WriteLine("nenhum item removido");
                        for(int f = 0; f < subString.Count; f++)
                        {
                            Console.Write(subString[f] + " ");
                        }
                        System.Console.WriteLine();
                    */}
                }
            }

            subString.Sort();

            for(int f = 0; f < subString.Count; f++)
            {
                Console.Write(subString[f] + " ");
            }

            System.Console.WriteLine();

            subString.Clear();

            k++;
        }

    }
}