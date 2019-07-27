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

        public double aleatorio()
        {
            for (int i = 0; i < rango; i++)
            {
                num_aleatorios[i] = new Random().NextDouble();
                //Console.WriteLine("aqui va el numero: " + i + " el aleatorio: " + (tiempo_pro_llegada * -1) * Math.Log(num_aleatorios[i]));
                num_pseudo[i] = (tiempo_pro_llegada * -1) * Math.Log(num_aleatorios[i]);
                // Console.WriteLine("iteracion " + i +  " p2 " + num_pseudo[i]);
            }

            return num_aleatorios[1];
        }

        public double aleatoriounico()
        {
            double numero;
                numero = new Random().NextDouble();
                numerocalc = (tiempo_pro_llegada * -1) * Math.Log(numero);
            return numerocalc;

            Console.WriteLine(numerocalc);
        }

        public double setAleatorios(){
            double[] n;
            n = new double[1000];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = aleatoriounico();
                Console.WriteLine("aqui" + num_pseudo[9] + " <-- pseudo" + i + " <-- i " + n[i]);
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

