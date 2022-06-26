using Modele;
using System;

namespace Test_Emote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Emote");

            Emote Emote1 = new Emote("Assise", "/vidéo/Fusil Bionique.mp4", "Emote d'Ana obtenu lors de l'event de Noël de 2018");
            Emote Emote2 = new Emote("Assise", "/vidéo/FusilBio.mp4", "Emote d'Ana obtenu lors de l'event de Noël de 2018");
            Emote Emote3 = new Emote("Danse", "/vidéo/Fusil Bionique.mp4", "Emote d'Ana pour l'anniversaire 2018");
            Console.WriteLine(Emote1);
            Console.WriteLine(Emote2);
            Console.WriteLine(Emote3);
            if (Emote1.Equals(Emote3))
            {
                Console.WriteLine("Les 2 emotes sont identiques, le équals a fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 emotes sont apparement différent, le équals ne fonctionne pas");
            }
            if (Emote1.Equals(Emote2))
            {
                Console.WriteLine("Les 2 emotes sont identiques, le équals n'a pas fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 emotes sont différent le équals fonctionne");
            }
        }
    }
}
