﻿namespace Oblig1.Models
{
    public class Kunde : Person
    {
        public Kunde(string navn, DateTime fodselsdato, string addresse, int telefonNmr, string email,int kundeid, List<Ordre> ordreliste) : base(navn, fodselsdato, addresse, telefonNmr, email)
        {
            this.kundeId = kundeid; 
            this.ordreListe = ordreliste;   
        }

        public int kundeId { get; set; }

        public virtual List<Ordre> ordreListe { get; set; }




    }
}
