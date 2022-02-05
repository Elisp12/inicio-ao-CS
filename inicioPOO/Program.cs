using System;
using inicioPOO.models;

namespace inicioPOO
{
    public class Program 
    {
        private static string opcao()
        {
            Console.WriteLine("--------------- CATÁLOGO MTB -----------------");
            Console.WriteLine("\nEscolha uma das Opções:\n");
            Console.WriteLine($"\n[ 1 ] Bikes com Preços mais acessíveis \t\t [ 2 ] Bikes mais Populares \t\t [ 3 ] Catálogo completo [ X ] SAIR");

            string opna = Console.ReadLine();
            Console.WriteLine();
            return opna;
        }
        static void Main(String[] args)
        {
            menu b1 = new menu("Mountain bike", "mtb0001", "GTS");
            menu b2 = new menu("Mountain bike", "mtb2042", "Absolute");
            menu b3 = new menu("Mountain bike", "E-caliber", "Trake");
            menu b4 = new menu("Bike Esportiva", "Ed", "Scott");
            menu b5 = new menu("Mountain bike", "mtb0075", "Kls");
            menu b6 = new menu("Speed", "Taiwan", "Giant");


            string opna = opcao();
            while(opna.ToUpper() != "X")
            {
                switch(opna)
                {
                    case "1":
                    // Bikes com Preços mais acessíveis
                    Console.WriteLine("\n\t - Bikes com Preços mais acessíveis -\n");
                    Console.WriteLine("[1]");
                    b1.mostrar();
                    Console.WriteLine("[2]");
                    b2.mostrar();
                    Console.WriteLine("[3]");
                    b4.mostrar();
                    break;

                    case "2":
                     // bikes mais populares
                     Console.WriteLine($"\n\t - Bikes mais Populares -\n");
                     Console.WriteLine("[1]");
                     b3.mostrar();
                     Console.WriteLine("[2]");
                     b5.mostrar();
                     Console.WriteLine("[3]");
                     b6.mostrar();
                    break;

                    case "3":
                    Console.WriteLine("[1]");
                    b1.mostrar();
                    Console.WriteLine("[2]");
                    b2.mostrar();
                    Console.WriteLine("[3]");
                    b3.mostrar();
                    Console.WriteLine("[4]");
                    b4.mostrar();
                    Console.WriteLine("[5]");
                    b5.mostrar();
                    Console.WriteLine("[6]");
                    b6.mostrar();

                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opna = opcao();
            }
        }   
    }
} 