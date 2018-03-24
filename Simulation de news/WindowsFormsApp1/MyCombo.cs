using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class MyCombo<T> : ComboBox
    {

        public MyCombo() : base() 
            {
            DisplayMember = "Name";
            }
       public void addElement (T t)
        {
            Items.Add(t);
        }
public void suppElement(T t)
        {
            Items.Remove(t);
        }

    }
}
