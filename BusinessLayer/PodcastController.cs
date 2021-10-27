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
                Pod podcast = new Pod(namn, url, updIntervall, kategori, avsnitt);
                podcastRepo.Skapa(podcast);
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

        //public Feed GetFeedURL(string namn)
        //{
        //    return podcastRepo.HamtaAlla().Where(feed => string.Equals(feed.AngivetUrl, , StringComparison.OrdinalIgnoreCase)).First();
        //}
    }
}
