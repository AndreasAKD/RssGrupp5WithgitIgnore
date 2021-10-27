﻿using System;
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
            cbUppdateringsfrekvens.Items.Add("10");
            validering = new Validering();
            podKontroller = new PodcastController();
            hamtaKategorier();
            FyllPodcasts();

            enTimer.Interval = 10000;
            enTimer.Tick += enTimer_Tick;
            //enTimer.Start();
            // Vid timer så kastas felet "Index låg utanför intervallet. Det får inte vara negativt och måste vara mindre än mängdens storlek."
            //När den ska uppdatera podcasten i metoden "UppdateraPodd" i PodcastRepository
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            kategoriController.skapaKategori(textBoxKategorier.Text);
            hamtaKategorier();
            textBoxKategorier.Clear();
        }
        private void enTimer_Tick(object sender, EventArgs e)
        {
            podKontroller.KollaPodcastUppdatering();
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

        private void btnLaggTillPodd_Click(object sender, EventArgs e)
        {
            if (validering.HarComboboxVarde(cbValdKategori))
            {
                dataGridAllaPoddar.Rows.Clear();
               
                podKontroller.SkapaPodcast(textBoxURL.Text, txtBoxNamn.Text, cbValdKategori.SelectedItem.ToString(), cbUppdateringsfrekvens.SelectedItem.ToString());

                //FyllPodcasts();
                _ = forDrojning();

            }

            else
            {
                MessageBox.Show("Ingen kategori är vald. Vänligen välj en kategori. /n Om ingen kategori finns så måste du skapa en först.");
            }
        }

        async Task forDrojning()
        {
            await Task.Delay(200);
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
            txtBoxNamn.Text = feedNamn;
            
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
    }
}
