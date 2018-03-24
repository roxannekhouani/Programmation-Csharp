using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Personne : chap
    {

        private string _texte;

        public string Texte { get => _texte; set => _texte = value; }

        public void OnText (string text)
        {
            Texte += text;
        }
    }
}
