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
        public Form1()
        {

            InitializeComponent();
            hamtaKategorier();

        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            KategoriController.skapaKategori(textBoxKategorier.Text);
            hamtaKategorier();
            textBoxKategorier.Clear();
        }
    }
}
