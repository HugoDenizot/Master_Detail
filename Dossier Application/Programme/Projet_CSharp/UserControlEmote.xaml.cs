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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet_CSharp
{
    /// <summary>
    /// Logique d'interaction pour UserControlEmote.xaml
    /// </summary>
    public partial class UserControlEmote : UserControl
    {


        public Manager Manager => (App.Current as App).Manager;  //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App

        public Héros Héros //Héros transmis par la fenêtre NavBar
        {
            get { return (Héros)GetValue(HérosProperty); }
            set { SetValue(HérosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Héros.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HérosProperty =
            DependencyProperty.Register("Héros", typeof(Héros), typeof(UserControlEmote), new PropertyMetadata(default(Héros))); //Dependency Property utile pour le binding




        public UserControlEmote()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e) //Bouton permettant l'affichage de l'ajout d'emote
        {
            var ajouterEmote = new AjouterEmotes();
            ajouterEmote.ShowDialog();
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e) //Bouton permettant la suppresion d'emote
        {
            Manager.SupprimerEmote((Emote)LesEmotes.SelectedItem, Manager.HérosSelectionné);
        }
    }
}
