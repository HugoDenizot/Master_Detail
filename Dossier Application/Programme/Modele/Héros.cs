using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Modele
{/// <summary>
/// Classe Héros
/// </summary>
    public class Héros :INotifyPropertyChanged
    {/// <summary>
     /// Attribut Prénom de type string de la classe Héros avec un public get et un public set
     /// </summary>
        public string Prénom { get; set; }



        /// <summary>
        /// Evenement qui se déclenche lors de la modification d'un paramètre.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Attribut Image de type string de la classe Héros avec un public get et un public set
        /// </summary>
        public string Image
        {
            get { return _image; }
            set { _image = value;
                OnpropertyChanged(nameof(Image));
            }
        }
        private string _image;
        /// <summary>
        /// Propriété qui est déclenché lorsque le propertyChanged est invoqué. Elle met à jour la valeur de la propriété passé en paramètre.
        /// </summary>
        /// <param name="propertyName"></param>Nom de la propriété mise à jour
        void OnpropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Attribut Classe de type TypeClasse de la classe Héros avec un public get et un public set
        /// </summary>
        public TypeClasse Classe { get; set; }

        /// <summary>
        /// Attribut ImageClasse de type string de la classe Héros avec un public get et un public set
        /// </summary>
        public string  ImageClasse{get; set;}

        /// <summary>
        /// Attribut CouleurClasse de type string de la classe Héros avec un public get et un public set
        /// </summary>
        public string CouleurClasse { get; set; }
        /// <summary>
        /// Attribut Histoire de type Histoire de la classe Héros avec un public get et un public set
        /// </summary>
        public Histoire Histoire { get; set; }
        /// <summary>
        /// Attribut Details de type Compétitifs de la classe Héros avec un public get et un public set
        /// </summary>
        public Compétitifs Détails { get; set; }
        /// <summary>
        /// Attribut sesCompétences de type Compétence de la classe Héros avec un public get et un public set
        /// </summary>
        public Compétence SesCompétences { get; set; }
        /// <summary>
        /// Attribut public SesCosmétiques de type Cosmétiques de la classe Héros avec un public get et un public set
        /// </summary>
        public Cosmétiques SesCosmétiques { get; set; }

        /// <summary>
        /// Deuxième constructeur public d'un Héros avec cette fois seulement un nom , une image et un type de classe parmi "tank" , "dps" et "heal". En fonction du type de classe on lui associé une couleur , si c'est un dps cela lui donne la couleur blue , rouge pour le tank et jaune pour le heal
        /// </summary>
        /// <param name="name">nom du héros de type string</param>
        /// <param name="img">nom de l'image (chemin) de type string</param>
        /// <param name="classe">TypeClasse est une énumération de "tank" "dps" et "heal" qui permet de l'associé à un héros</param>
        public Héros(string name, string img, TypeClasse classe) { 
           
                Prénom = name;
                Image = img;
                this.Classe = classe;

                switch (classe)
                {
                    case TypeClasse.DPS:
                        ImageClasse = "/img/dps.png";
                        CouleurClasse = "Blue";
                        break;
                    case TypeClasse.Healer:
                        ImageClasse = "/img/heal.png";
                        CouleurClasse = "Yellow";
                        break;
                    case TypeClasse.Tank:
                        ImageClasse = "/img/tank.png";
                        CouleurClasse = "Red";
                        break;
                }
            /// creer une histoire qui reprend le nom du héros selectionén et sa classe , avec son image et sa vidéo
            Histoire = new Histoire($"{Prénom}" + " est un personnage de type " + $"{Classe}",Image, "");

            Random Aléatoire = new Random();
            /// lui associe ses infos compétitives correspondantes
            Détails = new Compétitifs(Aléatoire.Next(101),Aléatoire.Next(101));
            /// lui associe ses 4 compétences
            SesCompétences = new Compétence("1", "2", "3", "4", "vidéo/Fusil Bionique.mp4");
            SesCosmétiques = new Cosmétiques();
        }
        /// <summary>
        /// Constructeur Json qui permet a la classe Json de recréer des Héros lors de la méthode ChargeDonnées(), elle prends en paramètre chaque information nécessaire à la création d'un héros
        /// et les crées.
        /// </summary>
        /// <param name="Prénom"></param>Prénom du Héros
        /// <param name="Image"></param>Image du Héros
        /// <param name="Classe"></param>Classe du Héros
        /// <param name="Description"></param>Descriptiond de son histoire
        /// <param name="minia"></param>Miniature de sa vidéo/BD
        /// <param name="Media"></param>URL vers sa BD/vidéo
        /// <param name="PourcentWin"></param>Pourcentage de victoire avec ce Héros
        /// <param name="PourcentChoix"></param>Pourcentage de choix de ce héros par les joueurs
        /// <param name="Passif"></param> Nom de son passif
        /// <param name="CapPrimaire"></param> Nom de sa capacité principale
        /// <param name="CapSecondaire"></param>Nom de sa capacité secondaire
        /// <param name="Ultimate"></param>Nom de son ultimate
        /// <param name="Vidéo"></param>Non de sa vidéo de présentationd de capacité
        /// <param name="SesComsmétiques"></param>sa liste de cosmétiques
        [JsonConstructor]
        public Héros (string Prénom,string Image, string Classe, string Description,string minia, string Media, int PourcentWin, int PourcentChoix, string Passif, string CapPrimaire, string CapSecondaire, string Ultimate, string Vidéo,Cosmétiques SesComsmétiques)
        {
            this.Prénom = Prénom;
            this.Image = Image;
            if (Classe == "1")
            {
                this.Classe = TypeClasse.Healer;
                ImageClasse = "/img/heal.png";
                CouleurClasse = "Yellow";

            }
            else if (Classe== "2")
            {
                this.Classe = TypeClasse.DPS;
                ImageClasse = "/img/dps.png";
                CouleurClasse = "Blue";
            }
            else if (Classe == "0")
            {
                this.Classe = TypeClasse.Tank;
                ImageClasse = "/img/tank.png";
                CouleurClasse = "Red";
            }

            this.Histoire = new Histoire(Description, minia, Media);
            this.Détails = new Compétitifs(PourcentWin, PourcentChoix);
            this.SesCompétences = new Compétence(Passif, CapPrimaire, CapSecondaire, Ultimate, Vidéo);
            this.SesCosmétiques = SesCosmétiques;

        }

        /// <summary>
        /// Méthode public  AjouterSkin , permet l'ajout d'un skin , retourne un booléen
        /// </summary>
        /// <param name="s">élément de type skin avec un nom , une image et une description</param>
        /// <returns>retourne le booléen de la méthode AjouterSkin dans Cosmétique</returns>
        public bool AjouterSkin(Skin s)
        {
            return SesCosmétiques.AjouterSkin(s);
        }
        /// <summary>
        /// Méthode qui permet de modifier la classe d'un héros.
        /// </summary>
        /// <param name="classe"></param>Nouveau Type de Classe
        public void ModifierClasse(TypeClasse classe)
        {
            Classe = classe;
        }

        /// <summary>
        /// Méthode public  SupprimerSkin , permet la suppression d'un skin , retourne un booléen
        /// </summary>
        /// <param name="s">élément de type skin avec un nom , une image et une description</param>
        /// <returns>retourne le booléen de la méthode SupprimerSkin dans Cosmétique</returns>
        public bool SupprimerSkin(Skin s)
        {
            return SesCosmétiques.SupprimerSkin(s);
        }

        /// <summary>
        /// Méthode public  AjouterTag , permet l'ajout d'un tag , retourne un booléen
        /// </summary>
        /// <param name="t">élément de type tag avec un nom , une image et une description</param>
        /// <returns>retourne le booléen de la méthode AjouterTag dans Cosmétique</returns>
        public bool AjouterTag(Tag t)
        {
            return SesCosmétiques.AjouterTag(t);
        }

        /// <summary>
        /// Méthode public  SupprimerTag, permet la suppression d'un tag , retourne un booléen
        /// </summary>
        /// <param name="t">élément de type tag avec un nom , une image et une description</param>
        /// <returns>retourne le booléen de la méthode SupprimerTag dans Cosmétique</returns>
        public bool SupprimerTag(Tag t)
        {
            return SesCosmétiques.SupprimerTag(t);
        }
        /// <summary>
        /// Méthode public  AjouterEmote , permet l'ajout d'une emote , retourne un booléen
        /// </summary>
        /// <param name="e">élément de type emote avec un nom , une vidéo et une description</param>
        /// <returns>retourne le booléen de la méthode AjouterEmote dans Cosmétique</returns>
        public bool AjouterEmote(Emote e)
        {
            return SesCosmétiques.AjouterEmote(e);
        }

        /// <summary>
        /// Méthode public  SupprimerEmote , permet la suppression d'une emote , retourne un booléen
        /// </summary>
        /// <param name="e">élément de type emote avec un nom , une vidéo et une description</param>
        /// <returns>retourne le booléen de la méthode SupprimerEmote dans Cosmétique</returns>
        public bool SupprimerEmote(Emote e)
        {
            return SesCosmétiques.SupprimerEmote(e);
        }

        /// <summary>
        /// Méthode public  AjouterRéplique , permet l'ajout d'une réplique , retourne un booléen
        /// </summary>
        /// <param name="r">élément de type réplique avec un nom , une vidéo et une description</param>
        /// <returns>retourne le booléen de la méthode AjouterRéplique dans Cosmétique</returns>
        public bool AjouterRéplique(Réplique r)
        {
            return SesCosmétiques.AjouterRéplique(r);
        }

        /// <summary>
        /// Méthode public  SupprimerRéplique , permet la suppression d'une réplique, retourne un booléen
        /// </summary>
        /// <param name="r">élément de type réplique avec un nom , une vidéo et une description</param>
        /// <returns>retourne le booléen de la méthode SupprimerRéplique dans Cosmétique</returns>
        public bool SupprimerRéplique(Réplique r)
        {
            return SesCosmétiques.SupprimerRéplique(r);
        }
        /// <summary>
        /// Méthode public  Equals qui compare si 2 objets sont du mêmte type retourne un booléen
        /// </summary>
        /// <param name="o">type Object passé en paramètre , c'est l'objet a comparé</param>
        /// <returns>retourne false si l'objet passé en paramètre est null, ou si le type d'objet passé en paramètre ne correspond pas à un Héros ou si toutes les conditions n'ont pas été respecté</returns>
        /// <returns>retourne true si l'objet passé en paramètre correspond à un Héros , il vérifie aussi si c'est le même objet passé en paramètre avec une quatrième condition qui vérifie si le Prénom  correspond entre les deux objets (sont identiques ou non) </returns>
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
            Héros autre = (Héros)o;
            if (Prénom == autre.Prénom)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Méthode public  ToString qui permet de retourner une chaine de caractère avec le prénom du héros et son image
        /// </summary>
        /// <returns>retourne le prénom et limage d'un héros</returns>
        public override string ToString()
        {
            return $"{Prénom} ({Image})";
        }
    }
}
