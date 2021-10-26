using System;
using System.Collections.Generic;

namespace Models
{
    public class Pod : Feed
    {
        public string AngivetUrl { get; set; }
        public string UppdateringsFrekvens { get; set; }
        public string Kategori { get; set; }
        public List<Avsnitt> AntalAvsnitt { get; set; }

        public Pod(string namn, string angivetUrl, string uppdeteringsFrekvens, string kategori, List<Avsnitt> antalAvsnitt) : base(namn)
        {
            Namn = namn;
            AngivetUrl = angivetUrl;
            UppdateringsFrekvens = uppdeteringsFrekvens;
            Kategori = kategori;
            AntalAvsnitt = antalAvsnitt;
        }


    }
}
