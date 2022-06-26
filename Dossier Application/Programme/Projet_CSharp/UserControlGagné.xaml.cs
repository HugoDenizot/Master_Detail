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
    /// Logique d'interaction pour UserControlGagné.xaml
    /// </summary>
    public partial class UserControlGagné : UserControl
    {
        public UserControlGagné()
        {
            InitializeComponent();
        }

        public Héros Héros //Héros donnée par la fenête NavBAr
        {
            get { return (Héros)GetValue(HérosProperty); }
            set { SetValue(HérosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HérosProperty =
            DependencyProperty.Register("Héros", typeof(Héros), typeof(UserControlGagné), new PropertyMetadata(default(Héros))); //Dépendency Property utile aux bindings

        private void Modifier(object sender, RoutedEventArgs e) //bouton qui ouvre la fenêtre de modification
        {
            var modifWin = new ModifierWin();
            modifWin.ShowDialog();
        }
    }
}
