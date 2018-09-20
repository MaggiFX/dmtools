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
using LiteDB;

namespace dmtools
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Setup();
        }

        public void Setup()
        {

        }

        private void Btn_NeuerGegenstand(object sender, RoutedEventArgs e)
        {
            ErstellungGegenstand fenster = new ErstellungGegenstand();
            fenster.Show();
        }

        private void Btn_NeuerGegenstandJson(object sender, RoutedEventArgs e)
        {
            ErstellungGegenstandJson fenster = new ErstellungGegenstandJson();
            fenster.Show();
        }

        private void Btn_NeuerOrt(object sender, RoutedEventArgs e)
        {
            ErstellungOrt fenster = new ErstellungOrt();
            fenster.Show();
        }

        private void SucheGegenstand(object sender, RoutedEventArgs e)
        {
            ErgebnisseGegenstand.Items.Clear();

            string suchName = SuchName.Text;
            int suchMinWert;
            int suchMaxWert;

            if (SuchMinWert.Text.Length == 0)
                suchMinWert = 0;
            else
                suchMinWert = Convert.ToInt32(SuchMinWert.Text);

            if (SuchMaxWert.Text.Length == 0)
                suchMaxWert = Int32.MaxValue;
            else
                suchMaxWert = Convert.ToInt32(SuchMaxWert.Text);

            using (var db = new LiteDatabase(@"Datenbank.db"))
            {
                var gegenstände = db.GetCollection<Gegenstand>("gegenstände");

                var suchquery = gegenstände.Find(
                    x => (x.Name ?? string.Empty).ToLower().Contains((suchName ?? string.Empty).ToLower())
                    && x.Wert >= suchMinWert
                    && x.Wert <= suchMaxWert
                    );

                foreach (var i in suchquery)
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

        private void Btn_Würfeln(object sender, RoutedEventArgs e)
        {
            if(RB_Custom.IsChecked == true)
            {
                try
                {
                    Würfler.Würfelmenge = Convert.ToInt32(TB_CustomRoll.Text.Substring(0, TB_CustomRoll.Text.IndexOf("d")));
                    Würfler.Würfelart = Convert.ToInt32(TB_CustomRoll.Text.Substring(TB_CustomRoll.Text.IndexOf("d") + 1));
                }
                catch
                {
                    MessageBoxResult hinweis = MessageBox.Show("Schreibweise: 0d0");
                }
            }
            else
            {
                foreach (RadioButton cycle in RB_DiceCount.Children)
                {
                    if (cycle.IsChecked == true)
                    {
                        Würfler.Würfelmenge = Convert.ToInt32(cycle.Content);
                    }
                }

                foreach (RadioButton cycle in RB_DiceKind.Children)
                {
                    if (cycle.IsChecked == true)
                    {
                        Würfler.Würfelart = Convert.ToInt32(cycle.Content.ToString().Substring(1));
                    }
                }
            }

            TB_RollResult.Text = Würfler.Roll(Würfler.Würfelmenge, Würfler.Würfelart);
            Würfler.Würfelmenge = 1;
            Würfler.Würfelart = 1;
        }
    }
}
