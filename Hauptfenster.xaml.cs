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
using System.Data.SQLite;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace dmtools
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //LadeAbenteuer();
            //NeuesAbenteuer();
            Demo();
        }

        private void LadeAbenteuer()
        {

        }

        private void NeuesAbenteuer()
        {

        }

        private void Demo()
        {
            var testabenteuer   = new Abenteuer ("World of Warcraft");
            var testwelt        = new Welt      ("Azeroth");
            var testwelt2       = new Welt      ("Draenor");
            var testkontinent   = new Kontinent ("Kalimdor");
            var testland        = new Land      ("Durotan");
            var teststadt       = new Stadt     ("Ogrimmar");
            var testpoi         = new Poi       ("Ragefire Chasm");

            teststadt.POIS.Add(testpoi);
            testland.Städte.Add(teststadt);
            testkontinent.Länder.Add(testland);
            testwelt.Kontinente.Add(testkontinent);
            testabenteuer.Welten.Add(testwelt);
            testabenteuer.Welten.Add(testwelt2);

            var ser = new XmlSerializer(typeof(Abenteuer));

            var writer = new StreamWriter("hase.xml");
            ser.Serialize(writer, testabenteuer);
            writer.Close();

        }
    }
}
