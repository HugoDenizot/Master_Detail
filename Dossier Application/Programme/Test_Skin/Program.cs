using Modele;
using System;

namespace Test_Skin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Skin");

            Skin Skin1 = new Skin("Chouette blanche", "/img/Ana.png", "Skin d'Ana obtenu lors de l'event de Noël de 2018");
            Skin Skin2 = new Skin("Chouette Blanche", "/img/Ange.png", "Skin d'Ana obtenu lors de l'event de Noël de 2018");
            Skin Skin3 = new Skin("Victoire ailé", "/img/Ana.png", "Skin d'Ana pour l'hiver 2018");
            Console.WriteLine(Skin1);
            Console.WriteLine(Skin2);
            Console.WriteLine(Skin3);
            if (Skin1.Equals(Skin3))
            {
                Console.WriteLine("Les 2 skins sont identiques, le équals a fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 skins sont apparement différent, le équals ne fonctionne pas");
            }
            if (Skin1.Equals(Skin2))
            {
                Console.WriteLine("Les 2 skins sont identiques, le équals n'a pas fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 skins sont différent le équals fonctionne");
            }
        }
    }
}
