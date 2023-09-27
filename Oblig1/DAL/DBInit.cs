
using Oblig1.Models;
using System;

namespace Oblig1.DAL
{
    public class DBInit
    {

        public static void Seed(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            ItemDbContext context = serviceScope.ServiceProvider.GetRequiredService<ItemDbContext>();
            context.Database.EnsureCreated();


            if (!context.person.Any())


            {

                var person = new List<Person>
                {
                    new Person {personID=1,Navn="Mathias",Addresse="Osloveien18",Email="Mathias18@gmail.com",Fodselsdato= new DateTime(1999,5,8),TelefonNmr=14789531 },
                    new Person {personID=2,Navn="Ole",Addresse="Osloveien20",Email="Osloveien20",Fodselsdato= new DateTime(1996,2,8),TelefonNmr=95632164 },
                    new Person { personID=3, Navn="Anna", Addresse="Bergenveien14", Email="anna@example.com", Fodselsdato=new DateTime(1990,5,15), TelefonNmr=98765432 },
                    new Person { personID=4, Navn="Markus", Addresse="Trondheimsveien10", Email="markus@example.com", Fodselsdato=new DateTime(1985,9,20), TelefonNmr=12345678 },
                    new Person { personID=5, Navn="Linda", Addresse="Stavangerveien8", Email="linda@example.com", Fodselsdato=new DateTime(1982,12,4), TelefonNmr=87654321 },
                    new Person { personID=6, Navn="Erik", Addresse="Bergensgaten22", Email="erik@example.com", Fodselsdato=new DateTime(1978,7,10), TelefonNmr=65432109 },
                    new Person { personID=7, Navn="Maria", Addresse="Tromsogata5", Email="maria@example.com", Fodselsdato=new DateTime(1992,4,17), TelefonNmr=32109876 },



                };
                context.AddRange(person);
                context.SaveChanges();

            }

            if (!context.bruker.Any())
            {

                var brukere = new List<Bruker>
                {
                   new Bruker {personID=1,Navn="Mathias",Addresse="Osloveien18",Email="Mathias18@gmail.com",Fodselsdato= new DateTime(1999,5,8),TelefonNmr=14789531,Passord="hei123",erAdmin=false,erEier=true,}
                     };

                context.AddRange(brukere);
                context.SaveChanges();
            }

            if (!context.kunde.Any())
            {

                var kunder = new List<Kunde>
                {

                  new Kunde{personID=2,Navn="Ole",Addresse="Osloveien20",Email="Ole20@gmail.com",Fodselsdato= new DateTime(1996,2,8),TelefonNmr=95632164,kundeId=1 },
                  new Kunde { personID=3, Navn="Anna", Addresse="Bergenveien14", Email="anna@example.com", Fodselsdato=new DateTime(1990,5,15), TelefonNmr=98765432 },
                  new Kunde { personID=4, Navn="Markus", Addresse="Trondheimsveien10", Email="markus@example.com", Fodselsdato=new DateTime(1985,9,20), TelefonNmr=12345678 },
                  new Kunde { personID=5, Navn="Linda", Addresse="Stavangerveien8", Email="linda@example.com", Fodselsdato=new DateTime(1982,12,4), TelefonNmr=87654321 },
                  new Kunde { personID=6, Navn="Erik", Addresse="Bergensgaten22", Email="erik@example.com", Fodselsdato=new DateTime(1978,7,10), TelefonNmr=65432109 },
                  new Kunde { personID=7, Navn="Maria", Addresse="Tromsogata5", Email="maria@example.com", Fodselsdato=new DateTime(1992,4,17), TelefonNmr=32109876 }

                };


                context.AddRange(kunder);
                context.SaveChanges();
            }

            if (!context.eier.Any())
            {

                var eier = new Eier
                {
                    personID = 1,
                    Navn = "Mathias",
                    Addresse = "Osloveien18",
                    Email = "Mathias18@gmail.com",
                    Fodselsdato = new DateTime(1999, 5, 8),
                    TelefonNmr = 14789531,
                    eierID = 1,
                    kontoNummer = 11111111111
                };
                var eier1 = new Eier
                {
                    personID = 3,
                    Navn = "Anna",
                    Addresse = "Bergenveien14",
                    Email = "anna@example.com",
                    Fodselsdato = new DateTime(1990, 5, 15),
                    TelefonNmr = 98765432,
                    eierID = 3,
                    kontoNummer = 33333333333
                };

                var eier2 = new Eier
                {
                    personID = 4,
                    Navn = "Markus",
                    Addresse = "Trondheimsveien10",
                    Email = "markus@example.com",
                    Fodselsdato = new DateTime(1985, 9, 20),
                    TelefonNmr = 12345678,
                    eierID = 4,
                    kontoNummer = 44444444444
                };

                var eier3 = new Eier
                {
                    personID = 5,
                    Navn = "Linda",
                    Addresse = "Stavangerveien8",
                    Email = "linda@example.com",
                    Fodselsdato = new DateTime(1982, 12, 4),
                    TelefonNmr = 87654321,
                    eierID = 5,
                    kontoNummer = 55555555555
                };

                var eier4 = new Eier
                {
                    personID = 6,
                    Navn = "Erik",
                    Addresse = "Bergensgaten22",
                    Email = "erik@example.com",
                    Fodselsdato = new DateTime(1978, 7, 10),
                    TelefonNmr = 65432109,
                    eierID = 6,
                    kontoNummer = 66666666666
                };

                var eier5 = new Eier
                {
                    personID = 7,
                    Navn = "Maria",
                    Addresse = "Tromsogata5",
                    Email = "maria@example.com",
                    Fodselsdato = new DateTime(1992, 4, 17),
                    TelefonNmr = 32109876,
                    eierID = 7,
                    kontoNummer = 77777777777
                };
                context.AddRange(eier);
                context.SaveChanges();

            }



            if (!context.hus.Any())


            {

                var hus = new List<Hus>
                {
                    new Hus {husId=1,Addresse="Osloveien18",areal=200,Beskrivelse="bla bla bla", by="Oslo",erTilgjengelig=true,Pris=400,romAntall=4, erMoblert=true, harParkering=false, eierID=1, bildeURL = "" },
                    new Hus { husId = 6, Addresse = "Osloveien18", areal = 200, Beskrivelse = "bla bla bla", by = "Oslo", erTilgjengelig = true, Pris = 400, romAntall = 4, erMoblert = true, harParkering = false, eierID = 1, bildeURL = "" },
                    new Hus { husId = 2, Addresse = "Trondheimsveien22", areal = 180, Beskrivelse = "spacious and modern", by = "Trondheim", erTilgjengelig = true, Pris = 600, romAntall = 5, erMoblert = false, harParkering = true, eierID = 2, bildeURL = "http://example.com/image2.jpg" },
                    new Hus { husId = 3, Addresse = "Bergenveien15", areal = 150, Beskrivelse = "cozy cottage", by = "Bergen", erTilgjengelig = false, Pris = 300, romAntall = 3, erMoblert = true, harParkering = true, eierID = 3, bildeURL = "http://example.com/image3.jpg" },
                    new Hus { husId = 4, Addresse = "Stavangerveien10", areal = 220, Beskrivelse = "luxurious villa", by = "Stavanger", erTilgjengelig = true, Pris = 800, romAntall = 6, erMoblert = true, harParkering = true, eierID = 4, bildeURL = "http://example.com/image4.jpg" },
                    new Hus { husId = 5, Addresse = "Tromsogata7", areal = 190, Beskrivelse = "charming historic home", by = "Tromsø", erTilgjengelig = true, Pris = 500, romAntall = 4, erMoblert = false, harParkering = false, eierID = 5, bildeURL = "http://example.com/image5.jpg" },


            };
                context.AddRange(hus);
                context.SaveChanges();

            }
            
          

            if (!context.ordre.Any())
            {

                var ordre = new List<Ordre>
                {
                    new Ordre {
                        ordreId = 1,
                        Dato = DateTime.Now,
                        betaltGjennom = "Kort",
                        husID = 1,
                        kundeID = 1,
                        }
                };


                context.AddRange(ordre);
                context.SaveChanges();
            };

}
    }
}


