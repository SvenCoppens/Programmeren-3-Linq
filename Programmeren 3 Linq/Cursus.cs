using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3_Linq
{
    class Cursus
    {
        public Cursus(string naam,int punten)
        {
            Naam = naam;
            Punten = punten;
        }
        public string Naam { get; set; }
        public int Punten { get; set; }
        public override string ToString()
        {
            return Naam;
        }
    }

}
