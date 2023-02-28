using TP_Notion_POO.Extension;
using TP_Notion_POO.Model;

Console.WriteLine("Application Gestion de Scolarité");

List<Professeur> professeurs = new List<Professeur>();

void ShowProfGenre(string genre)
{
    foreach (Professeur p in professeurs)
    {
        Console.WriteLine(p.ToString(genre, p.findbyGenre));
    }
}



Professeur professeur = new Professeur(1, "MANI", "Mohammed", "Web");
Etudiant E1 = new Etudiant(1,"FRIKAL","Ahmed","Homme","+212670936346");
Etudiant E2 = new Etudiant(2, "FRIKAL", "Issam", "Homme", "+212670936346");
Etudiant E3 = new Etudiant(3, "FRIKAL", "Ibtissam", "Femme", "+212670936346");
professeur.AjouterEtudiant(E1);
professeur.AjouterEtudiant(E2);
professeur.AjouterEtudiant(E3);
//Prof 2
Professeur professeur1 = new Professeur(2, "SALHI", "Khalid", "Multimedia");
Etudiant E4 = new Etudiant(4, "IKRAM", "IKRAM", "Femme", "+212670936346");
Etudiant E5 = new Etudiant(5, "IKRAM", "ilham", "Femme", "+212670936346");
Etudiant E6 = new Etudiant(6, "Dounia", "Dounia", "Femme", "+212670936346");
professeur1.AjouterEtudiant(E4);
professeur1.AjouterEtudiant(E5);
professeur1.AjouterEtudiant(E6);
//Prof 3
Professeur professeur2 = new Professeur(3, "Latifa", "latifa", "base de donnes");
Etudiant E7 = new Etudiant(7, "Soufianr", "Soufiane", "Homme", "+212670936346");
Etudiant E8 = new Etudiant(8, "Abdou", "abdou", "Homme", "+212670936346");
Etudiant E9 = new Etudiant(9, "Manal", "Manal", "Femme", "+212670936346");

professeur2.AjouterEtudiant(E7);
professeur2.AjouterEtudiant(E8);
professeur2.AjouterEtudiant(E9);
//Console.WriteLine(E1.Tostring());
//ADD Professeurs
professeurs.Add(professeur);
professeurs.Add(professeur2);
professeurs.Add(professeur1);
Console.WriteLine("\n--- c ---\n");
ShowProfGenre(null);
Console.WriteLine("\n--- d ---\n");
ShowProfGenre("Homme");
Console.WriteLine("\n---- e ----- \n");
professeur.SuprimerEtudiant(3);
ShowProfGenre(null);
professeur2.Vider();
Console.WriteLine("\n----- h---- \n");
ShowProfGenre(null);
Console.WriteLine("\n----- i-----  \n");
professeur.etudiants.Show();
Console.WriteLine("\n -- Have Fix --  \n");


List<Etudiant> et = new List<Etudiant>();

et=professeur1.etudiants.Where((etudiant) => { return etudiant.nom == "IKRAM"; }).ToList();

Console.WriteLine(et.Count);









