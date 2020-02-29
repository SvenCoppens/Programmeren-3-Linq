using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Opdracht_Linq
{
    class GegevensVerwerking
    {
        public static List<string> ProvincieNamen()
        {
            var sel = File.straten.Select(s => s.Provincie).Distinct().ToList();
            return sel;
        }
        public static List<string> LijstVanStraatNamen()
        {
            Console.WriteLine("Geef een gemeente Naam: ");
            string gemeente = Console.ReadLine();
            var lijst = File.straten.Where(s => s.Gemeente == gemeente).Select(x =>x.Naam).ToList();
            return lijst;
        }

        public static List<string> MeestVoorkomendeStraatNaam(int aantal = 1)
        {
            var sel = File.straten.ToLookup(s => s.Naam).OrderByDescending(x => x.Count()).Take(aantal);
            //returnt een collectie van straatnaam - straat
            List<string> temp = new List<string>();
             foreach(var x in sel)
            {
                foreach(Straat y in x)
                {
                    temp.Add(y.ToString());
                }
            }
            return temp;
        }
        public static List<string> GemeenschappelijkeStraten()
        {
            Console.WriteLine("Wat is de eerste gemeente?: ");
            string eersteGemeente = Console.ReadLine();
            Console.WriteLine("Wat is de tweede gemeente?: ");
            string tweedeGemeente = Console.ReadLine();

            var sel1 = File.straten.Where(s => s.Gemeente == eersteGemeente).Select(s => s.Naam).ToList();
            var sel2 = File.straten.Where(s => s.Gemeente == tweedeGemeente).Select(s => s.Naam).ToList();
            return (sel1.Intersect(sel2)).ToList();
        }
        public static List<string> UniekeStraatnamenVergelijking(List<string> gemeenten)
        {
            Console.WriteLine("Welke Gemeente?: ");
            string gemeente = Console.ReadLine();
            var sel = File.straten.Where(s => s.Gemeente == gemeente).Select(s=>s.Naam);
            var vergelijking = File.straten.Where(s => gemeenten.Contains(s.Gemeente)).Select(s=>s.Naam);
            return sel.Except(vergelijking).ToList();
        }
        public static List<string> HoogsteAantalStraatnamen()
        {
            var sel = File.straten.GroupBy(s => s.Gemeente).OrderByDescending(g => g.Count()).First();
            return new List<string>() { sel.Key };
        }
        public static List<string> LangsteStraatNaam()
        {
            var sel = File.straten.GroupBy(s => s.Naam.Length).OrderByDescending(s=>s.Key).First();
            List<string> temp = new List<string>();
            foreach(var x in sel)
            {
                temp.Add(x.Naam);
            }
            return temp;
        }
        public static List<string> LangsteStraatNaamPlusGegevens()
        {
            var sel = File.straten.GroupBy(s => s.Naam.Length).OrderByDescending(s => s.Key).First();
            List<string> temp = new List<string>();
            foreach (var x in sel)
            {
                temp.Add(x.ToString());
            }
            return temp;
        }

        public static List<string> LijstUniekeStraatnamen()
        {
            var sel = File.straten.ToLookup(s => s.Naam).Where(x => x.Count() == 1);
            List<string> temp = new List<string>();
            foreach(var x in sel)
            {
                foreach(var y in x)
                {
                    temp.Add(y.ToString());
                }
            }
            return temp;
        }
        public static List<string> LijstUniekeStraatNamenVoorGemeente()
        {
            Console.WriteLine("Welke Gemeente?: ");
            string gemeente = Console.ReadLine();

            var sel = File.straten.Where(s=>s.Gemeente==gemeente).ToLookup(s => s.Naam).Where(x => x.Count() == 1);
            List<string> temp = new List<string>();
            foreach (var x in sel)
            {
                foreach (var y in x)
                {
                    temp.Add(y.ToString());
                }
            }
            return temp;
        }
    }
}
