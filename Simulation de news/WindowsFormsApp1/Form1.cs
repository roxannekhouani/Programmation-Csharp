using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Factory<Topic> tf;
        private Factory<Personne> pf;

        public Form1()
        {
            tf = new Factory<Topic>();
            pf = new Factory<Personne>();
            InitializeComponent();
            tf.OnAdd += ((MyCombo<Topic>)comboBox1).addElement;
                tf.OnAdd += ((MyCombo<Topic>)comboBox2).addElement;
            tf.OnAdd += ((MyCombo<Topic>)comboBox3).addElement;
            tf.OnDelete += ((MyCombo<Topic>)comboBox1).suppElement;
            tf.OnDelete += ((MyCombo<Topic>)comboBox2).suppElement;
            tf.OnDelete += ((MyCombo<Topic>)comboBox3).suppElement;

            pf.OnAdd += ((MyCombo<Personne>)comboBox4).addElement;
            pf.OnAdd += ((MyCombo<Personne>)comboBox5).addElement;
            pf.OnAdd += ((MyCombo<Personne>)comboBox6).addElement;
            pf.OnDelete += ((MyCombo<Personne>)comboBox4).suppElement;
            pf.OnDelete += ((MyCombo<Personne>)comboBox5).suppElement;
            pf.OnDelete += ((MyCombo<Personne>)comboBox6).suppElement;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tf.createElement(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pf.createElement(textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tf.SuppElement((Topic)comboBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pf.SuppElement((Personne)comboBox6.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Topic t = (Topic)comboBox3.SelectedItem;
            Personne p = (Personne)comboBox4.SelectedItem;
            t.Topictexte += p.OnText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Topic t = (Topic)comboBox1.SelectedItem;
            t.textTopic = textBox2.Text;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = ((Personne)comboBox5.SelectedItem).Texte;
            textBox3.Text = t;
        }
    }
}
