﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForma2_Click(object sender, EventArgs e)
        {
            Form2 miforma2= new Form2();
            miforma2.ShowDialog();

            lblMensaje.Text = miforma2.Mensaje;
            lblContenido.Text = miforma2.Contenido;
        }
    }
}
