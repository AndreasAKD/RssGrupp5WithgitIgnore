using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer.Exceptions;
using DataAccessLayer;

namespace DataAccessLayer.Repositories
{
    public class KategoriRepository : IKategoriRepository<Kategori>
    {
        SerializerForXml serializerForXml;
        List<Kategori> kategoriLista;

        public KategoriRepository()
        {
            kategoriLista = new List<Kategori>();
            serializerForXml = new SerializerForXml();
            kategoriLista = HamtaAlla();
        }


        public List<Kategori> HamtaAlla()
        {

            List<Kategori> KategoriListaReturn = new List<Kategori>();

            try
            {
                if (KategoriListaReturn != null)
                {
                    KategoriListaReturn = serializerForXml.KategoriDeserializera();
                }
            }
            catch (KanInteSerializeraException)
            {
                Console.WriteLine("kunde inte deserialize:a category.xml");
            }


            return KategoriListaReturn;

        }

        public void Create(Kategori entity)
        {
            kategoriLista.Add(entity);
            SparaAndringar();
        }

        public void SparaAndringar()
        {
            try
            {
                serializerForXml.KategoriSerializera(kategoriLista);
            }
            catch (KanInteSerializeraException)
            {
                Console.WriteLine("kunde inte serialize:a category.xml");
            }
        }

        public int hamtaIndexAvNamn(string name)
        {
            return HamtaAlla().FindIndex(e => e.KategoriNamn.Equals(name));
        }

        public void Skapa(Kategori entity)
        {
            kategoriLista.Add(entity);
            SparaAndringar();
        }
        public void TaBort(int index)
        {
            kategoriLista.RemoveAt(index);
            SparaAndringar();
        }

        public void Updatera(int index, Kategori newEntity)
        {
            if (index >= 0)
            {
                kategoriLista[index] = newEntity;
            }
            SparaAndringar();
        }


    }
}
