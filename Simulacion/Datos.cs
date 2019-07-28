using System;

namespace Simulacion
{
    class Datos
    {

        int tiempo_pro_llegada = 6;
        static int rango = 1000;
        public double[] num_aleatorios = new double[rango];
        public double[] num_pseudo = new double[rango];
        double numerocalc;

        public double[,] tabla_mm2 = new double[5, 3]  { {1,0.2,0.2}, {2,0.35,0.55}, {3,0.3,0.85},
                                         {4,0.1,0.95}, {5,0.05,1} };

        public double[,] tabla_mm1 = new double[8, 3]   { {2,0.24,0.24},  {3,0.2,0.44}, {4,0.15,0.59},
                                           {5,0.14,0.73}, {6,0.12,0.85}, {7,0.08,0.93},
                                           {8,0.05,0.98}, {9,0.02,1} };



        public int tiempo_servicioMM2(double t_servi_alea)
        {
            int nuevo_tservicio = 0;
            for (int i = 0; i < tabla_mm2.Length; i++)
            {
                if (i < 1)
                {
                    if (t_servi_alea >= 0 & t_servi_alea <= tabla_mm2[i, 2])
                    {
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


        public int tiempo_servicioMM1(double t_servi_alea)
        {
            int nuevo_tservicio = 0;
            for (int i = 0; i < tabla_mm2.Length; i++)
            {
                if (i < 1)
                {
                    if (t_servi_alea >= 0 & t_servi_alea <= tabla_mm2[i, 2])
                    {
                        nuevo_tservicio = Convert.ToInt32(tabla_mm2[i, 0]);
                    }
                }
                else
                {
                    if (t_servi_alea >= tabla_mm2[i-1, 2] & t_servi_alea <= tabla_mm2[i, 2])
                    {
                        nuevo_tservicio = Convert.ToInt32(tabla_mm2[i, 0]);
                    }
                }
            }
            Console.WriteLine("MM1->"+nuevo_tservicio);
            return nuevo_tservicio;
        }


        public double aleatorio()
        {
            for (int i = 0; i < rango; i++)
            {
                double num1 = new Random().NextDouble(); ;
                double num2 = new Random().NextDouble();
                num_aleatorios[i] = (num1 * num2) / 2;
                //Console.WriteLine("aqui va el numero: " + i + " el aleatorio: " + (tiempo_pro_llegada * -1) * Math.Log(num_aleatorios[i]));
                num_pseudo[i] = (tiempo_pro_llegada * -1) * Math.Log(num_aleatorios[i]);
                Console.WriteLine("iteracion " + i + " p2 " + num_pseudo[i]);
            }

            return num_aleatorios[0];
        }

        public double aleatoriounico()
        {
            double numero;
            numero = new Random().NextDouble();
            numerocalc = (tiempo_pro_llegada * -1) * Math.Log(numero);
            Console.WriteLine(numerocalc);
            return numerocalc;
            
        }

        public double setAleatorios()
        {
            double[] n;
            n = new double[1000];

            for (int i = 0; i < n.Length; i++)
            {
                num_pseudo[i] = aleatorio();
                n[i] = aleatoriounico();
                Console.WriteLine("aqui" + num_pseudo[i] + " <-- pseudo" + i + " <-- i " + n[i]);
            }
            Console.WriteLine("aqui" + num_pseudo[999] + "" + " aja " + n[999]);

            return n[1];
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

