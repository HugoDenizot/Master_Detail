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

namespace Projet_CSharp.Xaml
{
    /// <summary>
    /// Logique d'interaction pour Competitif.xaml
    /// </summary>
    public partial class Competitif : UserControl
    {
        public Héros Héros //Prends le Héros donné par la fenêtre NavBar
        {
            get { return (Héros)GetValue(HérosProperty); }
            set { SetValue(HérosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Héros.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HérosProperty =
            DependencyProperty.Register("Héros", typeof(Héros), typeof(Competitif), new PropertyMetadata(default(Héros)));




        public Competitif()
        {
            InitializeComponent();

            ControlGagné.Visibility = Visibility.Hidden;
            ControlJoué.Visibility = Visibility.Hidden;
        }

        private void PartieGagnée(object sender, RoutedEventArgs e)
        {
            ControlGagné.Visibility = Visibility.Visible;
            ControlJoué.Visibility = Visibility.Hidden;
        }

        private void PartieJouée(object sender, RoutedEventArgs e)
        {
            ControlGagné.Visibility = Visibility.Hidden;
            ControlJoué.Visibility = Visibility.Visible;
        }
    }
}