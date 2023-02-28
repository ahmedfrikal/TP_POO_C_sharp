using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Notion_POO.Model;

namespace TP_Notion_POO.Extension
{
    internal static class MyExt
    {
        public static void Vider(this Professeur professeur4)
        {
            professeur4.etudiants.Clear();
        }
        public static void Show(this List<Etudiant> etudiants)
        {
            foreach(Etudiant e in etudiants)
            {
              Console.WriteLine(e.ToString());
            }
            
        }

        public static List<Etudiant> HaveFix(this Professeur prof ,string prenom)
        {
            List<Etudiant> list = new List<Etudiant>();
            foreach(Etudiant e in prof.etudiants)
            {
                if (e.nom == prenom)
                {
                 list.Add(e);
                }
            }
            return list;
        }

        public static IEnumerable<Etudiant> where(this List<Etudiant> source, Predicate<Etudiant> func)
        {
            //List<Etudiant> etu = new List<Etudiant>();
            foreach (Etudiant sourceItem in source)
            {
                if (func(sourceItem))
                {
                    yield return sourceItem;
                }
            }
        }

    }
}
