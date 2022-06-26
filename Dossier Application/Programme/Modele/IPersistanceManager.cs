using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{/// <summary>
/// Interface IPersistanceManager , donne le contrat a suivre pour les classes nécessaires à la persistance
/// </summary>
    public interface IPersistanceManager
    {/// <summary>
     /// définit une méthode ChargeDonnées dans le contrat de l'interface
     /// </summary>
     /// <returns>Un IEnumerable<Héros></returns>
        IEnumerable<Héros> ChargeDonnées();
        /// <summary>
        /// définit une méthode SauvegardeDonnées dans le contrat de l'interface
        /// </summary>
        /// <param name="héros">Donne en paramètre un héros de type IEnumerable<Héros></param>
        void SauvegardeDonnées(IEnumerable<Héros> héros);
    }
}
