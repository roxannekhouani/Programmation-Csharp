using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    delegate void HandlerTopic(string texte);
    class Topic : chap
    {
        
        private string _texTopic;
        public event HandlerTopic Topictexte;

        
        public string textTopic
        {
            get
            {
                return _texTopic;
            }
            set
            {
                _texTopic = value;
                if (textTopic != null)
                {
                    Topictexte(_texTopic);
                }
            }
        }
    }
}
