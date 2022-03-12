using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  tipo1; 
        String  tipo2;
        String  tipo3;

        tipo1 = Console.ReadLine(); 
        tipo2 = Console.ReadLine();
        tipo3 = Console.ReadLine();

        if ((tipo1 == "vertebrado") && (tipo2 == "ave")  && (tipo3 == "carnivoro")) {
            System.Console.WriteLine("aguia");
        }

        if ((tipo1 == "vertebrado") && (tipo2 == "ave")  && (tipo3 == "onivoro")) {
            System.Console.WriteLine("pomba");
        }

        if ((tipo1 == "vertebrado") && (tipo2 == "mamifero")  && (tipo3 == "onivoro")) {
            System.Console.WriteLine("homem");
        }

        if ((tipo1 == "vertebrado") && (tipo2 == "mamifero")  && (tipo3 == "herbivoro")) {
            System.Console.WriteLine("vaca");
        }

        if ((tipo1 == "invertebrado") && (tipo2 == "inseto")  && (tipo3 == "hematofago")) {
            System.Console.WriteLine("pulga");
        }

        if ((tipo1 == "invertebrado") && (tipo2 == "inseto")  && (tipo3 == "herbivoro")) {
            System.Console.WriteLine("lagarta");
        }

        if ((tipo1 == "invertebrado") && (tipo2 == "anelideo")  && (tipo3 == "hematofago")) {
            System.Console.WriteLine("sanguessuga");
        }

        if ((tipo1 == "invertebrado") && (tipo2 == "anelideo")  && (tipo3 == "onivoro")) {
            System.Console.WriteLine("minhoca");
        }

        Console.ReadKey();
    }
}