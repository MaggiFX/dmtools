using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace dmtools
{
    /// <summary>
    /// Interaktionslogik für ErstellungGegenstandJson.xaml
    /// </summary>
    public partial class ErstellungGegenstandJson : Window
    {
        public ErstellungGegenstandJson()
        {
            InitializeComponent();
        }

        private void Btn_Erstellen(object sender, RoutedEventArgs e)
        {

            using (JsonTextReader reader = new JsonTextReader(new StringReader(JsonBox.Text)))
            {

            }




            this.Close();
        }

        private void Btn_Abbrechen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
