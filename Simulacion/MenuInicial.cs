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
        public int[] u;

        public MenuInicial()
        {
            InitializeComponent();
            d.GeneracionAleatorios();            
        }

        // MM2
        private void btnMM2(object sender, EventArgs e)
        {
            MMS mms = new MMS();
            GraficoMMS gmms = new GraficoMMS();
            gmms.Visible = true;
            mms.probabilidades();
            for (int i = 0; i < 10; i++){
                mms.tiempoentrellegadas[i] = d.T_E_LL_MMS[i];
                Console.WriteLine("este es dtell" + mms.tiempoentrellegadas[i]);
                mms.tiempodeservicio[i] = d.T_D_S_MMS[i];
                mms.tiempodeservicioredondeado[i] =  d.tiempo_servicioMM2(mms.tiempodeservicio[i]) ;
                Console.WriteLine("Aguirre" + mms.tiempodeservicioredondeado[i]);
                if (mms.tiempodeservicioredondeado[i] >= 6){
                    mms.cont_salidas6mMMS = mms.cont_salidas6mMMS + 1;
                    Console.WriteLine("mmscons" +mms.cont_salidas6mMMS);
                }
                else if (mms.tiempodeservicioredondeado[i] >= 10)
                {
                    mms.cont_salidas10mMMS = mms.cont_salidas10mMMS + 1;
                    Console.WriteLine("mmscons" + mms.cont_salidas10mMMS);
                }
                else
                {

                }
                mms.cont_salidasT = Math.Round(mms.cont_salidas6mMMS * 0.3) + (mms.cont_salidas10mMMS * ((0.7) * (0.9)));

            }
            mms.T_D_Esp(d.arreglo, mms.T_E_LLegadas());
            gmms.TmaxColaMMS1.Text = "" + mms.max_tiempo_cola;
            gmms.TPromColaMMS1.Text = "" + mms.promedio_tiempo_cola;
            gmms.TMinColaMMS1.Text = "" + mms.min_tiempo_cola;
            gmms.TMaxServMMS1.Text = "" + mms.tiempodeservicioredondeado.Max();
            gmms.TMinServMMS1.Text = "" + mms.tiempodeservicioredondeado.Min();
            gmms.TPromServMMS1.Text = "" + (mms.tiempodeservicioredondeado.Sum() / Datos.rango);
            gmms.Aband6MMMS1.Text = "" + Math.Round(mms.cont_salidas6mMMS * 0.3);
            gmms.Aband10MMMS1.Text = "" + mms.cont_salidas10mMMS;
            gmms.Label12MMS.Text = "" + mms.cont_salidasT;
            gmms.TextBox4MMS.Text = "" + mms.tiempoentrellegadasredondeado[0];
            gmms.TextBox5MMS.Text = "" + mms.cont_EmpiezaCola;
        }

        //Dos Canales
        private void btn2Canales(object sender, EventArgs e){
            MM1_2Canales m2c = new MM1_2Canales();
            
        }
        
        // MM1
        private void btnMM1(object sender, EventArgs e){
            GraficoMM1 gmm1 = new GraficoMM1();
            gmm1.Visible = true;         
            MM1 mm1 = new MM1();
            mm1.probabilidades();

            for (int i = 0; i < 10; i++){
                mm1.tiempoentrellegadas[i] = d.T_E_LL_MM1[i];
                mm1.tiempodeservicio[i] = d.T_D_S_MM1[i];                
                mm1.tiempodeservicioredondeado[i] = d.tiempo_servicioMM1(mm1.tiempodeservicio[i]);
                if (mm1.T_D_E(mm1.tiempodeservicioredondeado, mm1.tiempoentrellegadasredondeado) >= 6){
                    mm1.cont_salidas6m = mm1.cont_salidas6m+ 1;
                }else if(mm1.tiempodeservicioredondeado[i] >= 10){
                    mm1.cont_salidas10m = mm1.cont_salidas10m + 1;
                }
                 mm1.cont_salidasT = Math.Round(mm1.cont_salidas6m*0.3)+(mm1.cont_salidas10m*((0.7)*(0.9)));
                
            }            
            mm1.T_D_E(mm1.tiempodeservicioredondeado, mm1.T_E_LLegadas());
            gmm1.TmaxCola1.Text = ""+mm1.max_tiempo_cola;
            gmm1.TPromCola1.Text = "" + mm1.promedio_tiempo_cola;
            gmm1.TMinCola1.Text = "" + mm1.min_tiempo_cola;
            gmm1.TMaxServ1.Text = "" + mm1.tiempodeservicioredondeado.Max();
            gmm1.TMinServ1.Text = "" + mm1.tiempodeservicioredondeado.Min();
            gmm1.TPromServ1.Text = "" + (mm1.tiempodeservicioredondeado.Sum()/Datos.rango);
            gmm1.Aband6M1.Text = "" + Math.Round(mm1.cont_salidas6m * 0.3);
            gmm1.Aband10M1.Text = "" + mm1.cont_salidas10m;
            gmm1.Label12.Text = "" + mm1.cont_salidasT;
            gmm1.TextBox4.Text = "" + mm1.tiempoentrellegadasredondeado[0];
            gmm1.TextBox5.Text = "" + mm1.cont_EmpiezaCola;
            


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
