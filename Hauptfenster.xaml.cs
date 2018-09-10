﻿using System;
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
        
    }

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Item affe = new Item("Test");

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
        }

        private void MongoDatenbank()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Itemerstellung fenster = new Itemerstellung();

            fenster.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.ItemBox.ItemsSource = Datenbank.ItemListe;
        }
    }
}
