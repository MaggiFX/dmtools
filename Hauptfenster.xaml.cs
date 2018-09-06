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
using System.IO;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Driver;

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
            MongoDatenbank();
        }

        private void LadeAbenteuer()
        {

        }

        private void NeuesAbenteuer()
        {

        }

        private void Demo()
        {
            var testabenteuer = new Abenteuer("WoW");
            var testwelt = new Welt("Azeroth");
            var testwelt2 = new Welt("Draenor");
            var testkontinent = new Kontinent("Kalimdor");
            var testland = new Land("Durotan");
            var teststadt = new Stadt("Ogrimmar");
            var testpoi = new Poi("Ragefire Chasm");

            teststadt.POIS.Add(testpoi);
            testland.Städte.Add(teststadt);
            testkontinent.Länder.Add(testland);
            testwelt.Kontinente.Add(testkontinent);
            testabenteuer.Welten.Add(testwelt);
            testabenteuer.Welten.Add(testwelt2);

            JsonSerializer jser = new JsonSerializer();
            jser.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"test.json"))
            using (JsonWriter writa = new JsonTextWriter(sw))
            {
                jser.Serialize(writa, testabenteuer);
            }

        }

        private void MongoDatenbank()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("itemdb");
            var itemCollection = db.GetCollection<Item>("items", null);

            db.DropCollection("items");

            Item hanswurst = new Item("Hans Wurst");

        itemCollection.InsertOne(hanswurst);
        }
}
}
