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

                if (gegenstände.Find(Query.EQ("Name", input.Name)).Any())
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
