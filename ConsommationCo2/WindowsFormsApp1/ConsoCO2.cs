using System;
using System.Windows.Forms;

namespace Consommation_CO2
{
    public partial class ConsoCO2 : Form
    {
        Calcul calcul = new Calcul();

        public ConsoCO2()
        {
            InitializeComponent();
        }


        // evenement qui effectue les calculs et renvoie les résultats selon les saisies 

        private void button_Valid_Click(object sender, EventArgs e)
        {
            calcul.toString = "";

            calcul.exec(Convert.ToDouble(this.numericUpDown_nbKm.Value), Convert.ToDouble(this.numericUpDown_nbPersonne.Value));
            this.richTextBoxResult.Text = calcul.toString;

        }


        private void checkBox_pied_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
                calcul.exec += calcul.calculPied;
            else
                calcul.exec -= calcul.calculPied;
        }

        private void checkBox_voiture_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
                calcul.exec += calcul.calculVoiture;
            else
                calcul.exec -= calcul.calculVoiture;
        }

        private void checkBox_car_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
                calcul.exec += calcul.calculCar;
            else
                calcul.exec -= calcul.calculCar;
        }

        private void numericUpDown_nbKm_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
