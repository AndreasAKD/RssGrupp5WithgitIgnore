using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;
using DataAccessLayer.Exceptions;



namespace DataAccessLayer
{
    public class SerializerForXml
    {
        public void PodSerializera(List<Pod> poddar)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(poddar.GetType());
                using (FileStream skapaXmlPod = new FileStream("podcasts.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(skapaXmlPod, poddar);
                }
            }
            catch (Exception)
            {
                throw new KanInteSerializeraException();
            }

        }


        public List<Pod> PodDeserializera()
        {
            try
            {
                List<Pod> poddLista;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pod>));
                using (FileStream oppnaXml = new FileStream("podcasts.xml", FileMode.Open, FileAccess.Read))
                {
                    poddLista = (List<Pod>)xmlSerializer.Deserialize(oppnaXml);
                }
                return poddLista;
            }
            catch (Exception)
            {
                throw new KanInteSerializeraException();

            }
        }

        public void KategoriSerializera(List<Kategori> kategoriLista)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(kategoriLista.GetType());
            using (FileStream xmlKategori = new FileStream("kategorier.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(xmlKategori, kategoriLista);
                }
            }
            catch (Exception)
            {
                throw new KanInteSerializeraException();
            }

        }

        public List<Kategori> KategoriDeserializera()
        {

            try
            {
                List<Kategori> kategoriLista;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream oppnaXmlKategori = new FileStream("kategorier.xml", FileMode.Open, FileAccess.Read))
                {
                    kategoriLista = (List<Kategori>)xmlSerializer.Deserialize(oppnaXmlKategori);
                }
                return kategoriLista;
            }
            catch (Exception)
            {
                throw new KanInteSerializeraException();

            }
        }
    }
}

