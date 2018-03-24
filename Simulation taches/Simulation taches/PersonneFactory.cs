using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;


namespace Simulation_taches
{

   delegate void fonction(TextBox textBox);

    class PersonneFactory
    {
        public fonction exec = null;
        public BindingList<Personne> personne;


        public PersonneFactory()
        {
            personne = new BindingList<Personne>();
        }


        public BindingList<Personne> listePersonne()
        {
            return this.personne;
        }


        public void addPersonne(Personne p)
        {
            this.personne.Add(p);
        }
        
        public void tache1(TextBox textBox)
        {
            textBox.Text += "Administrateur : Classer \r\n"; 
            textBox.Text += "Ouvrier : Assembler \r\n";
        }

        public void tache2(TextBox textBox)
        {
            textBox.Text += "Administrateur : Contacter \r\n";
            textBox.Text += "Ouvrier : Desassembler \r\n";
            }
        }
 }


