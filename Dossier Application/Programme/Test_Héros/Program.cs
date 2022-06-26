using Modele;
using System;

namespace Test_Héros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Héros");

            Héros Héros1 = new Héros("Ana", "/img/Ana.png", TypeClasse.Healer);
            Héros Héros2 = new Héros("Ange", "/img/Ange.png", TypeClasse.Healer);
            Héros Héros3 = new Héros("Ana", "/img/Ange.png", TypeClasse.DPS);

            Console.WriteLine(Héros1);
            Console.WriteLine(Héros2);
            Console.WriteLine(Héros3);
            Héros1.ModifierClasse(TypeClasse.DPS);
            Console.WriteLine(Héros1);

            if (Héros1.Equals(Héros2))
            {
                Console.WriteLine("Les 2 héros sont identiques, le test a fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 héros sont apparement différent, le équals ne fonctionne pas");
            }
            if (Héros1.Equals(Héros3))
            {
                Console.WriteLine("Les 2 héros sont identiques, le test a fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 héros sont différent le équals fonctionne");
            }
        }
    }
}
