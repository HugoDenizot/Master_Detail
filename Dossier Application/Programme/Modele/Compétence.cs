using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
/// <summary>
/// Classe Compétence
/// </summary>
{
    public class Compétence : INotifyPropertyChanged
    {

        /// <summary>
        /// Propriété publique de type string de la classe Compétence Passif avec un get en public et un set en public lui aussi, le set contient OnPropertyChanged
        /// permettant de voir l'élément modifié lorsqu'on le change dans la fenêtre compétence.
        /// </summary>
        public string Passif
        {
            get { return _passif; }
            set { _passif = value;
                OnpropertyChanged(nameof(Passif));
            }
        }
        private string _passif;


        /// <summary>
        /// Propriété publique de type string de la classe Compétence CapPrimaire avec un get en public et un set public lui aussi, le set contient OnPropertyChanged
        /// permettant de voir l'élément modifié lorsqu'on le change dans la fenêtre compétence.
        /// </summary>


        public string CapPrimaire
        {
            get { return _capPrimaire; }
            set { _capPrimaire = value;
                OnpropertyChanged(nameof(CapPrimaire));
            }
        }
        private string _capPrimaire;


        /// <summary>
        /// Propriété publique de type string de la classe Compétence CapSecondaire avec un get en public et un set en public lui aussi, le set contient OnPropertyChanged
        /// permettant de voir l'élément modifié lorsqu'on le change dans la fenêtre compétence.
        /// </summary>
        public string CapSecondaire
        {
            get { return _capSecondaire; }
            set { _capSecondaire = value;
                OnpropertyChanged(nameof(CapSecondaire));
            }
        }
        private string _capSecondaire;


        /// <summary>
        /// Propriété publique de type string de la classe Compétence Ultimate avec un get en public et un set en public lui aussi, le set contient OnPropertyChanged
        /// permettant de voir l'élément modifié lorsqu'on le change dans la fenêtre compétence.
        /// </summary>
        public string Ultimate
        {
            get { return _ultimate; }
            set { _ultimate = value;
                OnpropertyChanged(nameof(Ultimate));
            }
        }
        private string _ultimate;


        /// <summary>
        /// Propriété publique de type string de la classe Compétence Vidéo avec un get en public et un set en public lui aussi, le set contient OnPropertyChanged
        /// permettant de voir la vidéo modifié lorsqu'on la change dans la fenêtre compétence.
        /// </summary>
        public string Vidéo
        {
            get { return _vidéo; }
            set { _vidéo = value;
                OnpropertyChanged(nameof(Vidéo));
            }
        }
        private string _vidéo;

        /// <summary>
        /// Constructeur public  de la classe Compétence, retourne un booléen
        /// </summary>
        /// <param name="pass">le Passif associé au héros qui fait partie de ses compétences</param>
        /// <param name="pass">le Passif associé au héros qui fait partie de ses compétences</param>
        /// <param name="caprim">la compétence primaire associée au héros qui fait partie de ses compétences</param>
        /// <param name="capsec">le compétence secondaire associé au héros qui fait partie de ses compétences</param>
        /// <param name="ulti">l'ultimate associé au héros qui fait partie de ses compétences</param>
        /// <param name="vid"> vidéo de présentation des compétences du héros</param>
        public Compétence (string pass, string capprim, string capsec, string ulti, string vid)
        {
            Passif = pass;
            CapPrimaire = capprim;
            CapSecondaire = capsec;
            Ultimate = ulti;
            Vidéo = vid;
        }
        /// <summary>
        /// Evenement qui se déclenche lors de la modification d'un paramètre.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Propriété qui est déclenché lorsque le propertyChanged est invoqué. Elle met à jour la valeur de la propriété passé en paramètre.
        /// </summary>
        /// <param name="propertyName"></param>Nom de la propriété mise à jour.
        void OnpropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
        /// <summary>
        /// ToString qui est utilisé dans les tests et permet de voir si les compétences sont bien modifiés, il n'est pas utilisé autrement.
        /// </summary>
        /// <returns>Il renvoie une chaine de caractère qui est une grande phrase donnant chaque capacité ainsi que l'URI de la vidéo de la compétence</returns>
        public override string ToString()
        {
            return $"Ma capacité primaire est :{CapPrimaire} ma secondaire:{CapSecondaire}, j'ai mon passif qui correspond à :{Passif} et enfin mon ultime qui s'appelle :{Ultimate}, mais vous pouvez voir tout cela ici{Vidéo}";
        }
    }
}
