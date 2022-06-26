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
using Modele;

namespace Projet_CSharp
{
    /// <summary>
    /// Logique d'interaction pour Competences.xaml
    /// </summary>
    public partial class Competences : UserControl
    {
        public Héros Héros //Prends le Héros donnés par la fenêtre NavBar.
        {
            get { return (Héros)GetValue(HérosProperty); }
            set { SetValue(HérosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Héros.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HérosProperty =
            DependencyProperty.Register("Héros", typeof(Héros), typeof(Competences), new PropertyMetadata(default(Héros))); //Dépendency property qui sert au Binding.

        public Competences()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Bouton servant à afficher les compétences telquel
        {
            displayPassif.Visibility = Visibility.Collapsed;
            editPassif.Visibility = Visibility.Visible;

            displayCompetence1.Visibility = Visibility.Collapsed;
            editCompetence1.Visibility = Visibility.Visible;

            displayCompetence2.Visibility = Visibility.Collapsed;
            editCompetence2.Visibility = Visibility.Visible;

            displayUltimate.Visibility = Visibility.Collapsed;
            editUltimate.Visibility = Visibility.Visible;


        }
        private void Button_ClickAnnule(object sender, RoutedEventArgs e) //Bouton servant à afficher les compétences pour que l'on puisse les modifier.
        {
            displayPassif.Visibility = Visibility.Visible;
            editPassif.Visibility = Visibility.Collapsed;

            displayCompetence1.Visibility = Visibility.Visible;
            editCompetence1.Visibility = Visibility.Collapsed;

            displayCompetence2.Visibility = Visibility.Visible;
            editCompetence2.Visibility = Visibility.Collapsed;

            displayUltimate.Visibility = Visibility.Visible;
            editUltimate.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// Bouton parcourir qui lorsqu'on appuie dessus, ouvre une fenêtre qui va chercher un fichier de type vidéo dont l'extension correspond à celle ci dessous dans dlg.Filter. Il remplace ensuite le string de la vidéo des compétence par le chemin de la vidéo.
        /// </summary>
        private void ModifierVideo_Click(object sender, RoutedEventArgs e)
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
                Héros.SesCompétences.Vidéo = filename;
            }
        }
    }
}
