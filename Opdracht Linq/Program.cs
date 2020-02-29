using System;
using System.Collections.Generic;
namespace Opdracht_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            File.VerwerkGegevens();

            List<string> collectie = new List<string>();
            List<string> gemeenten = new List<string>() { "Gent", "Aalst", "Antwerpen" };
            //alfabetische lijst van provincienamen
            //collectie = GegevensVerwerking.ProvincieNamen();
            
            //lijst van straatnamen voor een opgegeven gemeente
            //collectie = GegevensVerwerking.LijstVanStraatNamen();

            //meest voorkomende straatnaam(en), en waar deze allemaal voorkomt,optionele parameter voor meerdere entries
            //collectie = GegevensVerwerking.MeestVoorkomendeStraatNaam();

            //vergelijkt welke straten 2 gegeven gemeentes gemeen hebben.
            //collectie = GegevensVerwerking.GemeenschappelijkeStraten();

            //kijkt welke straatnamen uniek zijn voor een bepaalde gemeente in vergelijking met een lijst van andere gemeenten
            //collectie = GegevensVerwerking.UniekeStraatnamenVergelijking(gemeenten);

            //Geeft de gemeente met het hoogste aantal straatnamen
            //collectie = GegevensVerwerking.HoogsteAantalStraatnamen();

            //geeft de langste straatnaam
            //collectie = GegevensVerwerking.LangsteStraatNaam();

            //geeft de langste straatnaam en provincie en gemeente hiervan
            //collectie = GegevensVerwerking.LangsteStraatNaamPlusGegevens();

            //geeft alle unieke stratnamen + gegevens
            //collectie = GegevensVerwerking.LijstUniekeStraatnamen();

            //geeft alle unieke straatnamen voor een bepaalde gemeente.
            //collectie = GegevensVerwerking.LijstUniekeStraatNamenVoorGemeente();
            foreach (string s in collectie)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"{collectie.Count} entries");
        }
    }
}
