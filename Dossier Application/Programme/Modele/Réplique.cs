using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Modele
{/// <summary>
/// Classe publique Réplique
/// </summary>
    public class Réplique:INotifyPropertyChanged
    {/// <summary>
     /// Attribut public Nom de type String de la classe réplique avec un public set et un public get
     /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Attribut public VideoNom de type String de la classe réplique avec un public set et un public get. Le set contient un OnPropertyChanged pour être mis à jour lors de la modification
        /// </summary>
        public string VideoNom
        {
            get { return _videoNom; }
            set {
                _videoNom = value;
                OnpropertyChanged(nameof(VideoNom));
            }
        }
        private string _videoNom;

        /// <summary>
        /// Attribut public Descritpion de type String de la classe réplique avec un public set et un public get
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Constructeur public d'une réplique avec un nom , une vidéo et une description
        /// </summary>
        /// <param name="name">nom de la réplique a creer de type string </param>
        /// <param name="vid">vidéo qui correspond a cette réplique de type string </param>
        /// <param name="des">description de la réplique de type string  </param>
        public Réplique(string name, string vid, string des)
        {
            Nom = name;
            VideoNom = vid;
            Description = des;
        }

        /// <summary>
        /// Evenement qui se déclenche lors de la modification d'un paramètre.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Propriété qui est déclenché lorsque le propertyChanged est invoqué. Elle met à jour la valeur de la propriété passé en paramètre.
        /// </summary>
        /// <param name="propertyName"></param>Nom de la propriété qui sera mise a jour.
        void OnpropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Méthode publique ToString
        /// </summary>
        /// <returns>retourne une chaine caractère avec le nom de la réplique</returns>
        public override string ToString()
        {
            return $"{Nom}";
        }
        /// <summary>
        /// Méthode publique  equals de la classe Réplique permettant de comparé le type de deux objets , retourne un booléen
        /// </summary>
        /// <param name="o">Objet passé en paramètre de type Object</param>
        /// <returns>retourne false si l'objet passé en paramètre est null, ou si le type d'objet passé en paramètre ne correspond pas à une réplique ou si toutes les conditions n'ont pas été respecté</returns>
        /// <returns>retourne true si l'objet passé en paramètre correspond à une réplique , il vérifie aussi si c'est le même objet passé en paramètre avec une quatrième condition qui vérifie si le nom de la vidéo correspond entre les deux objets (sont identiques ou non)</returns>
        public override bool Equals(Object o)
        {
            if (o == null)
            {
                return false;
            }
            if (this == o)
            {
                return true;
            }
            if (GetType() != o.GetType())
            {
                return false;
            }
            Réplique autre = (Réplique)o;
            if (VideoNom == autre.VideoNom)
            {
                return true;
            }
            return false;
        }
    }
}
