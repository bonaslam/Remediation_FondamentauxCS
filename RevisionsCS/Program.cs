using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionsCS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*******************     Tableaux     ********************************");
            Console.WriteLine("*********************************************************************");
            ExercicesTableau.ParcoursTableauSomme();
            ExercicesTableau.ParcoursTableauPlusPetit();
            ExercicesTableau.RechercheValeurTableau(15);
            ExercicesTableau.RechercheValeurTableau(19);
            //on teste la dernière note du tableau
            ExercicesTableau.RechercheValeurTableau(20);

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*******************     Collections     ********************************");
            Console.WriteLine("*********************************************************************");
            ExercicesListes.ParcoursListeSomme();
            ExercicesListes.ParcoursListePlusPetit();
            ExercicesListes.RechercheValeurListe(12);
            ExercicesListes.RechercheValeurListe(19);
            ExercicesListes.RechercheValeurListe(20);

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*************     Collection et classe  *****************************");
            Console.WriteLine("*********************************************************************");
            ExercicesListeClasses.ParcoursCollectionClasseSomme();
            ExercicesListeClasses.ParcoursCollectionClassePlusPetit();
            ExercicesListeClasses.ParcoursCollectionClasseRecherche("Robert");
            ExercicesListeClasses.ParcoursCollectionClasseRecherche("Collin");
            ExercicesListeClasses.ParcoursCollectionClasseRecherche("Meunier");
            ExercicesListeClasses.ParcoursCollectionClasseRechercheV2("Meunier");
            foreach(Etudiant etudiant in ExercicesListeClasses.ListeEtudiantParOption("SLAM"))
            {
                Console.WriteLine(etudiant);
            }

            Console.ReadKey();
        }
        
    }
}
