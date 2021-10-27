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

        public async void SkapaPodcast(string url, string namn, string kategori, string updIntervall)
        {
            if (validering.ArStrangNullEllerTom(namn) && validering.ArStrangNullEllerTom(url))
            {
                List<Avsnitt> avsnitt = await podcastRepo.HamtaAvsnitt(url);
                DateTime uppdateringsTid = DateTime.Now;
                Pod podcast = new Pod(namn, url, updIntervall, uppdateringsTid, kategori, avsnitt);
                podcastRepo.Skapa(podcast);
            }
        }

        public void UppdateraPodcast(string namn)
        {
            HamtaFeed(namn).TidForUppdatering = DateTime.Now.AddSeconds(Int32.Parse(HamtaFeed(namn).UppdateringsFrekvens));
            Pod uppdateradPodcast = HamtaFeed(namn);
            int indexAvPodcast = podcastRepo.hamtaIndexAvNamn(namn);
            podcastRepo.UppdateraPodd(indexAvPodcast, uppdateradPodcast);

        }

        public void KollaPodcastUppdatering()
        {
            foreach (Pod podcast in podcastRepo.HamtaAlla())
            {
                if (podcast.KollaUppdatering)
                {
                    UppdateraPodcast(podcast.Namn);
                }
            }
        }

        public List<Pod> HamtaAllaPodcasts()
        {
            return podcastRepo.HamtaAlla();
        }

        public Pod HamtaFeed(string namn)
        {
            return podcastRepo.HamtaAlla().Where(pod => string.Equals(pod.Namn, namn, StringComparison.OrdinalIgnoreCase)).First();
        }


    }
}
