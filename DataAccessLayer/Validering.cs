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

        public Validering()
        {
            podcastRepo = new PodcastRepository();
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


    }
}
