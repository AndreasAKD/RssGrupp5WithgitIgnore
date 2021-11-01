using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Repositories;
using Models;

namespace DataAccessLayer
{
    public class Validering
    {
        PodcastRepository podcastRepo;
        KategoriRepository kategoriRepository;

        public Validering()
        {
            podcastRepo = new PodcastRepository();
            kategoriRepository = new KategoriRepository();
        }

        public bool ArStrangNullEllerTom (string text)
        {
            bool varde = false;
            if(String.IsNullOrEmpty(text))
            {
                
                MessageBox.Show("Ett textfält är tomt! Vänligen fyll i alla fält.");
            }

            else
            {
                varde = true;
            }
            return varde;
        }


        public bool HarComboboxVarde(ComboBox cb)
        {
            bool cbVarde = false;
            if (cb.SelectedIndex == -1)
            {
                
                MessageBox.Show("Se till att välja både en kategori och uppdateringsfrekvens!");
            }

            else
            {
                cbVarde = true;
            }
            return cbVarde;
        }

        public bool PoddnamnFinnsRedan(string namn)
        {
            bool namnFinnsInte = true;
            var allaPoddar = podcastRepo.HamtaAlla();

            for (int i = 0; i < allaPoddar.Count; i++)
            {
                if (allaPoddar[i].Namn.Contains(namn))
                    namnFinnsInte = false;
            }
            
            if (!namnFinnsInte)
            {
                MessageBox.Show("Det finns redan en podcast med detta namn! Vänligen välj ett unikt namn.");
            }

            return namnFinnsInte;
        }

        public bool UrlFinnsRedan(string url)
        {
            bool urlFinnsInte = true;
            var allaPoddar = podcastRepo.HamtaAlla();

            for (int i = 0; i < allaPoddar.Count; i++)
            {
                if (allaPoddar[i].AngivetUrl.Contains(url))
                    urlFinnsInte = false;
            }

            if (!urlFinnsInte)
            {
                MessageBox.Show("Det finns redan en podcast med detta URL! Vänligen välj ett unikt URL.");
            }

            return urlFinnsInte;
        }

        public bool UrlValidering(string url)
        {
            Uri uriResult;
            bool stammer = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                           && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!stammer)
            {
                MessageBox.Show("Den URL du angivet har något fel!");
            }
            return stammer;
        }

        public bool KategoriFinnsRedan(string katNamn)
        {
            bool namnFinnsInte = true;
            var allaKategorier = kategoriRepository.HamtaAlla();

            for (int i = 0; i < allaKategorier.Count; i++)
            {
                if (allaKategorier[i].KategoriNamn.Contains(katNamn))
                    namnFinnsInte = false;
            }

            if (!namnFinnsInte)
            {
                MessageBox.Show("Det finns redan en kategori med detta namn! Vänligen välj ett unikt namn.");
            }

            return namnFinnsInte;
        }


    }
}
