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
    /// Logique d'interaction pour Histoire.xaml
    /// </summary>
    public partial class Histoire : UserControl
    {

        public Héros Héros //Héros donnée par la fenêtre NavBar
        {
            get { return (Héros)GetValue(HérosProperty); }
            set { SetValue(HérosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Héros.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HérosProperty =
            DependencyProperty.Register("Héros", typeof(Héros), typeof(Histoire), new PropertyMetadata(default(Héros))); //Dependency Property qui sert pour le binding

        public Histoire()
        {
            InitializeComponent();

            displayBio.Visibility = Visibility.Visible; //Affiche la Textblock de la biographie
            editBio.Visibility = Visibility.Collapsed; //Cache la textBox de l'edit de la biographie
            editLien.Visibility = Visibility.Collapsed; //Cache la textbox du lien
        }
        private void Modifier(object sender, RoutedEventArgs e) //Affiche les TextBox cachées et cache la TextBlock
        {
            displayBio.Visibility = Visibility.Collapsed;
            editBio.Visibility = Visibility.Visible;
            editLien.Visibility = Visibility.Visible;
        }

        private void Enregistrer(object sender, RoutedEventArgs e) //Affiche seulement la textblock et cache les TextBox
        {
            displayBio.Visibility = Visibility.Visible;
            editBio.Visibility = Visibility.Collapsed;
            editLien.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Permet la navigation pour importer une nouvelle image dont l'extension correspond à celle de dlg.Filter. Le chemin de l'image est ensuite placé dans l'attribut Miniature de l'Histoire.
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
                Héros.Histoire.Miniature = filename;
            }
        }
    }
}
