using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer.Repositories
{
    public class PodcastRepository : IPodcastRepository<Pod>
    {

        List<Pod> poddLista;
        SerializerForXml dataHanterare;
       

        public PodcastRepository()
        {
            poddLista = new List<Pod>();
            dataHanterare = new SerializerForXml();
        }

        public void Skapa(Pod entity)
        {
            poddLista.Add(entity);
            SparaAndringar();
        }

        public void TaBort(int index)
        {
            poddLista.RemoveAt(index);
            SparaAndringar();
        }

        public List<Pod> HamtaAlla()
        {
            throw new NotImplementedException();
        }

        public void SparaAndringar()
        {
            dataHanterare.PodSerializera(poddLista);
        }

        public void Updatera(int index, Pod newEntity)
        {
            poddLista[index] = newEntity;
            SparaAndringar();
        }
    }
}
