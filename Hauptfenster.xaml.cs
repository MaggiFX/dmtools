using System;
using System.Collections.Generic;
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
using Newtonsoft.Json;
using LiteDB;

namespace dmtools
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //LadeAbenteuer();
            //NeuesAbenteuer();
            //Demo();
        }

        private void LadeAbenteuer()
        {

        }

        private void NeuesAbenteuer()
        {

        }

        private void Demo()
        {
            Abenteuer testabenteuer = new Abenteuer("World of Warcraft");
            Welt testwelt = new Welt("Azeroth");
            Kontinent testkontinent = new Kontinent("Kalimdor");
            Land testland = new Land("Durotan");
            Stadt teststadt = new Stadt("Ogrimmar");
            Poi testpoi = new Poi("Ragefire Chasm");

            
        }
    }
}
