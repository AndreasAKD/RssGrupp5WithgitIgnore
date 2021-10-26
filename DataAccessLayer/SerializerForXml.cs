using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;



namespace DataAccessLayer
{
    public class SerializerForXml
    {
        public void PodSerializera(List<Pod> poddar)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pod>));
                using (FileStream skapaXmlPod = new FileStream("podcasts.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(skapaXmlPod, poddar);
                }
            }
            catch (Exception)
            {
                //throw new SerializerException("poddar.xml", "Kan inte serializera xml för podcast");
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
                //throw new SerializerException("poddar.xml", "Kan inte deserializera xml för podcast");
            }
        }

        public void KategoriSerializera(List<Kategori> kategoriLista)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream skapaXmlKategori = new FileStream("kategorier.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(skapaXmlKategori, kategoriLista);
                }
            }
            catch (Exception)
            {
                //throw new SerializerException("kategorier.xml", "Kan inte deserializera xml för kategori");
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
                //throw new SerializerException("categories.xml", "could not deserialize");
            }
        }
    }
}

