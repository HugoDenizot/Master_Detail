using Modele;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projet_CSharp
{
    /// <summary>
    /// Logique d'interaction pour Supprimer_Héros.xaml
    /// </summary>
    public partial class Supprimer_Héros : Window
    {
        public Manager Manager => (App.Current as App).Manager;  //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App

        public Héros LeHéros { get; set;} //Attribut du Héros qui va être supprimer.
        public Supprimer_Héros()
        {
            InitializeComponent();
            var h = new Héros("", "", TypeClasse.DPS); //Création d'un héros vide 
            LeHéros = new Héros(h.Prénom, h.Image, h.Classe); //Création de l'Héros supprimé à partir du Héros vide.
            DataContext = this;
            
        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            Héros hérosfin = new Héros(LeHéros.Prénom, LeHéros.Image, LeHéros.Classe);
            if (Manager.HérosSelectionné.Equals(hérosfin))
            {
                MessageBox.Show("Vous ne pouvez pas supprimé le héros qui est sélectionné, veuillez rééssayer", "Suppression impossible", MessageBoxButton.OK, MessageBoxImage.Error); //Message qui empêche la suppression si le héros données est le même que celui sélectionné.
                Close(); //Fermeture sans modification
            }
            else if(Manager.ListeDesHéros.Contains(hérosfin)){
                MessageBox.Show("Ce héros n'existe pas, veuillez en choisir un autre", "Erreur de suppression", MessageBoxButton.OK, MessageBoxImage.Error); //Message qui informe que la supression n'est pas possible car le Héros n'existe pas
                Close();//Fermeture sans modification
            }
            else
            {
                Manager.SupprimerHéros(hérosfin);//Suppression du Héros
                MessageBox.Show("Cet héros a été supprimé", "Validation de la suppression", MessageBoxButton.OK, MessageBoxImage.Information); //Message qui informe du bon déroulement de la suppression.
                Close(); //fermeture avec Modification
            }
            
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close(); //Fermeture sans modification
        }
    }
}
