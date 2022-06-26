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
    /// Logique d'interaction pour ModiferChoix.xaml
    /// </summary>
    public partial class ModiferChoix : Window
    {
        public Manager Manager => (App.Current as App).Manager;  //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App
        public ModiferChoix()
        {
            InitializeComponent();
            DataContext = Manager;
        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            Close(); //Ferme la fenêtre avec les modifications.
        }
    }
    
}
