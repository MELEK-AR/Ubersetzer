using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubersetzer_MVVM
{
    internal class Wortpaar
    {
        public string Deutsch { get; set; }
        public string Englisch { get; set; }

        public Wortpaar(string deutsch, string englisch) {
            Deutsch = deutsch;
            Englisch = englisch;
        }

    }
}
