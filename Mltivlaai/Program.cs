using System;
using System.Data;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace MedewerkersMultivlaai
{
    class Medewerker
    { 
        public class Werknemer
    {
        public string Id { get; set; }
        public string Naam { get; set; }
    }
    public class Achtenaam
    {
        public string Id { get; set; }
        public string WerknemerId { get; set; }
        public string geboortenaam { get; set; }
    }
    public class Gdatum
    {
        public string Id { get; set; }
        public string AchternaamId { get; set; }
        public string datumgeboorte { get; set; }
    }

    public class Werk
    {
        public string Id { get; set; }
        public string GdatumId { get; set; }
        public string functie { get; set; }
    }

    
        static void Main(string[] args)
        {                      
           
            Console.WriteLine("geef aub je wachtwoord op: ");
            var wachtwoord = Console.ReadLine();
            var i = 0;

            while (wachtwoord != "Security" && i < 3)
            {
                Console.WriteLine("probeer op nieuw, probeer nog een keer: ");
                wachtwoord = Console.ReadLine();
                i++;
            }

            if (i < 3)
            
            Console.WriteLine("aantalmedewerkes: "); // opgave aantal medewerkers die ingevoerd gaan worden
            string input = Console.ReadLine();
            int ID;
            Int32.TryParse(input, out ID);
            for (int n = 0; n < ID; n++)


            {   //gegevens medewerkers
                Console.WriteLine("Naam medewerker: ");
                var medewerkernaam = Console.ReadLine();
            
                Console.WriteLine("Functie: ");
                var Functie = Console.ReadLine();                
                
                /*var nlCulture = new CultureInfo("nl-NL");
                Console.WriteLine("Geboorte datum: " + "dd-mm-yyyy", nlCulture.DateTimeFormat.ShortDatePattern);
                string geboortedatum = Console.ReadLine();
                DateTime userDate;
               
                {
                    if (DateTime.TryParse(geboortedatum, nlCulture.DateTimeFormat, DateTimeStyles.None, out userDate))
                    {
                        Console.WriteLine();                                                                      
                    }
                    else                    
                    {
                        Console.WriteLine("Invalid date specified! ");                                               
                    }
                 }
                */               

                bool geboorte = false;

                var nlCulture = new CultureInfo("nl-NL");
                Console.WriteLine("Geboorte datum: " + "dd-mm-yyyy", nlCulture.DateTimeFormat.ShortDatePattern);
                var geboortedatum = Console.ReadLine();
                DateTime Date = DateTime.Today;
                              
                try
                {
                    DateTime Datum = Convert.ToDateTime(geboortedatum);
                    geboorte = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("het format van de opgegeven geboordedatum is niet correct.");
                }
                DateTime userDate;
                while (geboorte == false)

                {
                    Console.WriteLine("Geboorte datum: " + "dd-mm-yyyy", nlCulture.DateTimeFormat.ShortDatePattern);
                    geboortedatum = Console.ReadLine();

                    if (DateTime.TryParse(geboortedatum, nlCulture.DateTimeFormat, DateTimeStyles.None, out userDate))

                    {
                        geboorte = true;

                    }
                    else
                    {
                        Console.WriteLine("Geen getal, probeer het nog eens.");
                    }
                }

                // zet gegevens naast elkaar. voorzet voor een array.
                Console.WriteLine("Leeftijd: ");
                DateTime TimeDate = DateTime.Today;
                DateTime GeboorteDatum = Convert.ToDateTime(geboortedatum);
                int leeftijd = TimeDate.Year - GeboorteDatum.Year;
                if (TimeDate.Month < GeboorteDatum.Month || (TimeDate.Month == GeboorteDatum.Month && TimeDate.Day < GeboorteDatum.Day)) leeftijd--;
                Console.WriteLine(leeftijd);

                Console.WriteLine("\n");

                {
                    Console.WriteLine("ID: {0} | naam: {1} | functie: {2} | geboorte datum: {3} | leeftijd: {4}!", ID, medewerkernaam, Functie, geboortedatum, leeftijd);
                }

                Console.WriteLine("\n");                
            }

            Console.ReadKey();


            // Wat het had moeten zijn, wel mager. Vindt het uitermate vervelend. 


            //======================================================================================================


            var werknemer = new List<Werknemer>()
            {
                 new Werknemer()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Jan"
                 },
                 new Werknemer()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Piet"
                 },
                 new Werknemer()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Joke"
                 },
                 new Werknemer()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Margriet"
                 },
                 new Werknemer()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Jansje"
                 },
                 new Werknemer()
                 {
                    Id = Guid.NewGuid().ToString(),
                    Naam = "Klaas"
                 }
            };
            var achternaam = new List<Achtenaam>()
            {
            new Achtenaam()
                 {
                     Id = Guid.NewGuid().ToString(),
                     WerknemerId = werknemer[0].Id,
                     geboortenaam = "Jansen"
                  },
            new Achtenaam()
                  {
                      Id = Guid.NewGuid().ToString(),
                      WerknemerId = werknemer[1].Id,
                      geboortenaam = "de Groot"
                   },
            new Achtenaam()
                   {
                      Id = Guid.NewGuid().ToString(),
                      WerknemerId = werknemer[2].Id,
                      geboortenaam = "Niemijer"
                   },
            new Achtenaam()
                   {
                      Id = Guid.NewGuid().ToString(),
                      WerknemerId = werknemer[3].Id,
                      geboortenaam = "Warnar"
                   },
            new Achtenaam()
                  {
                      Id = Guid.NewGuid().ToString(),
                      WerknemerId = werknemer[4].Id,
                      geboortenaam = "Gerritsen"
                   },
            new Achtenaam()
                   {
                      Id = Guid.NewGuid().ToString(),
                      WerknemerId = werknemer[5].Id,
                      geboortenaam = "Talens"
                   }
            };
            var gdatum = new List<Gdatum>()
            {
            new Gdatum()
                   {
                      Id = Guid.NewGuid().ToString(),
                      AchternaamId= achternaam[0].Id,
                      datumgeboorte = "12-10-1960"
                   },
            new Gdatum()
                   {
                      Id = Guid.NewGuid().ToString(),
                      AchternaamId= achternaam[1].Id,
                      datumgeboorte = "11-04-1990"
                   },
            new Gdatum()
                   {
                      Id = Guid.NewGuid().ToString(),
                      AchternaamId= achternaam[2].Id,
                      datumgeboorte = "05-05-2000"
                   },
            new Gdatum()
                   {
                      Id = Guid.NewGuid().ToString(),
                      AchternaamId= achternaam[3].Id,
                      datumgeboorte = "01-06-1985"
                   },
                    new Gdatum()
                   {
                      Id = Guid.NewGuid().ToString(),
                      AchternaamId= achternaam[4].Id,
                      datumgeboorte = "03-07-1991"
                   },
            new Gdatum()
                   {
                      Id = Guid.NewGuid().ToString(),
                      AchternaamId= achternaam[5].Id,
                      datumgeboorte = "03-08-1999"
                   }
            };
            var functie = new List<Werk>()
            {
            new Werk()
                   {
                      Id = Guid.NewGuid().ToString(),
                      GdatumId= gdatum[0].Id,
                      functie = "verkoper"
                   },
            new Werk()
                   {
                      Id = Guid.NewGuid().ToString(),
                      GdatumId= gdatum[1].Id,
                      functie = "inkoper"
                   },
            new Werk()
                   {
                      Id = Guid.NewGuid().ToString(),
                      GdatumId= gdatum[2].Id,
                      functie = "verkoper"
                   },
            new Werk()
                   {
                      Id = Guid.NewGuid().ToString(),
                      GdatumId= gdatum[3].Id,
                      functie = "verkoper"
                   },
            new Werk()
                   {
                      Id = Guid.NewGuid().ToString(),
                      GdatumId= gdatum[4].Id,
                      functie = "inkoper"
                   },
            new Werk()
                   {
                      Id = Guid.NewGuid().ToString(),
                      GdatumId= gdatum[5].Id,
                      functie = "manager"
                   }
            };
            var result = from w in werknemer
                         join a in achternaam on w.Id equals a.WerknemerId
                         join g in gdatum on a.Id equals g.AchternaamId
                         join f in functie on g.Id equals f.GdatumId
                         select new
                         {
                             w.Naam,
                             a.geboortenaam,
                             g.datumgeboorte,
                             f.functie
                         };

            foreach (var resultItem in result)
            {
                Console.WriteLine($"{resultItem.Naam} {0,-5} \t{""} {"||"}  {resultItem.geboortenaam} \t{""} {"||"} {resultItem.datumgeboorte} \t{""} {"||"} {resultItem.functie}");
            }

                  

        }
    }
}
