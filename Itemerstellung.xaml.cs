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
using System.Windows.Shapes;

namespace dmtools
{
    /// <summary>
    /// Interaktionslogik für Itemerstellung.xaml
    /// </summary>
    public partial class Itemerstellung : Window
    {
        public Itemerstellung()
        {
            InitializeComponent();
        }

        private void Abbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Erstellen_Click(object sender, RoutedEventArgs e)
        {
            MyThing.ItemListe.Add(new Item("Test"));

            //this.TB_ItemName.Text

            

            this.Close();
        }
    }
}
