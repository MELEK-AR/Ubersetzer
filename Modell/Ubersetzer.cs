using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubersetzer_MVVM.Modell
{
    internal class Ubersetzer
    {
        private List<Wortpaar> wortpaare = new List<Wortpaar>();

        public void DatenLesen()
        {
            StreamReader sr = new StreamReader("Wortpaare.txt");
            string s;
            int i = 0;
            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();
                string[] c = s.Split(';');
                wortpaare.Add(new Wortpaar(c[0], c[1]));
                i++;
            }
            sr.Close();
        }

        public string DeutschNachEnglisch(string deutsch)
        {
            string s = null;
            for(int i = 0; i < wortpaare.Count; i++)
            {
                if(wortpaare[i].Deutsch == deutsch)
                {
                    s = wortpaare[i].Englisch;
                }
            }
            return s;
        }

        public string EnglischNachDeutsch(string englisch)
        {
            string s = null;
            for (int i = 0; i < wortpaare.Count; i++)
            {
                if (wortpaare[i].Englisch == englisch)
                {
                    s = wortpaare[i].Deutsch;
                }
            }
            return s;
        }
    }
}
