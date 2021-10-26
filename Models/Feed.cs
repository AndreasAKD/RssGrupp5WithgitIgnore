using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Feed
    {

        public string Namn { get; set; }

        public Feed(string namn)
        {
            Namn = namn;
        }

        public Feed() { }
    }

}
