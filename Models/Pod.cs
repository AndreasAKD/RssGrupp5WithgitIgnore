using System;
using System.Collections.Generic;

namespace Models
{
    public class Pod : Feed
    {
        public string AngivetUrl { get; set; }
        public string UppdateringsFrekvens { get; set; }
        public DateTime TidForUppdatering { get; set; }
        public string Kategori { get; set; }
        public List<Avsnitt> AntalAvsnitt { get; set; }

        public Pod(string namn, string angivetUrl, string uppdeteringsFrekvens, DateTime tidForUppdatering, string kategori, List<Avsnitt> antalAvsnitt) : base(namn)
        {
            Namn = namn;
            AngivetUrl = angivetUrl;
            UppdateringsFrekvens = uppdeteringsFrekvens;
            TidForUppdatering = tidForUppdatering;
            Kategori = kategori;
            AntalAvsnitt = antalAvsnitt;
        }

        public Pod()
        {
        }

        public override string VirtualReturnTest()
        {
            return "Detta är en virtual ovverride av typen Podcast";
        }

        public bool KollaUppdatering
        {
            get
            {
                return TidForUppdatering <= DateTime.Now;
                
            }
        }
    }
}
