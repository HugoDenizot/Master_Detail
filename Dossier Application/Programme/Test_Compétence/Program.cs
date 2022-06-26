using Modele;
using System;

namespace Test_Compétence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la méthode Compétence");

            Compétence compétences1 = new Compétence("Fusil", "Grenade", "Fleche dodo", "Nanoboost", "/vidéo/Fusil Bionique.mp4");
            Compétence compétences2 = new Compétence("Roquette", "Sprint", "Pack de soin", "Visière tactique", "/vidéo/Roquette hélix.mp4");
            Compétence compétences3 = new Compétence("Propulsion", "Roquette", "Matrice", "Explosion meca", "/vidéo/Matrice.mp4");

            Console.WriteLine(compétences1);
            Console.WriteLine(compétences2);
            Console.WriteLine(compétences3);
        }
    }
}
