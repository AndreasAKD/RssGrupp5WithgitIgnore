using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer.Repositories;
using DataAccessLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class KategoriController
    {

        IRepository<Kategori> kategoriRepository;
        Validering validering;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
            validering = new Validering();
        }

        public List<Kategori> hamtaAllaKategorier()
        {
            return kategoriRepository.HamtaAlla();
        }

        public void skapaKategori(string name)
        {
            if (validering.ArStrangNullEllerTom(name))
            {
                Kategori nyKategori = new Kategori(name);
                kategoriRepository.Skapa(nyKategori);
            }
            else
            {
                MessageBox.Show("Du måste välja ett namn till din nya Kategori");
            }
        }

        public int hamtaKategoriIndex(string name)
        {
            int index = kategoriRepository.hamtaIndexAvNamn(name);
            return index;
        }

        public void UppdateraKategori (int index, Kategori kategori)
        {
            kategoriRepository.UppdateraPodd(index, kategori);
        }

    }
}
