using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt : Feed
    {

        public string avsnittsBeskrivning { get; set; }

        public Avsnitt(string namn) : base(namn)
        {

        }



    }

}
