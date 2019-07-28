using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion
{
    class MMS
    {
        Datos d = new Datos();
        public void generaraleatorios()
        {
            d.GeneracionAleatorios();
        }
        public void probabilidades()
        {
            d.probabilidadMM2();
        }
    }
}
