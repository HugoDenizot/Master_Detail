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
    /// Logique d'interaction pour AjouterTags.xaml
    /// </summary>
    public partial class AjouterTags : Window
    {
        public Manager Manager => (App.Current as App).Manager; //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App

        public Tag LeTag { get; set; } //Attribut correspondant au nouveau tag.
        public AjouterTags()
        {
            InitializeComponent();
            var t = new Tag("", "/img/Ana.png", ""); //Création d'un tag vide.
            LeTag = new Tag(t.Nom, t.ImageNom, t.Description); //Création du nouveau tag.
            DataContext = this;
        }


        /// <summary>
        /// Permet la navigation pour importer une nouvelle image dont l'extension correspond à celle de dlg.Filter. Le chemin de l'image est ensuite placé dans l'attribut Image du nouveau Tag.
        /// Il y a aussi la création de l'image au format Bitmap
        /// </summary>
        private void Parcourir(object sender, RoutedEventArgs e)
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
                LeTag.ImageNom = filename;
            }
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close(); //Fermeture sans modification.
        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            Manager.AjouterTag(new Tag(LeTag.Nom, LeTag.ImageNom, LeTag.Description),Manager.HérosSelectionné); //Ajout du tag au Héros.
            Close(); //Fermeture
        }
    }
}
