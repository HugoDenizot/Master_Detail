using Modele;
using System;

namespace Test_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Manager");

            Manager Manager = new Manager();
            Manager.ListeDesHéros.Add(new Héros("Ana", "/img/Ana.png", TypeClasse.DPS));
            Manager.ListeDesHéros.Add(new Héros("Ange", "/img/Ange.png", TypeClasse.DPS));
            Manager.ListeDesHéros.Add(new Héros("Ana", "/img/Ange.png", TypeClasse.Healer));
        }
    }
}
