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
    /// Logique d'interaction pour AjouterHéros.xaml
    /// </summary>
    public partial class AjouterHéros : Window
    {
        public Manager Manager => (App.Current as App).Manager; //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App

        public Héros LeHéros { get; set; } //Attribut du nouveau Héros.
        public AjouterHéros()
        {
            InitializeComponent();
            var h = new Héros("", "/img/Ana.png", TypeClasse.Healer); //Création d'un nouvel Héros vide avec une image basique.
            DataContext = this;
            LeHéros = new Héros(h.Prénom, h.Image,h.Classe); //Création du nouveau Héros a partir du Héros vide.
        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            string classe = comboboxclasse.Text; //Récupère la partie sélectionné dans la comboBox
            if (classe == "Dps")
            {
                LeHéros.ModifierClasse(TypeClasse.DPS); //Modifie la classe selon le type choisi
            }
            else if (classe == "Tank")
            {
                LeHéros.ModifierClasse(TypeClasse.Tank); //Modifie la classe selon le type choisi
            }
            else if (classe == "Heal")
            {
                LeHéros.ModifierClasse(TypeClasse.Healer); //Modifie la classe selon le type choisi
            }
            Manager.AjouterHéros(new Héros(LeHéros.Prénom, LeHéros.Image, LeHéros.Classe)); //Ajoute le Héros dans la liste du Manager.
            Close(); //Fermeture de la fenêtre
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close(); //Fermeture de la fenêtre sans modification.
        }

        /// <summary>
        /// Permet la navigation pour importer une nouvelle image dont l'extension correspond à celle de dlg.Filter. Le chemin de l'image est ensuite placé dans l'attribut Image du nouveau Héros.
        /// Il y a aussi la création de l'image au format Bitmap
        /// </summary>
        private void Parcourir_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.FileName = "Images"; // Default file name
            dlg.DefaultExt = ".jpg | .png | .gif"; // Default file extension
            dlg.Filter = "All images files (.jpg, .png, .gif)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png|GIF files (.gif)|*.gif"; // Filter files by extension 

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                new BitmapImage(new Uri(filename, UriKind.Absolute));
                LeHéros.Image = filename;
            }
        }
    }
}
