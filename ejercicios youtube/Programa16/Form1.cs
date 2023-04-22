﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAlimentos.Items.Add("Lechuga");
            cmbAlimentos.Items.Add("Leche");


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cmbAlimentos.Items.Add(txtAlimento.Text);
        }

        private void cmbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbAlimentos.SelectedIndex;

            lblIndice.Text = indice.ToString();

            lblIndice.Text= cmbAlimentos.Items[indice].ToString();

        }
    }
}
