using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    delegate void Handler<T>(T t);
    class Factory <T> where T :chap, new()
    {
        private List<T> maListe = new List<T>();
        public event Handler<T> OnAdd;
        public event Handler<T> OnDelete;

        public void createElement(string name)
        {
            T t = new T();
            t.Name = name;
            AjoutElement(t);
        }

        void AjoutElement(T t)
        {
            maListe.Add(t);
            if (OnAdd != null)
            {
                OnAdd(t);
            }
        }

        public void SuppElement(T t)
        {
            maListe.Remove(t);
            if (OnDelete !=null)
            {
                OnDelete(t);
            }
        }
    }
}
