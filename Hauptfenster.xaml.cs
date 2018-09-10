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
//using Newtonsoft.Json;
using LiteDB;

namespace dmtools
{
    static class Datenbank
    {
        public static void AddGegenstand(Gegenstand input)
        {
            using (var db = new LiteDatabase(@"Datenbank.db"))
            {
                var gegenstände = db.GetCollection<Gegenstand>("gegenstände");

                var prüfung = gegenstände.Find(Query.EQ("Name", input.Name));

                if (prüfung.Any())
                {
                    var err = MessageBox.Show("Itemname bereits vergeben");
                }
                else
                {
                    gegenstände.Insert(input);
                }

                
            }
        }

        public static void AddWaffe(Waffe input)
        {
            using (var db = new LiteDatabase(@"Datenbank.db"))
            {
                var waffen = db.GetCollection<Waffe>("waffen");
                waffen.Insert(input);
            }
        }

    }

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Gegenstand affe = new Gegenstand("Test");

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

            Waffe item1 = new Waffe("Arcanite Reaper");
            Waffe item2 = new Waffe("Frostmourne");
            Gegenstand item3 = new Gegenstand("Doomhammer");
            Waffe item4 = new Waffe("Ashbringer");
            Gegenstand item5 = new Gegenstand("Atiesh");

            Datenbank.AddGegenstand(item1);


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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ErstellungGegenstand fenster = new ErstellungGegenstand();

            fenster.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
