﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa42
{
    public partial class Form3 : Form
    {
        private int x=0; private int y=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            //Obtenemos el objeto graphics
            Graphics g = e.Graphics;

            //Creamos una fuente
            Font fuente = new Font("Times New Roman", 35);

            //Dibujamos un texto
            g.DrawString("Hola a todos", fuente, Brushes.Red, x, y);

        }

        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            x += 5;
            y += 17;

            Invalidate();

        }

        private void btnDibuja_Click(object sender, EventArgs e)
        {
            //Obtenemos el objeto graphics
            Graphics g = Graphics.FromHwnd(this.Handle);

            //Creamos una fuente
            Font fuente = new Font("Times New Roman", 35);

            //Dibujamos un texto
            g.DrawString("En metodo", fuente, Brushes.Green, 50, 75);

            //Tenemos que liberar los recursos no administrados
            //Si los creamos directamente hacemos dispose
            // Si es una referencia a un objeto graphics ya existente
            // No hace falta dispose

            g.Dispose();

        }
    }
}
