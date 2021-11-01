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
using DataAccessLayer.Exceptions;
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
        private async void enTimer_Tick(object sender, EventArgs e)
        {
            await podKontroller.KollaPodcastUppdatering();

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



        private void fyllCbUppdatering()
        {
            cbUppdateringsfrekvens.Items.Add("60");
            cbUppdateringsfrekvens.Items.Add("120");
            cbUppdateringsfrekvens.Items.Add("180");
            cbUppdateringsfrekvens.SelectedIndex = 0;

        }


        private async void btnLaggTillPodd_Click(object sender, EventArgs e)
        {
            try {
                if (validering.HarComboboxVarde(cbValdKategori) && validering.HarComboboxVarde(cbUppdateringsfrekvens) &&
                  validering.ArStrangNullEllerTom(txtBoxNamn.Text) && validering.ArStrangNullEllerTom(textBoxURL.Text) && validering.PoddnamnFinnsRedan(txtBoxNamn.Text) && validering.UrlFinnsRedan(textBoxURL.Text) && validering.UrlValidering(textBoxURL.Text))
                {
                    string valtNamn = txtBoxNamn.Text;
                    string nyttUrl = textBoxURL.Text;
                    dataGridAllaPoddar.Rows.Clear();
                    dataGridAllaPoddar.ClearSelection();

                    await podKontroller.SkapaPodcast(nyttUrl, valtNamn, cbValdKategori.SelectedItem.ToString(), cbUppdateringsfrekvens.SelectedItem.ToString());
                    dataGridAllaPoddar.Rows.Clear();
                    txtBoxNamn.Clear();
                    textBoxURL.Clear();
                    FyllPodcasts();

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Fel på din URL");
                
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
                    dataGridAllaPoddar.Rows.Add(antalAvsnitt, pod.Namn, pod.Kategori, pod.UppdateringsFrekvens);
                }
            }

        }

        private void SkrivUtSparade(string kat)
        {
            foreach (Pod podd in podKontroller.HamtaAllaPodKategori(kat))
                hamtaPodcastsKategori(podd.Namn);

        }


        private void dataGridAllaPoddar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridAllaPoddar.Rows.Count > 0)
            {
                string feedNamn = dataGridAllaPoddar.CurrentRow.Cells[1].Value.ToString();

                Pod valdPodNamn = podKontroller.HamtaFeed(feedNamn);
                string URLet = valdPodNamn.AngivetUrl;
                string namnPod = valdPodNamn.Namn;

                textBoxURL.Text = (URLet);
                txtBoxNamn.Text = (namnPod);

                HamtaAvsnittForValdPod();

            }
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

        private async void btnUppdateraPoddlsita_Click_1(object sender, EventArgs e)
        {
            if (validering.HarComboboxVarde(cbValdKategori) && validering.HarComboboxVarde(cbUppdateringsfrekvens) &&
              validering.ArStrangNullEllerTom(txtBoxNamn.Text) && validering.ArStrangNullEllerTom(textBoxURL.Text) && validering.UrlFinnsRedan(textBoxURL.Text) && validering.UrlValidering(textBoxURL.Text))
            {
                
                string nyttNamn = txtBoxNamn.Text;
                string nyttUrl = textBoxURL.Text;
                //string hamtaRad = dataGridAllaPoddar.CurrentRow.Cells[1].Value.ToString();
                dataGridAllaPoddar.Rows.Clear();
                Pod valdPodcast = podKontroller.HamtaFeedUrl(nyttUrl);
                string basNamn = valdPodcast.Namn;
                int basNamnIndex = podKontroller.HamtaIndexMedNamn(basNamn);
                

                DateTime uppdatering = DateTime.Now;
                dataGridAllaPoddar.ClearSelection();
                
                await podKontroller.UppdateraPodcast(basNamnIndex, nyttNamn, nyttUrl, cbUppdateringsfrekvens.SelectedItem.ToString(), uppdatering, cbValdKategori.SelectedItem.ToString());
                
                FyllPodcasts();
                
                
                
                

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
                        listBoxAvsnitt.Items.Clear();
                        
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Kan inte ta bort vald rad, välj raden och försök igen");
            }
        }

        private async void btnUppdateraKategorier_Click(object sender, EventArgs e)
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
                    await podKontroller.UppdateraPodcast(index, pod.Namn, pod.AngivetUrl, pod.UppdateringsFrekvens, pod.TidForUppdatering, nyttKatNamn);
                }
                txtBoxNamn.Clear();
                hamtaKategorier();
                FyllPodcasts();
                _ = forDrojning();

            }
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxKategorier.SelectedItem != null)
                {
                    string kategoriNamn = listBoxKategorier.SelectedItem.ToString();

                    if (DialogResult.Yes == MessageBox.Show
                   ("Vill du verkligen ta bort denna kategori med tillhörande poddar?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        dataGridAllaPoddar.ClearSelection();
                        listBoxKategorier.Items.Remove(listBoxKategorier.SelectedItem);
                        cbValdKategori.Items.Remove(kategoriNamn);

                        podKontroller.TaBortPodavKategori(kategoriNamn);
                        kategoriController.TaBortKategori(kategoriNamn);
                        dataGridAllaPoddar.Rows.Clear();
                        FyllPodcasts();
                    }
                }
                else
                {
                    MessageBox.Show("Du måste välja en kategori");
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Försök igen");
            }
        }



        private void btnVirtualPodcast_Click(object sender, EventArgs e)
        {
            string SkrivUtPodOverride = podKontroller.hamtaVirtualTestPod();




            MessageBox.Show(SkrivUtPodOverride);
        }

        private void btnVirtualAvsnitt_Click(object sender, EventArgs e)
        {
            string SkrivUtAvsnittOverride = podKontroller.hamtaVirtualTestAvsnitt();




            MessageBox.Show(SkrivUtAvsnittOverride);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FyllPodcasts();
        }

        private void btnFiltreraKategorier_Click(object sender, EventArgs e)
        {
            if (listBoxKategorier.SelectedItem != null)
            {
                textBoxKategorier.Text = listBoxKategorier.SelectedItem.ToString();
                string namnKatValt = listBoxKategorier.SelectedItem.ToString();
                dataGridAllaPoddar.Rows.Clear();
                SkrivUtSparade(namnKatValt);
                listBoxKategorier.ClearSelected();
            }
        }

        private void hamtaPodcastsKategori(string namn)
        {
            
            Pod podd = podKontroller.HamtaFeed(namn);
            var antalAvsnitt = podd.AntalAvsnitt.Count().ToString();
            dataGridAllaPoddar.Rows.Add(antalAvsnitt, podd.Namn, podd.Kategori, podd.UppdateringsFrekvens);
        }



     
    }

    }
