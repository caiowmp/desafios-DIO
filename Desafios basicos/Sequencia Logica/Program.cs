using System; 

class SL{

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine("{0} {1} {2}", i,i*i,i*i*i);
                Console.WriteLine("{0} {1} {2}", i,Math.Pow(i,2) + 1,Math.Pow(i,3) + 1);
            }

    }

}