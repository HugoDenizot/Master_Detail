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
    /// Logique d'interaction pour AjouterEmotes.xaml
    /// </summary>
    public partial class AjouterEmotes : Window
    {
        public Manager Manager => (App.Current as App).Manager; //Instanciation d'un manager qui fait lien avec celui instancié dans la fenêtre App.
        public Emote LEmote { get; set; } //Nom de la nouvelle Emote à ajouter.
        public AjouterEmotes()
        {
            InitializeComponent();
            var e = new Emote("", "vidéo/Fusil Bionique.mp4", ""); //Création d'une emote de base avec une vidéo basique.
            LEmote = new Emote(e.Nom, e.VideoNom, e.Description); //On remplace ces champs dans ce de l'Emote que l'on va utiliser.
            DataContext = this;
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close(); //On ferme la fenêtre sans mofication.
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            if (Manager.AjouterEmote(new Emote(LEmote.Nom, LEmote.VideoNom, LEmote.Description), Manager.HérosSelectionné))
            {
                MessageBox.Show("Le skin a été ajouté", "Ajout de skin",MessageBoxButton.OK, MessageBoxImage.Information);
            };
            Close();
        }
        /// <summary>
        /// Bouton parcourir qui lorsqu'on appuie dessus, ouvre une fenêtre qui va chercher un fichier de type vidéo dont l'extension correspond à celle ci dessous dans dlg.Filter. Il remplace ensuite le string de la vidéo de l'emote par le chemin de la vidéo.
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
                LEmote.VideoNom = filename;
            }
        }
    }
}
