using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
/// <summary>
/// Classe Compétitifs 
/// </summary>
{
    public class Compétitifs :INotifyPropertyChanged
    {
        /// <summary>
        /// Propriété publique  de la classe Compétitifs avec un public get et un public set qui permet de récupérer le Pourcentage de Win et de le set. Ce set contient une propriété OnPropertyChanged
        /// permettant de voir sa modification dans la fenêtre UserControlGagné, après appel de la fenêtre ModifWin
        /// </summary>
        public string PourcentWin
        {
            get { return _pourcentWin; }
            set
            {
                _pourcentWin = value;
                OnpropertyChanged(nameof(PourcentWin));
            }
        }
        private string _pourcentWin;



        /// <summary>
        /// Propriété publique  de la classe Compétitifs avec un public get et un public set qui permet de récupérer le Pourcentage de Choix de ce personnage et de le set.Ce set contient une 
        /// propriété OnPropertyChanged permettant de voir sa modification dans la fenêtre UserControlJoué, après appel de la fenêtre ModifChoix
        /// </summary>
        public string PourcentChoix
        {
            get { return _pourcentChoix; }
            set { _pourcentChoix = value;
                OnpropertyChanged(nameof(PourcentChoix));
            }
        }
        private string _pourcentChoix;


        /// <summary>
        /// Constructeur public de la classe Compétitifs avec en paramètre un int "win" et un autre int "choix", ces int sont ensuite testé pour être sur qu'il soit bien compris entre 0 et 100
        /// </summary>
        /// <param name="win">Le nombre de victoire avec un héros passé en paramètre</param>
        /// <param name="choix">Le nombre de choix d'un héros par les joueurs en pourcentage passé en paramètre</param>
        public Compétitifs(int win,int choix)
        {
            if(win>=0&& win<=100)
            {
                PourcentWin = win.ToString();

            }
            else
            {
                PourcentWin = "0";
            }
            if (choix >= 0 && choix <= 100)
            {
                PourcentChoix = choix.ToString();
            }
            else
            {
                
                PourcentChoix = "0";
            }
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
        /// Le ToString est utilisé notemment dans les tests.
        /// </summary>
        /// <returns>Cette méthode retourne une phrase donnant le pourcentage de win et de choix du joueur</returns>
        public override string ToString()
        {
            return $"Le pourcentage de win est de {PourcentWin}, et le pourcentage de choix est de {PourcentChoix}";
        }
    }
}
