using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer;
using Models;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        KategoriController kategoriController;
        Validering validering;
        PodcastController podKontroller;
        Timer enTimer = new Timer();

        public Form1()

        {

            InitializeComponent();
            kategoriController = new KategoriController();
            podKontroller = new PodcastController();
            validering = new Validering();
            podKontroller = new PodcastController();
            fyllCbUppdatering();
            hamtaKategorier();
            FyllPodcasts();

            enTimer.Interval = 60000;
            enTimer.Tick += enTimer_Tick;

            enTimer.Start();


        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            if (validering.KategoriFinnsRedan(textBoxKategorier.Text))
            {
                kategoriController.skapaKategori(textBoxKategorier.Text);
                hamtaKategorier();
                textBoxKategorier.Clear();
            }
        }
        private void enTimer_Tick(object sender, EventArgs e)
        {
            podKontroller.KollaPodcastUppdatering();
            FyllPodcasts();
            //_ = forDrojning();
        }

        private void hamtaKategorier()
        {
            listBoxKategorier.Items.Clear();
            cbValdKategori.Items.Clear();

            foreach (var item in kategoriController.hamtaAllaKategorier())
            {
                if (item != null)
                {
                    listBoxKategorier.Items.Add(item.KategoriNamn);
                    cbValdKategori.Items.Add(item.KategoriNamn);
                    cbValdKategori.SelectedIndex = 0;
                }
            }
        }

        private void kategoriLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxKategorier.Text = ("");
        }

        private void fyllCbUppdatering()
        {
            cbUppdateringsfrekvens.Items.Add("10");
            cbUppdateringsfrekvens.Items.Add("30");
            cbUppdateringsfrekvens.Items.Add("60");
            cbUppdateringsfrekvens.SelectedIndex = 0;

        }

        private string getSelectedCat()
        {
            string selectedCat = "";

            if (listBoxKategorier.SelectedIndex != -1)
            {
                selectedCat = listBoxKategorier.SelectedItem.ToString();
            }

            return selectedCat;
        }

        private void listBoxKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnLaggTillPodd_Click(object sender, EventArgs e)
        {

            if (validering.HarComboboxVarde(cbValdKategori) && validering.HarComboboxVarde(cbUppdateringsfrekvens) &&
              validering.ArStrangNullEllerTom(txtBoxNamn.Text) && validering.ArStrangNullEllerTom(textBoxURL.Text) && validering.PoddnamnFinnsRedan(txtBoxNamn.Text))
            {
                dataGridAllaPoddar.Rows.Clear();


                await podKontroller.SkapaPodcast(textBoxURL.Text, txtBoxNamn.Text, cbValdKategori.SelectedItem.ToString(), cbUppdateringsfrekvens.SelectedItem.ToString());
                dataGridAllaPoddar.Rows.Clear();
                FyllPodcasts();
                //_ = forDrojning();

            }

            
        }

        async Task forDrojning()
        {
            await Task.Delay(2000);
            FyllPodcasts();
        }

        private void FyllPodcasts()
        {
            dataGridAllaPoddar.Rows.Clear();



            foreach (var pod in podKontroller.HamtaAllaPodcasts())
            {
                if (pod != null)
                {
                    var antalAvsnitt = pod.AntalAvsnitt.Count().ToString();
                    dataGridAllaPoddar.Rows.Add(antalAvsnitt, pod.Namn, pod.Kategori, pod.UppdateringsFrekvens, "0");
                }
            }

        }


        private void dataGridAllaPoddar_SelectionChanged(object sender, EventArgs e)
        {
            string feedNamn = dataGridAllaPoddar.CurrentRow.Cells[1].Value.ToString();
            string uppdateringsfrekvens = dataGridAllaPoddar.CurrentRow.Cells[3].Value.ToString();
            //txtBoxNamn.Text = feedNamn;

            HamtaAvsnittForValdPod();

        }


        private void HamtaAvsnittForValdPod()
        {
            listBoxAvsnitt.Items.Clear();
            string feedNamn = dataGridAllaPoddar.CurrentRow.Cells[1].Value.ToString();
            Pod valdPodNamn = podKontroller.HamtaFeed(feedNamn);


            foreach (Avsnitt avsnitt in valdPodNamn.AntalAvsnitt)
            {
                listBoxAvsnitt.Items.Add(avsnitt.Namn);
            }
        }

        private void listBoxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

            string feedNamn = dataGridAllaPoddar.CurrentRow.Cells[1].Value.ToString();
            Pod valdPodNamn = podKontroller.HamtaFeed(feedNamn);

            textBoxBeskrivning.Text = valdPodNamn.AntalAvsnitt[listBoxAvsnitt.SelectedIndex].AvsnittsBeskrivning;

        }

        private void btnUppdateraPoddlsita_Click_1(object sender, EventArgs e)
        {
            if (validering.HarComboboxVarde(cbValdKategori) && validering.HarComboboxVarde(cbUppdateringsfrekvens) &&
              validering.ArStrangNullEllerTom(txtBoxNamn.Text) && validering.ArStrangNullEllerTom(textBoxURL.Text))
            {
                string hamtaRad = dataGridAllaPoddar.CurrentRow.Cells[1].Value.ToString();
                Pod valdPodcast = podKontroller.HamtaFeed(hamtaRad);
                string basNamn = valdPodcast.Namn;
                int basNamnIndex = podKontroller.HamtaIndexMedNamn(basNamn);

                DateTime uppdatering = DateTime.Now;
                podKontroller.UppdateraPodcast(basNamnIndex, txtBoxNamn.Text, textBoxURL.Text, cbUppdateringsfrekvens.SelectedItem.ToString(), uppdatering, cbValdKategori.SelectedItem.ToString());
                FyllPodcasts();
               
                _ = forDrojning();

            }
        }

        private void btnTaBortPodd_Click(object sender, EventArgs e)
        {
            try
            {
                int valtIndex = dataGridAllaPoddar.CurrentCell.RowIndex;
                if (valtIndex > -1)
                {
                    if (DialogResult.Yes == MessageBox.Show("Vill du ta bort podden ?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        string namnTaBort = dataGridAllaPoddar.Rows[valtIndex].Cells[1].Value.ToString();
                        podKontroller.TaBortPod(namnTaBort);
                        dataGridAllaPoddar.Rows.RemoveAt(valtIndex);
                        dataGridAllaPoddar.ClearSelection();
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Kan inte ta bort vald rad, välj raden och försök igen");
            }
        }

        private void btnUppdateraKategorier_Click(object sender, EventArgs e)
        {
            if (listBoxKategorier.SelectedIndex >= 0 && validering.ArStrangNullEllerTom(textBoxKategorier.Text))
            {
                string nyttKatNamn = textBoxKategorier.Text;
                string valdKategori = listBoxKategorier.SelectedItem.ToString();

                int katIndex = kategoriController.hamtaKategoriIndex(valdKategori);
                Kategori nyKategori = new Kategori(nyttKatNamn);
                var poddarSomSkaUppdateras = podKontroller.HamtaAllaPodcasts().Where(pod => String.Equals(pod.Kategori, valdKategori, StringComparison.OrdinalIgnoreCase));

                kategoriController.UppdateraKategori(katIndex, nyKategori);

                foreach (Pod pod in poddarSomSkaUppdateras)
                {
                    int index = podKontroller.HamtaIndexMedNamn(pod.Namn);
                    podKontroller.UppdateraPodcast(index, pod.Namn, pod.AngivetUrl, pod.UppdateringsFrekvens, pod.TidForUppdatering, nyttKatNamn);
                }

                hamtaKategorier();
                FyllPodcasts();
                _ = forDrojning();

            }
        }

        private void lblLaggTillPodd_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}