using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Opdracht_Linq
{
    class File
    {
        public static List<Straat> straten = new List<Straat>();

        public static void VerwerkGegevens()
        {
            using(StreamReader sr = new StreamReader(@"D:\Programmeren Data en Bestanden\adresInfo.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(",");
                    straten.Add(new Straat(splitLine[0],splitLine[1],splitLine[2]));
                }
            }
        }
    }
}
