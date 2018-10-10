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
    /// Interaktionslogik für ErstellungGegenstand.xaml
    /// </summary>
    public partial class ErstellungGegenstand : Window
    {

        public ErstellungGegenstand()
        {
            InitializeComponent();
        }

        private void Abbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Erstellen_Click(object sender, RoutedEventArgs e)
        {
            var neu = new Gegenstand();

            neu.Id = Datenbank.CountGegenstand() + 1;

            neu.Name = TB_Name.Text;
            neu.Wert = Convert.ToInt32(TB_Wert.Text);
            neu.Gewicht = Convert.ToDouble(TB_Gewicht.Text);
            neu.Seltenheit = SB_Seltenheit.Text;
            neu.Beschreibung = new TextRange(TB_Beschreibung.Document.ContentStart, TB_Beschreibung.Document.ContentEnd).Text;

            Datenbank.Add(neu);

            this.Close();
        }
    }
}
