using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubProjet2
{
    public class Etudiant
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public override string ToString()
        {
            return "Nom : " + Nom + "Prenom : " + Prenom;
        }
    }
}
