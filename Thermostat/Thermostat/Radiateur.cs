﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermostat
{
    class Radiateur
    {
        private double temperature = 0;
        private string resultat;

        public void OnTemperatureChanged(double temp)
        {
            temperature = temp;
            if(temp < 20)
            {
                this.resultat += "Le radiateur se met en route \r\n";
            }
        }


        public string getResultat
        {
            get { return this.resultat; }
            set { this.resultat = value; }

        }
    }
}
