using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
{/// <summary>
/// Classe Histoire
/// </summary>
    public class Histoire: INotifyPropertyChanged
    {/// <summary>
     /// La classe publique  Histoire possède une description de type string avec un public get et un public set
     /// </summary>
        public string Description { get;set; }

        /// <summary>
        /// Propriété correspondant au chemin de la miniature de la BD/vidéo du personnage
        /// </summary>
        public string Miniature
        {
            get { return _miniature; }
            set
            {
                _miniature = value;
                OnpropertyChanged(nameof(Miniature));
            }
        }
        private string _miniature;

        /// <summary>
        /// La classe public Histoire possède un Média de type string  avec un public get et un public set
        /// </summary>
        public string Média { get; set; }


        /// <summary>
        /// Constructeur publique  de la classe histoire qui prend 3 éléments en paramètres
        /// </summary>
        /// <param name="des">Description de type string passée en paramètre</param>
        /// <param name="med">Le lien vers la BD ou la Vidéo </param>
        /// <param name="chemin">De type String permet de donner à l'application l'image de la miniature</param>
        public Histoire (string des, string chemin, string med)
        {
            Description = des;
            Miniature = chemin;
            Média = med;
        }

        /// <summary>
        /// Evenement qui se déclenche lors de la modification d'un paramètre.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Propriété qui est déclenché lorsque le propertyChanged est invoqué. Elle met à jour la valeur de la propriété passé en paramètre.
        /// </summary>
        /// <param name="propertyName"></param>Nom de la propriété mise à jour
        void OnpropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        /// <summary>
        /// Méthode qui demande d'afficher la description de la biographie du Héros, le chemin de sa miniature et l'url de sa vidéo
        /// </summary>
        /// <returns>Retourne une phrase expliquant la description, le chemin de la miniature et le média</returns>
        public override string ToString()
        {
            return $"Voici l'histoire du Héros {Description}, la miniature de la BD/vidéo est :{Miniature}, et voici son chemin url :{Média} ";
        }
    }
}
