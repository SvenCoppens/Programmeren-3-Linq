using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_Linq
{
    class Straat
    {
        public Straat(string provincie,string gemeente,string straat)
        {
            Provincie = provincie;
            Gemeente = gemeente;
            Naam = straat;
        }
        public string Gemeente { get; set; }
        public string Provincie { get; set; }
        public string Naam { get; set; }
        public override string ToString()
        {
            return ($"{Provincie}: {Gemeente}: {Naam}");
        }
    }
}
