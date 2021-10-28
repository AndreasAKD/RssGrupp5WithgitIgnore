using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class Validering
    {

        public bool ArStrangNullEllerTom (string text)
        {
            bool varde = false;
            if(String.IsNullOrEmpty(text))
            {
                varde = false;
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
                cbVarde = false;
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
            bool namnFinns = false;


            return namnFinns;
        }


    }
}
