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
    /// Logique d'interaction pour UserControlJoue.xaml
    /// </summary>
    public partial class UserControlJoue : UserControl
    {


        public Héros Héros //Héros transmi par la fenêtre NavBar
        {
            get { return (Héros)GetValue(HérosProperty); }
            set { SetValue(HérosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Héros.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HérosProperty =
            DependencyProperty.Register("Héros", typeof(Héros), typeof(UserControlJoue), new PropertyMetadata(default(Héros))); //Dependency Property utile aux bindings


        public UserControlJoue()
        {
            InitializeComponent();
        }

        private void Modifier_Click(object sender, RoutedEventArgs e) //Bouton qui sert à ouvrir la fenêtre de modification
        {
            var modifierChoix = new ModiferChoix();
            modifierChoix.ShowDialog();
        }
    }
}
