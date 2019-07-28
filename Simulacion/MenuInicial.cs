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
        //Instancia de los Datos.
        Datos d = new Datos();

        public MenuInicial()
        {
            InitializeComponent();
            d.GeneracionAleatorios();            
        }
        
        // MM2
        private void btnMM2(object sender, EventArgs e)
        {
            MMS mms = new MMS();
            mms.probabilidades();
            
            for (int i = 0; i < 1000; i++)
            {
                //Tiempo entre llegadas en el menu inicial.
                mms.tiempoentrellegadas[i] = d.T_E_LL_MMS[i];
                mms.tiempodeservicio[i] = d.T_D_S_MMS[i];
            }
            GraficoMMS gmms = new GraficoMMS();
            gmms.Visible = true;
            mms.T_E_LLegadas();
            mms.T_D_Servicio();
        }

        //Dos Canales
        private void btn2Canales(object sender, EventArgs e){
            MM1_2Canales m2c = new MM1_2Canales();
            m2c.probabilidades();
            for (int i = 0; i < 1000; i++){
                //Tiempo entre llegadas en el menu inicial.
                m2c.tiempoentrellegadas[i] = d.T_E_LL_M2C[i];
                m2c.tiempodeservicio[i] = d.T_D_S_M2C[i];
            }
            Grafico2C1S gm2c = new Grafico2C1S();
            gm2c.Visible = true;
            m2c.T_E_LLegadas();
            m2c.T_D_Servicio();
        }
        
        // MM1
        private void btnMM1(object sender, EventArgs e){
            MM1 mm1 = new MM1();
            mm1.probabilidades();
            for (int i = 0; i < 1000; i++){
                //Tiempo entre llegadas en el menu inicial.
                mm1.tiempoentrellegadas[i] = d.T_E_LL_MM1[i];
                mm1.tiempodeservicio[i] = d.T_D_S_MM1[i];
            }
            GraficoMM1 gmm1 = new GraficoMM1();
            gmm1.Visible = true;
            mm1.T_E_LLegadas();
            mm1.T_D_Servicio();
        }
        // Aleatorios
        private void btnAleatorios(object sender, EventArgs e){
            Datos d = new Datos();
            d.GeneracionAleatorios();
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            
        }
    }
}
