using Modele;
using System;

namespace Test_Réplique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Réplique");

            Réplique Réplique1 = new Réplique("Salut", "/vidéo/Salutation.mp4", "Réplique d'Ana obtenu lors du lancement du jeu");
            Réplique Réplique2 = new Réplique("Regroupement", "/vidéo/Suivez moi.mp4", "Réplique d'Ana depuis le début du jeu");
            Réplique Réplique3 = new Réplique("Bonjour", "/vidéo/Salutation.mp4", "Réplique d'Ana depuis le début du jeu");
            Console.WriteLine(Réplique1);
            Console.WriteLine(Réplique2);
            Console.WriteLine(Réplique3);
            if (Réplique1.Equals(Réplique3))
            {
                Console.WriteLine("Les 2 répliques sont identiques, le équals a fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 répliques sont apparement différent, le équals ne fonctionne pas");
            }
            if (Réplique1.Equals(Réplique2))
            {
                Console.WriteLine("Les 2 répliques sont identiques, le équals n'a pas fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 répliques sont différent le équals fonctionné");
            }
        }
    }
}
