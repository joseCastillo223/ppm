﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Ejemplo 1
            //Dibujamos un arco
            g.DrawArc(Pens.Coral, new Rectangle(50, 50, 100, 100), 45, 180);

            ////Dibujamos una linea 
            g.DrawLine(Pens.Blue, 125, 25, 150, 200);

            ////Dibujamos un rectangulo
            g.DrawRectangle(Pens.Orange, new Rectangle(75, 75, 200, 25));

            ////Dibujamos una serie de lineas 
            Point[] puntos = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.DrawLines(Pens.Green, puntos);

            ////Fin de ejemplo 1

            ////Ejemplo 2
            ////Dibuja Bezier con cuatro puntos
            g.DrawBezier(Pens.Blue, 100, 100, 130, 175, 147, 20, 200, 230);

            ////Dibuja una curva cerrada

            Point[] puntos2 = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.DrawClosedCurve(Pens.Red, puntos2);

            ////Dibujamos una curva 
            Point[] puntos3 = { new Point(10, 25), new Point(50, 200), new Point(150, 230) };
            g.DrawCurve(Pens.Purple, puntos3);

            ////Dibujamos un segmento de pie
            g.DrawPie(Pens.Green, new Rectangle(100, 100, 100, 100), 30, 90);

            ////Dibujamos un poligono 
            Point[] puntos4 = { new Point(10, 175), new Point(70, 50), new Point(150, 30) };
            g.DrawPolygon(Pens.Orange, puntos4);

            ////Fin de ejemplo 2
                 


        }
    }
}

