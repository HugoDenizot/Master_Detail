using Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Logique d'interaction pour UserControlSkin.xaml
    /// </summary>
    public partial class UserControlSkin : UserControl
    {
        public Manager Manager => (App.Current as App).Manager;  //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App
        public Héros Héros //Héros donnée par la navBar
        {
            get { return (Héros)GetValue(HérosProperty); }
            set { SetValue(HérosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Héros.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HérosProperty =
            DependencyProperty.Register("Héros", typeof(Héros), typeof(UserControlSkin), new PropertyMetadata(default(Héros))); //Dependency Property utile aux bindings

        public UserControlSkin()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e) //Bouton qui sert à ajouter un skin
        {
            var ajouterSkin = new AjouterSkins();
            ajouterSkin.ShowDialog();
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e) //bouton qui sert à supprimer le skin sélectionné.
        {
            Manager.SupprimerSkin((Skin)lesSkins.SelectedItem,Manager.HérosSelectionné);
        }
    }
}
