using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionsCS
{
    internal static class ExercicesListes
    {
        // affiche la somme des notes et leur moyenne
        public static void ParcoursListeSomme()
        {
            // instanciation d'une liste (collection d'entiers)
            List<int> notes = new List<int>();
            // ajout des éléments dans la liste.
            notes.Add(12);
            notes.Add(15);
            notes.Add(5);
            notes.Add(4);
            notes.Add(9);
            notes.Add(11);
            notes.Add(16);
            notes.Add(20);
            int somme = 0;
            // boucle foreach car on doit parcourir tout le tableau.
            foreach (int note in notes)
            {
                somme = somme + note;  // ou somme +=note;
            }
            Console.WriteLine("somme des notes : {0}", somme);
            Console.WriteLine("nombre de notes : {0}", notes.Count);
            // on caste la division sinon le compilateur fait une division entière et affiche 11
            // on aurait aussi pu créer une variable :
            // double moyenne = somme/notes.Length
            Console.WriteLine("moyenne de notes : {0}", (double)somme / notes.Count);
        }

        /* on recherche le plus petit élément d'une Liste 
         * l'idée : on considère au départ que le plus petit élément est le premier et on parcourt
         * a liste à partir du deuxième élément. On teste à chaque tour de boucle et on change
         * la valeur du plus petit si nécessaire
         * ici on va donc utiliser une boucle For et non pas foreach
        */
        public static void ParcoursListePlusPetit()
        {
            // instanciation d'une liste (collection d'entiers)
            List<int> notes = new List<int>();
            // ajout des éléments dans la liste.
            notes.Add(12);
            notes.Add(15);
            notes.Add(5);
            notes.Add(4);
            notes.Add(9);
            notes.Add(11);
            notes.Add(16);
            notes.Add(20);
           
            // initialisation de la valeur mini avec le premier élément de la liste
            int min = notes.ElementAt(0);
            // on parcourt le tableau à partir du deuxième élémént
            for (int i = 1; i < notes.Count; i++)
            {
                if (notes.ElementAt(i) < min)
                {
                    min = notes.ElementAt(i);
                }
            }
            Console.WriteLine("note la plus petite : {0}", min);
        }

        /// <summary>
        /// on va rechercher si la valeur passée en paramètre est présente dans la Liste
        /// </summary>
        /// <param name="valeurRecherchee">valeur recherchée</param>
        public static void RechercheValeurListe(int valeurRecherchee)
        {
            // instanciation d'une liste (collection d'entiers)
            List<int> notes = new List<int>();
            // ajout des éléments dans la liste.
            notes.Add(12);
            notes.Add(15);
            notes.Add(5);
            notes.Add(4);
            notes.Add(9);
            notes.Add(11);
            notes.Add(16);
            notes.Add(20);
            /* 
             * contrairement au tableau, on va utiliser les attributs publics de la classe List<T> 
             * Méthode Contains
             * Méthode IndexOf
            */
            if(notes.Contains(valeurRecherchee))
            {
                Console.WriteLine("la note {0} est présente dans le tableau à la position {1}", valeurRecherchee, notes.IndexOf(valeurRecherchee));
            }
            else
            {
                Console.WriteLine("la note {0} n'est pas présente dans le tableau", valeurRecherchee);
            }
        }

    }
}
