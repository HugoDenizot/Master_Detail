using Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Projet_CSharp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       public Manager Manager { get; private set; } = new Manager(new JsonPersistanceManager()); //Instanciation du Manager qui utilise la persistance Json.

        public App()
        {
            Manager.ChargeDonnées(); //Au lancement de l'application, Charge les données du fichier BDD.Json
        }
    }
}
