using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
{/// <summary>
/// Classe Emote
/// </summary>
    public class Emote : INotifyPropertyChanged
    {/// <summary>
     /// Attribut public  Nom de type string de la classe Emote avec un public get et un public set
     /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Attribut public  VideoNom de type string de la classe Emote avec un public get et un public set
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
        /// Attribut public  Description de type string de la classe Emote avec un public get et un public set
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// Constructeur public d'une Emote 
        /// </summary>
        /// <param name="name">Nom de l'emote de type string</param>
        /// <param name="vid">Nom (chemin permettant de la retrouver) de la vidéo de type string</param>
        /// <param name="des">Description de l'emote de type string</param>
        public Emote(string name, string vid, string des)
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
        /// <param name="propertyName"></param>Nom de la propriété Mise à jour
        void OnpropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Méthode publique ToString permettant de retourner une chaine de caraactère correspondant au nom de l'emote
        /// </summary>
        /// <returns>retourne le nom de l'emote</returns>
        public override string ToString()
        {
            return $"{Nom}";
        }
        /// <summary>
        /// Méthode publique  equals de la classe Emote permettant de comparé le type de deux objets , retourne un booléen
        /// </summary>
        /// <param name="o">Objet passé en paramètre de type Object</param>
        /// <returns>retourne false si l'objet passé en paramètre est null, ou si le type d'objet passé en paramètre ne correspond pas à une emotes ou si toutes les conditions n'ont pas été respecté</returns>
        /// <returns>retourne true si l'objet passé en paramètre correspond à une émote , il vérifie aussi si c'est le même objet passé en paramètre avec une quatrième condition qui vérifie sile nom de la vidéo correspond entre les deux objets (sont identiques ou non)</returns>

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
                Emote autre = (Emote)o;
                if (VideoNom==autre.VideoNom)
                {
                    return true;
                }
                return false;
            }

    }
}
