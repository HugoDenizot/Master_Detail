using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
{/// <summary>
/// Classe public Tag
/// </summary>
    public class Tag :INotifyPropertyChanged
    {   /// <summary>
        /// Attribut public Nom de type String avec un public get et un public set
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Attribut public ImageNom de type String avec un public get et un public set. Le set contient un OnPropertyChanged qui permet la mise à jour de l'image lors de sa modfication.
        /// </summary>
        public string ImageNom
        {
            get { return _imageNom; }
            set { _imageNom = value;
                OnpropertyChanged(nameof(ImageNom));
            }
        }
        private string _imageNom;

        /// <summary>
        /// Attribut public Descritpion de type String avec un public get et un public set
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructeur public d'un tag avec 3 paramètres
        /// </summary>
        /// <param name="name">nom du tag a creer de type string </param>
        /// <param name="img">image associé au tag de type string </param>
        /// <param name="des">description du tag de type string </param>
        public Tag(string name, string img, string des)
        {
            Nom = name;
            ImageNom = img;
            Description = des;
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
        /// Méthode ToString qui retourne une chaine de caractère
        /// </summary>
        /// <returns>retourne une chaine de caractère avec le nom du tag</returns>
        public override string ToString()
        {
            return $"{Nom}";
        }

        /// <summary>
        /// Méthode publique  equals de la classe Tag permettant de comparé le type de deux objets , retourne un booléen
        /// </summary>
        /// <param name="o">Objet passé en paramètre de type Object</param>
        /// <returns>retourne false si l'objet passé en paramètre est null, ou si le type d'objet passé en paramètre ne correspond pas à un tag  ou si toutes les conditions n'ont pas été respecté</returns>
        /// <returns>retourne true si l'objet passé en paramètre correspond à un tag , il vérifie aussi si c'est le même objet passé en paramètre avec une quatrième condition qui vérifie si le nom de l'image correspond entre les deux objets (sont identiques ou non)</returns>
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
            if (this.GetType() != o.GetType())
            {
                return false;
            }
            Tag autre = (Tag)o;
            if (ImageNom == autre.ImageNom)
            {
                return true;
            }
            return false;
        }

    }
}
