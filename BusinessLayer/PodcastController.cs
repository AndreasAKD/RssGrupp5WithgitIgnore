using DataAccessLayer;
using DataAccessLayer.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class PodcastController
    {
        Validering validering;
        PodcastRepository podcastRepo;
        public PodcastController()
        {
            validering = new Validering();
            podcastRepo = new PodcastRepository();
        }

        public async 
        Task
        SkapaPodcast(string url, string namn, string kategori, string updIntervall)
        {
            if (validering.ArStrangNullEllerTom(namn) && validering.ArStrangNullEllerTom(url))
            {
                List<Avsnitt> avsnitt = await podcastRepo.HamtaAvsnitt(url);
                DateTime uppdateringsTid = DateTime.Now;
                Pod podcast = new Pod(namn, url, updIntervall, uppdateringsTid, kategori, avsnitt);
                podcastRepo.Skapa(podcast);
            }
        }

        public async Task UppdateraPodcast(string namn)
        {
            Pod uppdateradPodcast = HamtaFeed(namn);
            int indexAvPodcast = podcastRepo.hamtaIndexAvNamn(namn);

            uppdateradPodcast.TidForUppdatering = DateTime.Now.AddSeconds(Int32.Parse(HamtaFeed(namn).UppdateringsFrekvens));
            uppdateradPodcast.AntalAvsnitt = await podcastRepo.HamtaAvsnitt(uppdateradPodcast.AngivetUrl);

            podcastRepo.UppdateraPodd(indexAvPodcast, uppdateradPodcast);

        }

        public async Task UppdateraPodcast(int index, string nyttNamn, string nyttUrl, string nyUpdFrekvens, DateTime nyUppdatering, string nyKategori)
        {

            List<Avsnitt> avsnitt = await podcastRepo.HamtaAvsnitt(nyttUrl);
            Pod nyPodcast = new Pod(nyttNamn, nyttUrl, nyUpdFrekvens, nyUppdatering, nyKategori, avsnitt);
            podcastRepo.UppdateraPodd(index, nyPodcast);
        }


        public void TaBortPodavKategori(string katNamn)
        {
            List<Pod> poddarAvKategori = new List<Pod>();
            int langd = podcastRepo.HamtaAlla().Count;
            for (int i = 0; i < langd; i++)
            {
                if (string.Equals(podcastRepo.HamtaAlla()[i].Kategori, katNamn, StringComparison.OrdinalIgnoreCase))
                {
                    poddarAvKategori.Add(podcastRepo.HamtaAlla()[i]); 
                }
            
            }
            foreach (Pod podd in poddarAvKategori)
            {
                TaBortPod(podd.Namn);

            }
        }

        public void TaBortPod(string namn)
        {
            int taBortIndex = -1;
            int langd = podcastRepo.HamtaAlla().Count;
            for (int i = 0; i < langd; i++)
            {
                if (string.Equals(podcastRepo.HamtaAlla()[i].Namn, namn, StringComparison.OrdinalIgnoreCase))
                    taBortIndex = i;
            }

            if (taBortIndex > -1)
                podcastRepo.TaBort(taBortIndex);

        }

        public async Task KollaPodcastUppdatering()
        {

            foreach (Pod podcast in podcastRepo.HamtaAlla())
            {
                if (podcast.KollaUppdatering)
                {
                    await UppdateraPodcast(podcast.Namn);
                }
            }
        }

        public List<Pod> HamtaAllaPodcasts()
        {
            return podcastRepo.HamtaAlla();
        }

        public List<Pod> HamtaAllaPodKategori(string kategori)
        {
            return (podcastRepo.HamtaAlla().Where(podd => string.Equals(podd.Kategori, kategori, StringComparison.OrdinalIgnoreCase))).ToList();
        }

        public Pod HamtaFeed(string namn)
        {
            return podcastRepo.HamtaAlla().Where(pod => string.Equals(pod.Namn, namn, StringComparison.OrdinalIgnoreCase)).First();
        }

        public Pod HamtaFeedUrl(string url)
        {
            return podcastRepo.HamtaAlla().Where(pod => string.Equals(pod.AngivetUrl, url, StringComparison.OrdinalIgnoreCase)).First();
        }

        public string hamtaVirtualTestPod()
        {
            string hamtat = podcastRepo.hamtaVirtualTest();
            return hamtat;
        }

        public string hamtaVirtualTestAvsnitt()
        {
            string hamtat = podcastRepo.hamtaVirtualTestAvsnitt();
            return hamtat;
        }



        public int HamtaIndexMedNamn(string namn)
        {
            int index = podcastRepo.hamtaIndexAvNamn(namn);
            return index;
        }




    }
}