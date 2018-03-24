using System;
using System.Windows.Forms;


namespace Simulation_taches
{
    public partial class Simulation : Form
    {
        PersonneFactory personnefact = new PersonneFactory();
        TextBox textBox = new TextBox();
        private int nombreinstances;


        public Simulation()
        {
            InitializeComponent();
        }


        private void button1_Valid_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.personnefact.addPersonne(new Administrateur("Admin", "Administrateur"));
                nombreinstances++;
                MessageBox.Show("Un administrateur " + nombreinstances + " a était créer");
            }
            else if (radioButton2.Checked)
            {
                this.personnefact.addPersonne(new Ouvrier("Ouvrier", "Ouvrier"));
                nombreinstances++;
                MessageBox.Show("Un ouvrier " + nombreinstances + " a était créer");
            }
            this.comboBox1.DataSource = this.personnefact.listePersonne();
            this.comboBox1.DisplayMember = "nom";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            this.personnefact.exec(textBox);
            this.richTextBox1.Text = textBox.Text;
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
                this.personnefact.exec += personnefact.tache1;
            else
                this.personnefact.exec -= personnefact.tache1;
        }



        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked == true)
                this.personnefact.exec += personnefact.tache2;
            else
                this.personnefact.exec -= personnefact.tache2;
        }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
