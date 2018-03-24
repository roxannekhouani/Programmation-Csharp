using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermostat
{

    delegate void TemperatureChangeHandler(double temp);

    class Thermostat
    {

        public TemperatureChangeHandler tempe = null;

        private double _CurrentTemperature;
        
        public event TemperatureChangeHandler OnTemperatureChange;


        public double CurrentTemperature
        {
            get { return _CurrentTemperature; }

            set {

                if(value != _CurrentTemperature)
                {
                    _CurrentTemperature = value;

                    if(OnTemperatureChange != null)
                    {
                        OnTemperatureChange(_CurrentTemperature);
                    }
                }
            }
        }
    }
}
