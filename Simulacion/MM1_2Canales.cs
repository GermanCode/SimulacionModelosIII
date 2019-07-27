using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion
{
    class MM1_2Canales
    {
        Datos d = new Datos();
        public void generaraleatorios()
        {
            d.aleatorio();
        }
        public void probabilidades()
        {
            d.probabilidadMM1_2Canales();
        }
    }
}
