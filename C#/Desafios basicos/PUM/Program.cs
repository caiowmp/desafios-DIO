using System;

namespace TESTE {
    class Program {
        static void Main(string[] args) {
        
            int N = int.Parse(Console.ReadLine());

            int primeiro = 1;
            for (int i = 1; i <= N; i++) {

                Console.Write(primeiro + " ");
                primeiro++;
                Console.Write(primeiro + " ");
                primeiro++;
                Console.Write(primeiro + " ");
                primeiro++;
                Console.WriteLine("PUM");
                primeiro++;
                
            }
        }
    }
}