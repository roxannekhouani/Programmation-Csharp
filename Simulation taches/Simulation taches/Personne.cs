using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_taches
{

    class Personne 
    {
        
        protected String nom;
        protected String prenom;


        public Personne(String nom, String prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }


        public string Nom
        {
            get
            {
                return this.nom;
            }
        }


        public string Prenom
        {
            get
            {
                return this.prenom;
            }
        }

    }
}
