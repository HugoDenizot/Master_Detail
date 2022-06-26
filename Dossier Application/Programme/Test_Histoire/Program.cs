using Modele;
using System;

namespace Test_Histoire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Histoire");

            Histoire Histoire1 = new Histoire("Ce personnage a rejoins overwatch","/img/Ana.png", "https://www.youtube.com/watch?v=2Yo23DQKMsA&t=1s");
            Histoire Histoire2 = new Histoire("Ce personnage est le fils d'Ana", "/img/Pharah.png", "https://www.youtube.com/watch?v=NcJk-W2seBc");
            Histoire Histoire3 = new Histoire("Ce personnage a rejoins overwatch puis est passé du côté de BlackWatch", "/img/Moira.png", "https://www.youtube.com/watch?v=LzYYMmcqK3A");

            Console.WriteLine(Histoire1);
            Console.WriteLine(Histoire2);
            Console.WriteLine(Histoire3);
        }
    }
}
