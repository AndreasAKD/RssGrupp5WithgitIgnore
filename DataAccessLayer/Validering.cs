﻿using System;
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
                MessageBox.Show("Ett textfält är tomt! /n Vänligen fyll i alla fält.");
            }

            else
            {
                varde = true;
            }
            return varde;
        }







    }
}
