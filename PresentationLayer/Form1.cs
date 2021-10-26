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

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        KategoriController kategoriController;

        public Form1()

        {

            InitializeComponent();
            
            kategoriController = new KategoriController();
            hamtaKategorier();
            cbUppdateringsfrekvens.Items.Add("10");

        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            kategoriController.skapaKategori(textBoxKategorier.Text);
            hamtaKategorier();
            textBoxKategorier.Clear();
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

        private void btnUppdateraKategorier_Click(object sender, EventArgs e)
        {

        }

        private void btnLaggTillPodd_Click(object sender, EventArgs e)
        {

        }
    }
}
