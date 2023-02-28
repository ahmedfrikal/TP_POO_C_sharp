using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Notion_POO.Model
{
    internal class Perssone
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }

        public Perssone()
        {

        }
        public Perssone(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public string Tostring()
        {
            return "Nom :"+this.nom+"\n"+"Prenom :"+this.prenom+"\n";
        }
    }
}
