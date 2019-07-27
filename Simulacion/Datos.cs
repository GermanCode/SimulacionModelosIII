using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion
{
    class Datos
    {
        public void aleatorio()
        {
            int tiempo_pro_llegada = 6;
            int rango = 1000;
            double[] num_aleatorios = new double[1000];
            double[] num_aleatorios_excel = new double[1000];
            for (int i = 0; i < rango; i++)
            {
                num_aleatorios[i] = new Random().NextDouble();
                Console.WriteLine("aqui va el numero: " + i + " el aleatorio solo: " + num_aleatorios[i]);
                Console.WriteLine("aqui va el numero: " + i + " el aleatorio de excel: " + (tiempo_pro_llegada * -1) * Math.Log(num_aleatorios[i]));

            }
        }


        public void probabilidadMM2()
        {
            string[,] prob;
            prob = new string[5, 2]  { {"1","0,2" }, { "2","0,35" }, { "3","0,3" },
                                         { "4","0,1" }, { "5","0,05" } };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Minutos entre llegadas: " + prob[i, 0] + " Probailidad de que ocurra: " + prob[i, 1]);
            }
        }

        public void probabilidadMM1_2Canales()
        {
            string[,] prob;
            prob = new string[8, 2]  { {"2","0,24" }, { "3","0,2" }, { "4","0,18" },
                                         { "5","0,15" }, { "6","0,12" }, { "7","0,08" },
                                           { "8","0,06" }, { "9","0,02" } };

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Minutos entre llegadas: " + prob[i, 0] + " Probailidad de que ocurra: " + prob[i, 1]);
                
            }
            Console.WriteLine("___________________________________________________________________________________");
        }

    }
}

