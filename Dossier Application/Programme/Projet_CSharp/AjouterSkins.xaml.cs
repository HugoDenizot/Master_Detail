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
    /// Logique d'interaction pour AjouterSkins.xaml
    /// </summary>
    public partial class AjouterSkins : Window
    {
        public Manager Manager => (App.Current as App).Manager; //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App
        public Skin LeSkin { get; set; } //Attribut correspondant au nouveau Skin
        public AjouterSkins()
        {
            InitializeComponent();
            var s = new Skin("", "/img/Ana.png",""); //Création d'un skin vide avec une image basique.
            LeSkin = new Skin(s.Nom, s.ImageNom, s.Description); //Création du nouveau skin.
            DataContext = this;
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {         
            Close(); //Fermeture sans modification
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Manager.AjouterSkin(new Skin(LeSkin.Nom, LeSkin.ImageNom, LeSkin.Description),Manager.HérosSelectionné); //Ajout du Skin au Héros Sélectionné.
            Close(); //Fermeture de la fenêtre.
        }

        /// <summary>
        /// Permet la navigation pour importer une nouvelle image dont l'extension correspond à celle de dlg.Filter. Le chemin de l'image est ensuite placé dans l'attribut Image du nouveau Skin.
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
                LeSkin.ImageNom = filename;
            }
        }
    }
}
