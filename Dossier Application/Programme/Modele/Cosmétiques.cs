using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Modele
{/// <summary>
/// Classe Cosmétiques
/// </summary>
    public class Cosmétiques : INotifyPropertyChanged
    {   /// <summary>
        /// Création d'une ObservableCollection  de Skin "LesSkins". Cette liste est une observableCollection car elle est amené a être modifié par des ajouts et des suppressions.
        /// Le set est composé de OnPropertyChanged pour que la liste se mette à jour à chaque ajout.
        /// </summary>
        public ObservableCollection<Skin> LesSkins
        {
            get { return _lesSkins; }
            set
            {
                _lesSkins = value;
                OnpropertyChanged(nameof(LesSkins));
            }
        }
        private ObservableCollection<Skin> _lesSkins;


        /// <summary>
        /// Création d'une ObservableCollection de type Réplique "LesRépliques".  Cette liste est une observableCollection car elle est amené a être modifié par des ajouts et des suppressions.
        /// Le set est composé de OnPropertyChanged pour que la liste se mette à jour à chaque ajout.
        /// </summary>
        public ObservableCollection<Réplique> LesRépliques
        {
            get { return _lesRépliques; }
            set { _lesRépliques = value;
                OnpropertyChanged(nameof(LesRépliques));
            }
        }
        private ObservableCollection<Réplique> _lesRépliques;

        /// <summary>
        /// Création d'une ObservableCollection publique  de type Emote "LesEmotes". Cette liste est une observableCollection car elle est amené a être modifié par des ajouts et des suppressions.
        /// Le set est composé de OnPropertyChanged pour que la liste se mette à jour à chaque ajout.
        /// </summary>
        public ObservableCollection<Emote> LesEmotes
        {
            get { return _lesEmotes; }
            set { _lesEmotes = value;
                  OnpropertyChanged(nameof(LesEmotes));
            }
        }
        private ObservableCollection<Emote> _lesEmotes;

        /// <summary>
        /// Création d'une ObservableCollection publique de type Tag "LesTags".Cette liste est une observableCollection car elle est amené a être modifié par des ajouts et des suppressions.
        /// Le set est composé de OnPropertyChanged pour que la liste se mette à jour à chaque ajout.
        /// </summary>
        public ObservableCollection<Tag> LesTags
        {
            get { return _lesTags; }
            set { _lesTags = value;
                OnpropertyChanged(nameof(LesTags));
            }
        }
        private ObservableCollection<Tag> _lesTags;

        /// <summary>
        /// Evenement qui se déclenche lors de la modification d'un paramètre.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Propriété qui est déclenché lorsque le propertyChanged est invoqué. Elle met à jour la valeur de la propriété passé en paramètre.
        /// </summary>
        /// <param name="propertyName"></param>Nom de la propriété Mise a jour
        void OnpropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Méthode publique  AjouterSkin qui permet d'ajouter un élément de type skin dans la liste "LesSkins" , retourne un booléen
        /// </summary>
        /// <param name="s">s de type Skin possède une image , description et un nom </param>
        /// <returns> si l'élément est null elle retourne false ou si l'élément contient déjà le skin, sinon elle l'ajoute dans la liste et retourne true</returns>
        public bool AjouterSkin(Skin s)
        {
            if (LesSkins.Contains(s) || s == null)
            {
                return false;
            }
            else
            {
                LesSkins.Add(s);
                return true;
            }
        }
        /// <summary>
        /// Méthode publique  SupprimerSkin qui permet de supprimer un élément de type skin dans la liste "LesSkins" , retourne un booléen
        /// </summary>
        /// <param name="s">s de type Skin possède une image , description et un nom </param>
        /// <returns>si l'élément passé en paramètre est contenue dans la liste elle le supprime et retourne true sinon retourne false si l'élément est null et/ou si la liste ne contient pas le skin</returns>
        public bool SupprimerSkin(Skin s)
        {
            if (LesSkins.Contains(s)&&s!=null)
            {
                LesSkins.Remove(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Méthode publique  AjouterRépliques qui permet d'ajouter un élément de type répliques dans la liste "LesRépliques" , retourne un booléen
        /// </summary>
        /// <param name="r">r de type Réplique possède une vidéo , description et un nom </param>
        /// <returns>si l'élément est null ou si la liste le contient déjà elle retourne false, sinon elle l'ajoute dans la liste et retourne true</returns>
        public bool AjouterRéplique(Réplique r)
        {
            if (LesRépliques.Contains(r) || r == null)
            {
                return false;
            }
            else
            {
                LesRépliques.Add(r);
                return true;
            }
        }
        /// <summary>
        /// Méthode publique  SupprimerRéplique qui permet de supprimer un élément de type répliques dans la liste "LesRépliques" elle vérifie , retourne un booléen
        /// </summary>
        /// <param name="r">r de type Réplique possède une vidéo , description et un nom </param>
        /// <returns>si l'élément passé en paramètre est contenue dans la liste si oui elle le supprime et retourne true sinon retourne false si l'élément est null et/ou si la liste ne contient pas la réplique</returns>
        public bool SupprimerRéplique(Réplique r)
        {
            if (LesRépliques.Contains(r) && r != null)
            {
                LesRépliques.Remove(r);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Méthode publique  AjouterEmote qui permet d'ajouter un élément de type Emote dans la liste "LesEmotes" , retourne un booléen
        /// </summary>
        /// <param name="e">e de type Emote possède une vidéo , description et un nom </param>
        /// <returns>si l'élément est null ou si la liste contient déjà l'emote elle retourne false, sinon elle l'ajoute dans la liste et retourne true</returns>
        public bool AjouterEmote(Emote e)
        {
            if (LesEmotes.Contains(e) || e == null)
            {
                return false;
            }
            else
            {
                LesEmotes.Add(e);
                return true;
            }
        }

        /// <summary>
        /// Méthode publique  SupprimerEmote qui permet de supprimer un élément de type Emote dans la liste "LesEmotes" , retourne un booléen
        /// </summary>
        /// <param name="e">e de type Emote possède une vidéo , description et un nom </param>
        /// <returns>elle vérifie si l'élément passé en paramètre est contenue dans la liste si oui elle le supprime et retourne true , sinon retourne false  si l'élément est null</returns>
        public bool SupprimerEmote(Emote e)
        {
            if (LesEmotes.Contains(e) && e != null)
            {
                LesEmotes.Remove(e);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Méthode publique  AjouterTag qui permet d'ajouter un élément de type Tag dans la liste "LesTags", retourne un booléen
        /// </summary>
        /// <param name="t">t de type Tag possède une image , description et un nom </param>
        /// <returns>si l'élément est null ou est déjà dans la liste elle retourne false, sinon elle l'ajoute dans la liste et retourne true</returns>
        public bool AjouterTag(Tag t)
        {
            if (LesTags.Contains(t) || t == null)
            {
                return false;
            }
            else
            {
                LesTags.Add(t);
                return true;
            }
        }
        /// <summary>
        /// Méthode publique  SupprimerTag qui permet de supprimer un élément de type Tag dans la liste "LesTags", retourne un booléen
        /// </summary>
        /// <param name="t">t de type Tag possède une image , description et un nom </param>
        /// <returns>elle vérifie si l'élément passé en paramètre est contenue dans la liste si oui elle le supprime et retourne true sinon retourne false si l'élément est null et/ou si la liste ne le contient pas</returns>
        public bool SupprimerTag(Tag t)
        {
            if (LesTags.Contains(t) && t != null)
            {
                LesTags.Remove(t);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
