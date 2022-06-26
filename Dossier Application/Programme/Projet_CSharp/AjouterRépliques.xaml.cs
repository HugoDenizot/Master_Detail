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
    /// Logique d'interaction pour AjouterRépliques.xaml
    /// </summary>
    public partial class AjouterRépliques : Window
    {
        public Manager Manager => (App.Current as App).Manager; //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App
        public Réplique LaRéplique { get; set; } //Attribut correspondant à la nouvelle réplique.
        public AjouterRépliques()
        {
            InitializeComponent();
            var r = new Réplique("", "vidéo/Fusil Bionique.mp4", ""); //Réplique vide avec vidéo de base.
            LaRéplique = new Réplique(r.Nom, r.VideoNom, r.Description); //Création de la nouvelle réplique.
            DataContext = this;
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close(); //Fermeture sans modification.
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Manager.AjouterRéplique(new Réplique(LaRéplique.Nom, LaRéplique.VideoNom, LaRéplique.Description),Manager.HérosSelectionné);//Ajout de la réplique au Héros Selectionné.
            Close(); //fermeture de la fenêtre.
        }
        /// <summary>
        /// Bouton parcourir qui lorsqu'on appuie dessus, ouvre une fenêtre qui va chercher un fichier de type vidéo dont l'extension correspond à celle ci dessous dans dlg.Filter. Il remplace ensuite le string de la vidéo de la réplique par le chemin de la vidéo.
        /// </summary>
        private void Parcourir_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.FileName = "Videos"; // Default file name
            dlg.DefaultExt = ".mp4 | .mkv | .avi"; // Default file extension
            dlg.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                LaRéplique.VideoNom = filename;
            }
        }
    }
}
