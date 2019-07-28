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
        Datos d = new Datos();
        public MenuInicial()
        {
            InitializeComponent();
            d.GeneracionAleatorios();            
        }
        // MM2
        private void btnMM2(object sender, EventArgs e)
        {
            MMS mm2 = new MMS();
            mm2.probabilidades();
            GraficoMMS gmms = new GraficoMMS();
            gmms.Visible = true;
        }

        //Dos Canales
        private void button2_Click(object sender, EventArgs e)
        {
            MM1_2Canales m2c = new MM1_2Canales();
            m2c.probabilidades();
            Grafico2C1S gm2c = new Grafico2C1S();
            gm2c.Visible = true;
            

        }
        // MM1
        private void btnMM1(object sender, EventArgs e)
        {
            MM1 mm1 = new MM1();
            mm1.probabilidades();
            for (int i = 0; i < 1000; i++)
            {
                mm1.tiempoentrellegadas[i] = d.a[i];
                Console.WriteLine("Tiempo entre llegadas desde menu inicial "+ d.a[i]);
            }
            GraficoMM1 gmm1 = new GraficoMM1();
            gmm1.Visible = true;
            mm1.T_E_LLegadas();
            

        }

        private void btnAleatorios(object sender, EventArgs e)
        {
            Datos d = new Datos();
            d.GeneracionAleatorios();
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            
        }
    }
}
