﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sepete_Ekle_manav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Add(txtManav.Text);
            txtManav.Text = "";
        }

        private void txtManav_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Clear();
        }

        private void btnSecilenisil_Click(object sender, EventArgs e)
        {

            lstSepet.Items.Remove(lstSepet.SelectedItem);
        }
    }
}
