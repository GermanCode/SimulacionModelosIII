using System;

namespace Simulacion
{
    class Datos
    {
        //Abstraccion de Datos de probabilidad para los diferentes Casos.
        public double[,] tabla_mm2 = new double[5, 3]  { {1,0.2,0.2}, {2,0.35,0.55}, {3,0.3,0.85},
                                         {4,0.1,0.95}, {5,0.05,1} };

        public double[,] tabla_mm1 = new double[8, 3]   { {2,0.24,0.24},  {3,0.2,0.44}, {4,0.15,0.59},
                                           {5,0.14,0.73}, {6,0.12,0.85}, {7,0.08,0.93},
                                           {8,0.05,0.98}, {9,0.02,1} };

        int tiempo_pro_llegada = 6;
        //double lamnda = 1 / 6;

        //Creacion de los numeros Aleatorios Originales.
        public static int rango = 10;
        public double[] num_pseudo = new double[rango]; 
        public  int[] arreglo = new int[rango];
        public int[] anada2 = new int[rango];
        public double[] num_aleatorios_s = new double[rango];
        public double[] num_aleatorios_ll = new double[rango];

        //Creacion de los Aleatorios Espejo del Tiempo Entre LLegadas de cada opción.
        public double[] T_E_LL_MM1 = new double[rango];
        public double[] T_E_LL_MMS = new double[rango];
        public double[] T_E_LL_M2C = new double[rango];

        //Creacion de los Aleatorios Espejo del Tiempo de Servicia de cada opción.
        public double[] T_D_S_MM1 = new double[rango];
        public double[] T_D_S_MMS = new double[rango];
        public double[] T_D_S_M2C = new double[rango];

        Random ramd = new Random(rango);
        double t;
        //Generador de Numeros PseudoAleatorios
        public double GeneracionAleatorios()
        {
            for (int i = 0; i < 10; i++)
            {
                num_aleatorios_ll[i] = ramd.NextDouble();
                num_aleatorios_s[i] = ramd.NextDouble();
                num_pseudo[i] = (tiempo_pro_llegada * -1) * Math.Log(ramd.NextDouble());
                Console.WriteLine("Iteracion " + i + " Valor Raiz: " + num_aleatorios_ll[i] + " Valor Pseudo --> " + num_pseudo[i]);
                Console.WriteLine("Iteracion " + i + " Valor Aleatorio Servicio --> " + num_aleatorios_s[i]);
                //Creacion de Espejos de Aleatorios entre llegada
                T_E_LL_MM1[i] = num_pseudo[i];
                T_E_LL_MMS[i] = num_pseudo[i];
                T_E_LL_M2C[i] = num_pseudo[i];

                //Creacion de Espejos de Aleatorios de servicio
                T_D_S_MM1[i] = num_aleatorios_s[i];
                T_D_S_MMS[i] = num_aleatorios_s[i];
                T_D_S_M2C[i] = num_aleatorios_s[i];
                t = i;
            }
            return t;
        }

        // Espejos de Llegada
        public double[] AleatorioEspejoMM1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Espejo a " + this.T_E_LL_MM1[i]);
            }
            return T_E_LL_MM1;
        }

        public double[] AleatorioEspejoMMS()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Espejo b " + this.T_E_LL_MMS[i]);
            }
            return T_E_LL_MMS;
        }

        public double[] AleatorioEspejoM2C()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Espejo c " + this.T_E_LL_M2C[i]);
            }
            return T_E_LL_M2C;
        }

        //Espejos de Servicio
        public double[] AleatorioEspejoServicioMM1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Espejo tiempo de servicio " + this.T_D_S_MM1[i]);
            }
            return T_D_S_MM1;
        }

        public double[] AleatorioEspejoServicioMMS()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Espejo tiempo de servicio " + this.T_D_S_MMS[i]);
            }
            return T_D_S_MMS;
        }

        public double[] AleatorioEspejoServicioM2C()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Espejo tiempo de servicio " + this.T_D_S_M2C[i]);
            }
            return T_D_S_M2C;
        }

        
        
        
        //Revisar metodos de Steed Verificar Congruencia de datos, observar ortografica, y linealidad de las variables, generar javadoc, el primo es un manco.
        //Relacion de tiempo de servicio y probabilidad de llegada.
        public int tiempo_servicioMM2(double t_servi_alea)
        {
            int nuevo_tservicio = 0;
            int t2 = (tabla_mm2.Length) / 3;
            Console.WriteLine(t2);
            for (int i = 0; i < t2 - 1; i++){
                if (i < 1){
                    if (t_servi_alea >= 0 & t_servi_alea <= tabla_mm2[i, 2]){
                        nuevo_tservicio = Convert.ToInt32(tabla_mm2[i, 0]);
                    }
                }
                else
                {
                    if (t_servi_alea >= tabla_mm2[i - 1, 2] & t_servi_alea <= tabla_mm2[i, 2])
                    {
                        nuevo_tservicio = Convert.ToInt32(tabla_mm2[i, 0]);
                    }
                }
            }
            Console.WriteLine("MM2->" + nuevo_tservicio);
            return nuevo_tservicio;
        }


        public int tiempo_servicioMM1(double t_servi_alea){
            int nuevo_tservicio = 0;
            int t1 = (tabla_mm1.Length) / 3;
            for (int i = 0; i < t1-1; i++){
                if (i < 1){
                    if (t_servi_alea >= 0 & t_servi_alea <= tabla_mm1[i, 2]){
                        nuevo_tservicio = Convert.ToInt32(tabla_mm1[i, 0]);
                    }
                }else{
                    if (t_servi_alea >= tabla_mm1[i - 1, 2] & t_servi_alea <= tabla_mm1[i, 2]){
                        nuevo_tservicio = Convert.ToInt32(tabla_mm1[i, 0]);
                        arreglo[i] = nuevo_tservicio;
                    }
                }
            }
            Console.WriteLine("MM1->" + nuevo_tservicio);
            return nuevo_tservicio;
        }


        //Probabilidades
        public void probabilidadMM2()
        {
            string[,] prob;
            prob = new string[5, 2]  { {"1","0,2" }, { "2","0,35" }, { "3","0,3" },
                                         { "4","0,1" }, { "5","0,05" } };
            double[,] prob_double;
            prob_double = new double[5, 2] { {1, 0.2 }, { 2, 0.35 }, { 3, 0.3 },
                                         { 4, 0.1 }, { 5, 0.05 } };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Minutos entre llegadas: " + prob[i, 0] + " Probailidad de que ocurra: " + prob[i, 1]);
            }
            Console.WriteLine("___________________________________________________________________________________");
        }

        public void probabilidadMM1_2Canales()
        {
            string[,] prob;
            prob = new string[8, 2]  { {"2","0,24" }, { "3","0,2" }, { "4","0,18" },
                                         { "5","0,15" }, { "6","0,12" }, { "7","0,08" },
                                           { "8","0,05" }, { "9","0,02" } };
            double[,] prob_double;
            prob_double = new double[8, 2] { {2, 0.24 }, { 3, 0.2 }, { 4, 0.18 },
                                         { 5, 0.15 }, { 6, 0.12 }, { 7, 0.08 },
                                           { 8, 0.05 }, { 9, 0.02 } };
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Minutos entre llegadas: " + prob[i, 0] + " Probailidad de que ocurra: " + prob[i, 1]);
            }
            Console.WriteLine("___________________________________________________________________________________");
        }

        public double[,] probabilidadAcumMM2()
        {
            string[,] prob;
            prob = new string[5, 2]  { {"1","0,2" }, { "2","0,55" }, { "3","0,85" },
                                         { "4","0,95" }, { "5","1,0" } };
            double[,] prob_double_acum_mm2;
            prob_double_acum_mm2 = new double[5, 2]  { {1, 0.2 }, { 2, 0.55 }, { 3, 0.85 },
                                         { 4, 0.95 }, { 5, 1.0 } };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Minutos entre llegadas: " + prob[i, 0] + " Probailidad Acumulada: " + prob[i, 1]);
            }
            Console.WriteLine("___________________________________________________________________________________");
            return prob_double_acum_mm2;
        }

        public void probabilidadAcumMM1_2Canales()
        {
            string[,] prob;
            prob = new string[8, 2]  { {"2","0,24" }, { "3","0,44" }, { "4","0,59" },
                                         { "5","0,73" }, { "6","0,85" }, { "7","0,93" },
                                           { "8","0,98" }, { "9","1,0" } };
            double[,] prob_double_acum_mm1_m2c;
            prob_double_acum_mm1_m2c = new double[8, 2] { {2, 0.24 }, { 3, 0.44 }, { 4, 0.59 },
                                         { 5, 0.73 }, { 6, 0.85 }, { 7, 0.93 },
                                           { 8, 0.98 }, { 9, 0.02 } };

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Minutos entre llegadas: " + prob[i, 0] + " Probailidad Acum de que ocurra: " + prob[i, 1]);
            }
            Console.WriteLine("___________________________________________________________________________________");
        }

    }
}