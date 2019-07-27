using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }
        // MM2
        private void button1_Click(object sender, EventArgs e)
        {
            MM1 mm1 = new MM1();
            mm1.probabilidades();
        }

        //Dos Canales
        private void button2_Click(object sender, EventArgs e)
        {
            MM1_2Canales m2c = new MM1_2Canales();
            m2c.probabilidades();

        }
        // MM1
        private void button3_Click(object sender, EventArgs e)
        {
            MM1 mm1 = new MM1();
            mm1.probabilidades();
            GraficoMM1 g = new GraficoMM1();
            g.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Datos d = new Datos();
            d.aleatorio();
        }
    }
}
