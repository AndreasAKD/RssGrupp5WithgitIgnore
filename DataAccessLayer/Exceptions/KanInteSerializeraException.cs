using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Exceptions
{
    public class KanInteSerializeraException : Exception
    {
        public KanInteSerializeraException() : base("Kan inte serializera")
        {
            
        }



    }
}
