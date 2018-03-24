using System;


namespace Consommation_CO2
{

    /**
     * Définition d'un délégué qui permet de référencer des méthodes de la classe calcul, ayant la même signature que notre fonction ci-dessous
     */

    delegate void fonction(double nbKm, double nbPersonne);

    class Calcul
    {
       
         // Initialisation du délégué à NULL
        
        public fonction exec = null;
        private double temps;
        private double grammeCO2;
        private String resultat;

         
        public Calcul()
        {
            this.temps = 0;
            this.grammeCO2 = 0.0;
        }

        
         // temps de parcours et taux de CO2 à pieds
         
        public void calculPied(double nbKm, double nbPersonne)
        {
            this.temps = nbKm / 5;
            this.resultat += "A pied, je vais mettre " + this.temps + " heure(s), je produis 0g de CO2 \r\n";
        }

        
         // temps de parcours et taux de C02 en voiture
         
        public void calculVoiture(double nbKm, double nbPersonne)
        {
            this.grammeCO2 = 130.0;
            double nbVoiture = (nbPersonne / 5);
            this.temps = nbKm / 130;
            double co2 = 1.3 * nbVoiture * nbKm;
            this.resultat += "En voiture, je vais mettre " + this.temps + " heure(s), je produis " + co2 + " g de CO2 \r\n";
        }

        
         // temps de parcours et taux de C02 en bus
        
        public void calculCar(double nbKm, double nbPersonne)
        {
            this.grammeCO2 = 100.0;
            double nbBus = (nbPersonne / 40);
            this.temps = nbKm / 110;
            double co2 = 1 * nbBus * nbKm;
            this.resultat += "En bus, je vais mettre " + this.temps + " heure(s), je produis " + co2 + " g de CO2 \r\n";
        }

       
         // récupére le résultat sous forme d'une chaine de caractères
       
        public string toString
        {
            get {
                return this.resultat;
            }
            set {
                this.resultat = value;
            }
        }
    }
}