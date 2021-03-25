using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionsCS
{
    internal abstract class ExercicesTableau
    {
        // affiche la somme des notes et leur moyenne
        public static void ParcoursTableauSomme()
        {
            int[] notes = { 12, 15, 5, 4, 9, 11, 16, 20 };
            // initialisation de la somme
            int somme = 0;
            // boucle foreach car on doit parcourir tout le tableau.
            foreach (int note in notes)
            {
                somme = somme + note;  // ou somme +=note;
            }
            Console.WriteLine("somme des notes : {0}", somme);
            Console.WriteLine("nombre de notes : {0}", notes.Length);
            // on caste la division sinon le compilateur fait une division entière et affiche 11
            // on aurait aussi pu créer une variable :
            // double moyenne = somme/notes.Length
            Console.WriteLine("moyenne de notes : {0}", (double)somme / notes.Length);
        }

        /* on recherche le plus petit élément d'un tableau 
         * l'idée : on considère au départ que le plus petit élément est le premier et on parcourt
         * le tableau à partir du deuxième élément. On teste à chaque tour de boucle et on change
         * la valeur du plus petit si nécessaire
         * ici on va donc utiliser une boucle For et non pas foreach
        */
        public static void ParcoursTableauPlusPetit()
        {
            int[] notes = { 12, 15, 5, 4, 9, 11, 16, 20 };
            // initialisation de la valeur mini
            int min = notes[0];
            // on parcourt le tableau à partir du deuxième élémént
            for (int i = 1; i < notes.Length; i++)
            {
                if (notes[i] < min)
                {
                    min = notes[i];
                }
            }
            Console.WriteLine("note la plus petite : {0}", min);
        }


        /// <summary>
        /// on va rechercher si la valeur passée en paramètre est présente dans le tableau
        /// </summary>
        /// <param name="valeurRecherchee">valeur recherchée</param>
        public static void RechercheValeurTableau(int valeurRecherchee)
        {
            int[] notes = { 12, 15, 5, 4, 9, 11, 16, 20 };
            /* on va utiliser une boucle while car on n'a pas besoin de parcourir obligatoirement tout le tableau
             * on s'arrête dès qu'on a trouvé 
             *  OU
             * Si on a parcouru tout le tableau sans avoir trouvé 
             * Donc double condition dans la boucle.
             * On initialise une variable de compteur à 0
            */
            int i = 0;
            while (i < notes.Length && notes[i] != valeurRecherchee)
            {
                // on se décale de 1 dans le tableau
                i++;
            }
            // on doit tester comment on est sortis de la boucle !
            if (i < notes.Length)
            {
                Console.WriteLine("la note {0} est présente dans le tableau à la position {1}", valeurRecherchee, i);
            }
            else
            {
                Console.WriteLine("la note {0} n'est pas présente dans le tableau", valeurRecherchee);
            }
        }
    }
}
