using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulacion
{
    class MM1
    {
        //Instancia de los Datos
        Datos d = new Datos();
        MenuInicial mi = new MenuInicial();
        public double[] tiempoentrellegadas = new double[10];
        public double[] tiempodeservicio = new double[10];        
        public int[] tiempoentrellegadasredondeado = new int[10];
        public int[] tiempodeservicioredondeado = new int[10];
        public int redondeadounitarioll = 0;
        public int redondeadounitarios = 0;
        public double total_tiempo_en_cola = 0;
        public double promedio_tiempo_cola = 0;
        public double max_tiempo_cola = 0;
        public double min_tiempo_cola = 0;
        public int cont_salidas6m = 0;
        public int cont_salidas10m = 0;
        public double cont_salidasT = 0;
        public int cont_EmpiezaCola = 0;
        public int[] TiempoenCola = new int[10];


        public int[] T_D_S_MM1m(){
            for (int i = 0; i < 10; i++){
            }
            return tiempodeservicioredondeado;
        }
        public int[] T_E_LLegadas() {
            for (int i = 0; i < 10; i++) {
                redondeadounitarioll = Convert.ToInt32(Math.Round(tiempoentrellegadas[i]));
                tiempoentrellegadasredondeado[i] = redondeadounitarioll;
            }
            return tiempoentrellegadasredondeado;
        }
          
        public int T_D_E(int[] tservicio, int[] tllegada){
            for (int i = 0; i < 10; i++){
                Console.WriteLine(i +"Tiempo de Servicio Redondeado" + "-----"+ tiempodeservicioredondeado[i]);
                Console.WriteLine(i +"Tiempo de Entre Llegadas Redo" + "-----" + tiempoentrellegadasredondeado[i]);
            }                                   
            for (int i = 0; i < 9; i++){
                if (tservicio[i] - tllegada[i + 1] <= 0) //Si el tiempo de servicio menos el tiempo entre llegadas es igual //
                {                                                        //a cero, el tiempo en cola vuelve a cero, ppues no esperara en ser atendido                                                                     
                    TiempoenCola[i] = 0;
                }else{
                    TiempoenCola[i] = tservicio[i] - tllegada[i + 1]; //Aqui se forma la cola, y se guarda la suma de los tiempos en cola.
                    
                    cont_EmpiezaCola += tservicio[i] + tllegada[i + 1];
                }
                total_tiempo_en_cola = TiempoenCola.Sum();
                max_tiempo_cola = TiempoenCola.Max();
                min_tiempo_cola = TiempoenCola.Min();
            }
            promedio_tiempo_cola = total_tiempo_en_cola / 10;
            return Convert.ToInt32(total_tiempo_en_cola);
        }

        public void probabilidades(){
            d.probabilidadMM1_2Canales();
        }
    }
}