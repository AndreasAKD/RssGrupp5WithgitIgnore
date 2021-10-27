using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt : Feed
    {
        
        public string AvsnittsBeskrivning { get; set; }

        public Avsnitt(string namn, string beskrivning) : base(namn)
        {
            AvsnittsBeskrivning = beskrivning;
        }

        public Avsnitt() { }

    }

}
