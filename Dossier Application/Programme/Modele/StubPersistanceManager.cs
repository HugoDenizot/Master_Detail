using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{/// <summary>
/// Classe public StubPersistanceManager qui implémente l'interface IPersistanceManager
/// </summary>
    public class StubPersistanceManager : IPersistanceManager
    {   /// <summary>
        /// Méthode ChargeDonnées de type IEnumerable<Héros>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Héros> ChargeDonnées()
        {

            ///création d'une liste avec des héros nommé ListeDesHéros
            List<Héros> ListeDesHéros = new List<Héros>();
            /// ajout de héros dans la liste ListeDesHéros
            //ListeDesHéros.Add(new Héros("Ana", "/img/Ana.png", TypeClasse.Healer, new Histoire("C'est un heal", "/img/Ana.png", "https://www.youtube.com/watch?v=oJ09xdxzIJQ"), new Compétence("1", "2", "3", "4", "5"), new Compétitifs(16, 98), new Cosmétiques()));
            ListeDesHéros.Add(new Héros("Ange", "/img/Ange.png", TypeClasse.Healer));
            ListeDesHéros.Add(new Héros("Hanzo", "/img/Hanzo.png", TypeClasse.DPS));
            ListeDesHéros.Add(new Héros("D.Va", "/img/DVa.png", TypeClasse.Tank));
            return ListeDesHéros; /// retourne ListeDesHéros


        }
        /// <summary>
        /// méthode public SauvegardeDonnées 
        /// </summary>
        /// <param name="héros">paramètre de type IEnumerable<Héros>  </param>
        public void SauvegardeDonnées(IEnumerable<Héros> héros)
        {
            
        }
    }
}
