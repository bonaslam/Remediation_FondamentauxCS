using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionsCS
{
    class ExercicesListeClasses
    {
        /// <summary>
        /// Affiche 
        ///     - la somme, 
        ///     - le nombre de moyennes 
        ///     - la moyenne des moyennes des étudiants
        /// présents dans la liste
        /// </summary>
        public static void ParcoursCollectionClasseSomme()
        {
            // instanciation de la Liste
            List<Etudiant> etudiants = InitialiseEtudiants();
           
            // On va parcourir la liste et calculer la moyenne
            double somme = 0;
            foreach (Etudiant etudiant in etudiants)
            {
                somme += etudiant.Moyenne;
            }
            Console.WriteLine("somme des notes : {0}", somme);
            Console.WriteLine("nombre de notes : {0}", etudiants.Count);
            Console.WriteLine("moyenne de notes : {0}", somme / etudiants.Count);
        }

        /// <summary>
        /// recherche et affiche la moyenne la plus basse des étudiants
        /// présents dans la liste
        /// </summary>
        public static void ParcoursCollectionClassePlusPetit()
        {
            // initialisation de la liste
            List<Etudiant> etudiants = InitialiseEtudiants();

           
            // On va parcourir la liste et calculer la moyenne
            double mini = etudiants.ElementAt(0).Moyenne;
            for (int i = 0; i < etudiants.Count; i++)
            {
                if (etudiants.ElementAt(i).Moyenne < mini)
                {
                    mini = etudiants.ElementAt(i).Moyenne;
                }
            }
            Console.WriteLine("moyenne la plus basse : {0}", mini);
        }

        /// <summary>
        /// Recherche un étudiant dans la liste par son nom.
        /// </summary>
        /// <param name="nomEtudiant">Nom de l'étudiant à chercher </param>
        public static void ParcoursCollectionClasseRecherche(String nomEtudiant)
        {
            // initialisation de la liste
            List<Etudiant> etudiants = InitialiseEtudiants();
            // 
            
            int i = 0;
            while (i < etudiants.Count && etudiants.ElementAt(i).Nom!=nomEtudiant)
            {
                // on se décale de 1 dans le tableau
                i++;
            }
            // on doit tester comment on est sortis de la boucle !
            if (i < etudiants.Count)
            {
                Console.WriteLine("l'étudiant {0} est présent dans le tableau à la position {1}", nomEtudiant, i);
            }
            else
            {
                Console.WriteLine("l'étudiant {0} n'est pas présent dans le tableau", nomEtudiant);
            }


        }
        /// <summary>
        /// Recherche un étudiant dans la liste par son nom et affiche ses coordonnées.
        /// </summary>
        /// <param name="nomEtudiant">Nom de l'étudiant à chercher </param>
        public static void ParcoursCollectionClasseRechercheV2(String nomEtudiant)
        {
            // initialisation de la liste
            List<Etudiant> etudiants = InitialiseEtudiants();
            
            int i = 0;
            while (i < etudiants.Count && etudiants.ElementAt(i).Nom != nomEtudiant)
            {
                // on se décale de 1 dans le tableau
                i++;
            }
            // on doit tester comment on est sortis de la boucle !
            if (i < etudiants.Count)
            {
                Console.WriteLine("l'étudiant {0} est présent dans le tableau à la position {1}", etudiants.ElementAt(i), i);
            }
            else
            {
                Console.WriteLine("l'étudiant {0} n'est pas présent dans le tableau", nomEtudiant);
            }

        }

        /// <summary>
        /// retourner la liste des étudiants de l'option passée en paramètre
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static List<Etudiant> ListeEtudiantParOption(String opt)
        {
            // on initialise la liste des étudiants dans laquelle nous allons chercher les étudiants de l'option
            List<Etudiant> etudiants = InitialiseEtudiants();
            // on initialise la liste à retourner
            List<Etudiant> optionEtudiants = new List<Etudiant>();
            //Parcours de la liste
            foreach(Etudiant etudiant in etudiants)
            {
                // on teste si l'étudiant que l'on vient de récupérer dans la liste est de l'option passée en paramètre
                if (etudiant.Option == opt)
                {
                    // l'étudiant est de l'option cherchée, on le rajoute dans la liste à retourner.
                    optionEtudiants.Add(etudiant);
                }
            }
            // on renvoie la liste des étudiants de l'option
            return optionEtudiants;
        }


        private static List<Etudiant> InitialiseEtudiants()
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            // initialisation de la liste
            etudiants.Add(new Etudiant("Martin ", "SLAM", 12.3));
            etudiants.Add(new Etudiant("Bernard", "SISR", 10.5));
            etudiants.Add(new Etudiant("Thomas", "SLAM", 13.9));
            etudiants.Add(new Etudiant("Petit", "SLAM", 9.6));
            etudiants.Add(new Etudiant("Robert", "SISR", 7.8));
            etudiants.Add(new Etudiant("Richard", "SLAM", 14.1));
            etudiants.Add(new Etudiant("Moreau", "SISR", 13.9));
            etudiants.Add(new Etudiant("Morel", "SLAM", 12.7));
            etudiants.Add(new Etudiant("Lambert", "SLAM", 14.1));
            etudiants.Add(new Etudiant("Dupont", "SLAM", 10.5));
            etudiants.Add(new Etudiant("Duval", "SLAM", 11.5));
            etudiants.Add(new Etudiant("Blanchard", "SISR", 9.2));
            etudiants.Add(new Etudiant("Meunier", "SLAM", 10.5));
            return etudiants;
        }

    }
}
