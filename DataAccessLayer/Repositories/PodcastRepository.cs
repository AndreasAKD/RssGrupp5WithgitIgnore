using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Models;
using DataAccessLayer.Exceptions;

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
            poddLista = HamtaAlla();
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
            List<Pod> podcastLista = new List<Pod>();


            try
            {
                
                    podcastLista = dataHanterare.PodDeserializera();
                
        }

           catch (Exception)
           {
               throw new KanInteSerializeraException();
            }
            return podcastLista;
        }

        public void SparaAndringar()
        {
            dataHanterare.PodSerializera(poddLista);
        }

        public void UppdateraPodd(int index, Pod newEntity)
        {
            if (index >= 0)
            {
                poddLista[index] = newEntity;
                SparaAndringar();
            }

        }

        public async Task<List<Avsnitt>> HamtaAvsnitt(string url)
        {
            XmlReader xmlLasare = XmlReader.Create(url);
            SyndicationFeed feed = await Task.Run(() => SyndicationFeed.Load(xmlLasare));
            List<Avsnitt> allaAvsnitt = new List<Avsnitt>();

            foreach (var i in feed.Items)
            {
                Avsnitt avsnitt = new Avsnitt(i.Title.Text, i.Summary.Text);
                allaAvsnitt.Add(avsnitt);
            }

            return allaAvsnitt;
        }

        public int hamtaIndexAvNamn(string namn)
        {
            int hamtatIndex = HamtaAlla().FindIndex(p => p.Namn.Equals(namn));
            return hamtatIndex;
        }

        public string hamtaVirtualTest()
        {
            Pod podden = new Pod();
            string hamtadPod = podden.VirtualReturnTest();
            return hamtadPod;
        }

        public string hamtaVirtualTestAvsnitt()
        {
            Avsnitt avsnittet = new Avsnitt();
            string hamtadAvsnitt = avsnittet.VirtualReturnTest();
            return hamtadAvsnitt;
        }
    }
}
