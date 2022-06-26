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
    /// Logique d'interaction pour Cosmétique.xaml
    /// </summary>
    public partial class Cosmétique : UserControl
    {
        public Héros Héros
        {
            get { return (Héros)GetValue(HérosProperty); }
            set { SetValue(HérosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Héros.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HérosProperty =
            DependencyProperty.Register("Héros", typeof(Héros), typeof(Cosmétique), new PropertyMetadata(default(Héros))); //DependencyProperty utilisé pour le binding.





        public Cosmétique()
        {
            

            InitializeComponent();

            ControlSkin.Visibility = Visibility.Hidden;
            ControlEmote.Visibility = Visibility.Hidden;
            ControlTags.Visibility = Visibility.Hidden;
            ControlRepliques.Visibility = Visibility.Hidden; //LEs 4 lignes servent à cacher les UC Réplique,Tag,Ski,Emote
        }

        private void ButtonSkin(object sender, RoutedEventArgs e) //Bouton qui sert a afficher l'UC Skin.
        {
            ControlSkin.Visibility = Visibility.Visible;
            ControlEmote.Visibility = Visibility.Hidden;
            ControlTags.Visibility = Visibility.Hidden;
            ControlRepliques.Visibility = Visibility.Hidden;
        }

        private void ButtonReplique(object sender, RoutedEventArgs e) //Bouton qui sert a afficher l'UC Réplique
        {
            ControlSkin.Visibility = Visibility.Hidden;
            ControlEmote.Visibility = Visibility.Hidden;
            ControlTags.Visibility = Visibility.Hidden;
            ControlRepliques.Visibility = Visibility.Visible;
        }

        private void ButtonTag(object sender, RoutedEventArgs e) //Bouton qui sert à afficher l'UC Tag
        {
            ControlSkin.Visibility = Visibility.Hidden;
            ControlEmote.Visibility = Visibility.Hidden;
            ControlTags.Visibility = Visibility.Visible;
            ControlRepliques.Visibility = Visibility.Hidden;
        }

        private void ButtonEmote(object sender, RoutedEventArgs e) //Bouton qui sert à afficher l'UC Emote
        {
            ControlSkin.Visibility = Visibility.Hidden;
            ControlEmote.Visibility = Visibility.Visible;
            ControlTags.Visibility = Visibility.Hidden;
            ControlRepliques.Visibility = Visibility.Hidden;
        }
       
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
