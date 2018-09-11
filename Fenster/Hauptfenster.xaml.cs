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

                if (gegenstände.Find(Query.Contains("Name", input.Name.ToLower())).Any())
                {
                    var err = MessageBox.Show("Itemname bereits vergeben");
                }
                else
                {
                    gegenstände.Insert(input);
                }
            }
        }
    }

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            TESTING();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ErstellungGegenstand fenster = new ErstellungGegenstand();

            fenster.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void TESTING()
        {

        }

        private void SucheGegenstand(object sender, RoutedEventArgs e)
        {
            ErgebnisseGegenstand.Items.Clear();

            if(SuchName.Text.Length == 0)
            {
                
            }
            else
            {
                using (var db = new LiteDatabase(@"Datenbank.db"))
                {
                    var gegenstände = db.GetCollection<Gegenstand>("gegenstände");

                    var r = gegenstände.Find(Query.Or(
                    Query.Contains("Name", SuchName.Text.ToLower()),
                    Query.Contains("Name", SuchName.Text.Substring(0, 1).ToUpper() + SuchName.Text.Substring(1))
                    ));

                    //var result = gegenstände.Find(Query.Contains("Name", SuchName.Text));

                    foreach (var i in r)
                    {
                        ErgebnisseGegenstand.Items.Add(new Gegenstand
                        {
                            Name = i.Name,
                            Wert = i.Wert,
                            Gewicht = i.Gewicht,
                            Seltenheit = i.Seltenheit,
                            Beschreibung = i.Beschreibung
                        });
                    }
                }
            }
        }
    }
}
