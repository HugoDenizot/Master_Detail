using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Modele;
using System.IO;


namespace Modele
{/// <summary>
/// classe JsonPersistanceManager qui implémente IPersistanceManager ( c'est-à-dire qu'elle suit le contrat définit par IPersistanceManager
/// </summary>
    public class JsonPersistanceManager : IPersistanceManager
    {/// <summary>
     /// Méthode publique ChargeDonnées 
     /// </summary>
     /// <returns>retourne un IEnumerable<Héros> désérialisé avec la persistance en json depuis le fichier BDD.json </returns>
        public IEnumerable<Héros> ChargeDonnées()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Héros>>(File.ReadAllText("BDD.json"));
        }
        /// <summary>
        /// Méthode publique SauvegardeDonnées avec un paramètre de type IEnumerable<Héros>
        /// </summary>
        /// <param name="héros"> un héros de type IEnumerable<Héros> </param>
        public void SauvegardeDonnées(IEnumerable<Héros> héros)
        {
            string json = JsonConvert.SerializeObject(héros); /// sérialise dans un string un objet héros grâce à la persistance json
            
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "BDD.json"), json); /// écrit dans le dossier les informations 
        }
    }
}
