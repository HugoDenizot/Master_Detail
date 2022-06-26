using Modele;
using System;

namespace Test_Compétitif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Compétitif");

            Compétitifs Compétitif1 = new Compétitifs(70,60);
            Compétitifs Compétitif2 = new Compétitifs(75, 120);
            Compétitifs Compétitif3 = new Compétitifs(170, 10);
            Compétitifs Compétitif4 = new Compétitifs(70, -10);
            Compétitifs Compétitif5 = new Compétitifs(-70, 10);
            Compétitifs Compétitif6 = new Compétitifs(-70, 110);
            Compétitifs Compétitif7 = new Compétitifs(170, 110);
            Compétitifs Compétitif8 = new Compétitifs(170, -10);

            Console.WriteLine(Compétitif1);
            Console.WriteLine(Compétitif2);
            Console.WriteLine(Compétitif3);
            Console.WriteLine(Compétitif4);
            Console.WriteLine(Compétitif5);
            Console.WriteLine(Compétitif6);
            Console.WriteLine(Compétitif7);
            Console.WriteLine(Compétitif8);
        }
    }
}
