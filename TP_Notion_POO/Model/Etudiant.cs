using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Notion_POO.Model
{
    internal class Etudiant 
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string genre { get; set; }
        public string tel { get; set; }

        public Etudiant() { }
        public Etudiant(int id,string nom,string prenom,string genre, string tel)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.genre = genre;
            this.tel = tel;
        }

        public string ToString()
        {
            return "Etudiant \n "+
                   "Nom :" + this.nom + "\n" + "Prenom :" + this.prenom + "\n"+
                   "Genre :" + genre + "\n Telephone " + "" + tel + "\n";
        }
       
    }
}
