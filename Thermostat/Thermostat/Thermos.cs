using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermostat
{
    public partial class Thermos : Form
    {
        Thermostat thermostat = new Thermostat();
        Radiateur r = new Radiateur();
        Climatisation c = new Climatisation();

        //TextBox textBox = new TextBox();

        public Thermos()
        {
            InitializeComponent();
            thermostat.OnTemperatureChange += r.OnTemperatureChanged;
            thermostat.OnTemperatureChange += c.OnTemperatureChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.getResultat = "";
            r.getResultat = "";
            thermostat.CurrentTemperature = Convert.ToDouble(textBox1.Text);
            this.richTextBox1.Text = "";
            this.richTextBox1.Text += c.getResultat;
            this.richTextBox1.Text += r.getResultat;
        }
    }
}
