
using Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Manager Manager =>(App.Current as App).Manager;  //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App
        public MainWindow()
        {

            InitializeComponent();
            DataContext = Manager;
            accueil.Visibility = Visibility.Visible; //Affiche l'accueil
            navbar.Visibility = Visibility.Collapsed; //Cache la navBar au lancement
        }

        public void App_Closing(Object sender, CancelEventArgs e) //Quand la MainWindow est fermé, le programme sauvegarde les données dans le fichier BDD.Json
        {
            Manager.SauvegardeDonnées();
        }

        private void Grid_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        private void NavBar_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Ajouter_Click(object sender, RoutedEventArgs e) //Bouton qui ouvre la fenêtre pour ajouter un Héros
        {
            var AjouterHéros = new AjouterHéros();
            AjouterHéros.ShowDialog();
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e) //Bouton qui ouvre la fenêtre pour supprimer un Héros
        {
            var supprimerHéros = new Supprimer_Héros();
            supprimerHéros.ShowDialog();
        }

        private void Accueil_Click(object sender, RoutedEventArgs e) //Bouton qui affiche l'accueil et pas la navBar
        {
            accueil.Visibility = Visibility.Visible;
            navbar.Visibility = Visibility.Collapsed;
        }

        private void Detail_Click(object sender, RoutedEventArgs e) //Bouton qui affiche la NavBar(Le détail)
        {
            accueil.Visibility = Visibility.Collapsed;
            navbar.Visibility = Visibility.Visible;
        }

        private void LesHéros_SelectionChanged(object sender, SelectionChangedEventArgs e) //Méthode servant à faire correspondre le Héros sélectionné dans la listeBox et le HérosSelectionné du Manager.
        {
            Manager.HérosSelectionné = e.AddedItems[0] as Héros;
        }
    }

    
}
