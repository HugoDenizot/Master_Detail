using Modele;
using System;
using System.Xml.Schema;

namespace Test_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Tag");

            Tag Tag1 = new Tag("Succès", "/img/Mignon.png", "Tag d'Ana obtenu lors de la réussite d'un Haut fait");
            Tag Tag2 = new Tag("Succès", "/img/Pixel.png", "Tag d'Ana obtenu lors de la réussite d'un Haut fait");
            Tag Tag3 = new Tag("Mignon", "/img/Mignon.png", "Tag d'Ana pour la réussite d'un Haut fait");
            Console.WriteLine(Tag1);
            Console.WriteLine(Tag2);
            Console.WriteLine(Tag3);
            if (Tag1.Equals(Tag3))
            {
                Console.WriteLine("Les 2 tags sont identiques, le équals a fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 tags sont apparement différent, le équals ne fonctionne pas");
            }
            if (Tag1.Equals(Tag2))
            {
                Console.WriteLine("Les 2 tags sont identiques, le équals n'a pas fonctionné");
            }
            else
            {
                Console.WriteLine("Les 2 tags sont différent le équals fonctionne");
            }
        }
    }
}
