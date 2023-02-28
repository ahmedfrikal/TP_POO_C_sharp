using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TP_Notion_POO.Extension;

namespace TP_Notion_POO.Model
{
    internal class Professeur
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string specialté { get; set;}
        public List<Etudiant> etudiants { get; set;}

        public Professeur(){ }
        public Professeur(int id,string nom,string prenom,string specialté)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.specialté = specialté;
            etudiants = new List<Etudiant>();
        }
        public void AjouterEtudiant(Etudiant etudiant)
        {
            etudiants.Add(etudiant);
        }
        public void SuprimerEtudiant(int id)
        {
            foreach(Etudiant e in etudiants)
            {
                if (e.id == id)
                {
                    etudiants.Remove(e);
                    break;
                }
            }
        }
        public  IEnumerable <Etudiant> findbyGenre(String genre)
        {
            foreach(Etudiant e in etudiants)
            {
                if (genre == null)
                {
                    yield return e;
                }
                else if (e.genre == genre)
                {
                  
                    yield return e; 
                }
            }   
        }
        public  string ToString(string genre, Func<string, IEnumerable<Etudiant>> func)
        {
            string etudiant = null;
            foreach (var e in func(genre))
            {
                etudiant+=e.ToString();
            }

            return "********Professeur \n " +
               "Nom :" + this.nom + "\n" + "Prenom :" + this.prenom + "\n" +
               "Specialité :" + this.specialté + "\n" + "----------------- \n" +
               "Etudiants :\n" + etudiant;
                       
        }

      
        public bool compare(List<Etudiant> etudiants, string condition)
        {
            bool temoin = false;
            foreach (Etudiant e in etudiants)
            {
                if (e.nom==condition)
                {
                   temoin=true;
                }
            }
            return temoin;
        }

        
    }
}
