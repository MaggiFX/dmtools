using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using System.IO;
using System.Windows;

namespace dmtools
{
    static class Datenbank
    {
        public static void Add(Gegenstand input)
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

        public static void Add(Charakter input)
        {
            using (var db = new LiteDatabase(@"Datenbank.db"))
            {
                var charaktere = db.GetCollection<Charakter>("charaktere");

                if (charaktere.Find(Query.Contains("Name", input.Name.ToLower())).Any())
                {
                    var err = MessageBox.Show("Itemname bereits vergeben");
                }
                else
                {
                    charaktere.Insert(input);
                }
            }
        }

        public static int CountGegenstand()
        {
            using (var db = new LiteDatabase(@"Datenbank.db"))
            {
                var gegenstände = db.GetCollection<Gegenstand>("gegenstände");

                return gegenstände.Count();
            }
        }

        public static int CountCharakter()
        {
            using (var db = new LiteDatabase(@"Datenbank.db"))
            {
                var charaktere = db.GetCollection<Charakter>("charaktere");

                return charaktere.Count();
            }
        }
    }
}
