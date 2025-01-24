using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ubersetzer_MVVM.Modell;

namespace Ubersetzer_MVVM
{
    internal class ViewModel: BindableBase
    {
        string deutsch;
        string englisch;
        private Modell.Ubersetzer ubersetzer;
        public string Deutsch {  get { return deutsch; }set { SetProperty(ref deutsch, value); } }
        public string Englisch { get { return englisch; }set { SetProperty(ref  englisch, value); } }

        public ViewModel() {
            ubersetzer = new Modell.Ubersetzer();
        }

        public void Umwandeln()
        {
            ubersetzer.DatenLesen();
            if (!String.IsNullOrEmpty(deutsch))
            {
                Englisch = ubersetzer.DeutschNachEnglisch(deutsch);
            } else if (!String.IsNullOrEmpty(englisch))
            {
                Deutsch = ubersetzer.EnglischNachDeutsch(englisch);
            }
        }

        public void Leeren()
        {
            Englisch = "";
            Deutsch = "";
        }
    }
}
