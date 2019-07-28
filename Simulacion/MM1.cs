using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion
{
    class MM1
    {
        Datos d = new Datos();
        public double[] tiempoentrellegadas = new double[1000];

        public double[] T_E_LLegadas()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("T_E_LLegadas " + tiempoentrellegadas[i]);
            }
            return tiempoentrellegadas;
        }
        
        public void probabilidades()
        {
            d.probabilidadMM1_2Canales();
        }
    }
}