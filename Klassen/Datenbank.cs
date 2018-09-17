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
        public static void AddGegenstand(Gegenstand input)
        {
            using (var db = new LiteDatabase(@"Datenbank.db"))
            {
                //db.Engine.EnsureIndex("gegenstände", "Name");

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
}
