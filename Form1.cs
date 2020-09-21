using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrtanjePravougaonika_Domaci
{
    public partial class Form1 : Form
    {
        int X, Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen olovka = new Pen(Color.Black, 1);

            g.DrawRectangle(olovka, X, Y, Math.Abs(e.X - X), Math.Abs(e.Y - Y));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }
    }
}
