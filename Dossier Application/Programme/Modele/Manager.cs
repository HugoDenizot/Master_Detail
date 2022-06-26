using AutoFixture;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Modele
{/// <summary>
/// Classe manager qui implémente INotifyPropertyChanged
/// </summary>
    public class Manager : INotifyPropertyChanged
    {
        /// <summary>
        /// Dépendance vers le gestionnaire de la Persistance du projet
        /// </summary>

        public IPersistanceManager Persistance { get; private set; }


        /// <summary>
        /// Création d'une liste de héros public de type ObservableCollection avec un public get et un public set. Le set contient un OnPropertyChnaged qui met à jour la collection lorsqu'il y a
        /// un changement à l'intérieur.
        /// </summary>
        public ObservableCollection<Héros> ListeDesHéros
        {
            get { return _listeDesHéros; }
            set { _listeDesHéros = value;
                OnpropertyChanged(nameof(ListeDesHéros));
            }
        }
        private ObservableCollection<Héros> _listeDesHéros;

        /// <summary>
        /// Evenement qui se déclenche lors de la modification d'un paramètre.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Propriété qui est déclenché lorsque le propertyChanged est invoqué. Elle met à jour la valeur de la propriété passé en paramètre.
        /// </summary>
        /// <param name="propertyName"></param>Nom de la propriété qui sera mise à jour
        void OnpropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Méthode qui sert à supprimer un héros de l'ObservableCollection
        /// </summary>
        /// <param name="h"></param>LeHéros à supprimer
        public void SupprimerHéros(Héros h)
        {
                ListeDesHéros.Remove(h);
        }
        /// <summary>
        /// Méthode publique AjouterHéros qui retourne un booléen
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour l'ajouter</param>
        /// <returns>retourne false si le héros passé est null ou si la liste contient déjà le héros, et  s'il n'est pas null et l'ajoute dans la liste, retourne true</returns>
        public bool AjouterHéros (Héros h)
        {
            if (ListeDesHéros.Contains(h) || h == null)
            {
                return false;
            }
            else
            {
                ListeDesHéros.Add(h);
                return true;
            }
        }


        /// <summary>
        /// Attribut correspond au héros sélectionné dans la listeBox dans la fenêtre MainWindow. Contient un OnPropertyChanged pour mettre à jour le héros lors d'une modification.
        /// </summary>
        public Héros HérosSelectionné
        {
            get { return hérosSelectionné; }
            set {
                hérosSelectionné = value;
                OnpropertyChanged(nameof(HérosSelectionné));
            }
        }
        private Héros hérosSelectionné;

        /// <summary>
        /// Méthode publique AjouterSkin 
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour indiquer a quel héros on doit rajouter le skin , qui lui aussi est passé en paramètre</param>
        /// <returns>retourne le booléan de la méthode AjouterSkin de la classe Héros</returns>
        public bool AjouterSkin(Skin s, Héros h)
        {
            return h.AjouterSkin(s);
        }
        /// <summary>
        /// Méthode publique SupprimerSkin 
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour indiquer a quel héros on doit supprimer le skin , qui lui aussi est passé en paramètre</param>
        /// <returns>retourne le booléan de la méthode SupprimerSkin de la classe Héros</returns>
        public bool SupprimerSkin(Skin s, Héros h)
        {
            return h.SupprimerSkin(s);
        }
        /// <summary>
        /// Méthode publique AjouterRéplique 
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour indiquer a quel héros on doit rajouter la réplique , qui lui aussi est passé en paramètre</param>
        /// <param name="r">on lui passe une réplique en paramètre qui sera celle à rajouter dans la liste du héros.</param>
        /// <returns>retourne le booléan de la méthode AjouterRéplique de la classe Héros</returns>
        public bool AjouterRéplique(Réplique r, Héros h)
        {
            return h.AjouterRéplique(r);
        }

        /// <summary>
        /// Méthode publique SupprimerRéplique 
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour indiquer a quel héros on doit supprimer la réplique , qui lui aussi est passé en paramètre</param>
        /// <param name="r">on lui passe une réplique en paramètre qui sera celle à supprimer dans la liste du héros.</param>
        /// <returns>Retourne le booléan de la méthode SupprimerRéplique de la classe Héros</returns>
        public bool SupprimerRéplique(Réplique r, Héros h)
        {
            return h.SupprimerRéplique(r);
        }
        /// <summary>
        /// Méthode publique AjouterTag 
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour indiquer a quel héros on doit rajouter le tag , qui lui aussi est passé en paramètre</param>
        /// <param name="t">on lui passe un tag en paramètre qui sera celui à rajouter dans la liste du héros.</param>
        /// <returns>Retourne le booléan de la méthode AjouterTag de la classe Héros</returns>
        public bool AjouterTag(Tag t, Héros h)
        {
            return h.AjouterTag(t);
        }
        /// <summary>
        /// Méthode publique SupprimerTag 
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour indiquer a quel héros on doit supprimer le tag , qui lui aussi est passé en paramètre</param>
        /// <param name="t">on lui passe un tag en paramètre qui sera celui à supprimer dans la liste du héros.</param>
        /// <returns>Retourne le booléan de la méthode SupprimerTag de la classe Héros</returns>
        public bool SupprimerTag(Tag t, Héros h)
        {
            return h.SupprimerTag(t);
        }
        /// <summary>
        /// Méthode publique AjouterEmote 
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour indiquer a quel héros on doit rajouter l'émote , qui lui aussi est passé en paramètre</param>
        /// <param name="e">on lui passe une émote en paramètre qui sera celui à rajouter dans la liste du héros.</param>
        /// <returns>Retourne le boolean de la méthode AjouterEmote de la classe Héros</returns>
        public bool AjouterEmote(Emote e, Héros h)
        {
            return h.AjouterEmote(e);
        }
        /// <summary>
        /// Méthode publique SupprimerEmote 
        /// </summary>
        /// <param name="h">on lui passe un héros en paramètre pour indiquer a quel héros on doit supprimer l'émote , qui lui aussi est passé en paramètre</param>
        ///  <param name="h">on lui passe une emote en paramètre qui sera celle à supprimer dans la liste du héros.</param>
        /// <returns>Retourne le booléan de la méthode SupprimerEmote de la classe Héros</returns>
        public bool SupprimerEmote(Emote e, Héros h)
        {
            return h.SupprimerEmote(e);
        }

        /// <summary>
        /// Méthode publique ChargeDonnées qui permet de charger les données de la liste ObservableCollection<Héros>
        /// </summary>
        public void ChargeDonnées()
        {
            ListeDesHéros = new ObservableCollection<Héros>(Persistance.ChargeDonnées());
        }
        /// <summary>
        /// méthode publique SauvegardeDonnées qui permet de récuperer les données nécessaires à la persistance 
        /// </summary>
        public void SauvegardeDonnées()
        {
            Persistance.SauvegardeDonnées(ListeDesHéros); // <== dépendance
        }

        /// <summary>
        /// Méthode qui permet de passer d'un type de persistance a un autre rapidemment
        /// </summary>
        /// <param name="persistance">le nom de la persistance (Stub , Json)</param>
        public Manager(IPersistanceManager persistance)
        {
            Persistance = persistance;
        }
    }
}
