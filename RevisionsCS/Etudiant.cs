using System;

namespace RevisionsCS
{
    internal class Etudiant
    {
        private String nom;
        private String option;
        private double moyenne;

        public Etudiant(string nom, string option, double moyenne)
        {
            this.nom = nom;
            this.option = option;
            this.moyenne = moyenne;
        }

        public override string ToString()
        {
            return String.Format("Nom : {0} \n\tOption : {1}  Moyenne : {2}", this.nom, this.option, this.moyenne);
        }

        public string Nom { get => nom;  }
        public string Option { get => option;  }
        public double Moyenne { get => moyenne; }

    }
}
