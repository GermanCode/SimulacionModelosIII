using System;

namespace Simulacion
{
    class Datos
    {       
        int tiempo_pro_llegada = 6;
        //double lamnda = 1 / 6;

        //Creacion de los numeros Aleatorios Originales.
        static int rango = 1000;
        public double[] num_aleatorios = new double[rango];
        public double[]  num_pseudo = new double[rango];

        //Creacion de los Aleatorios Espejo de cada opción.
        public double[] a = new double[rango];
        public double[] b = new double[rango];
        public double[] c = new double[rango];

        Random ramd = new Random(rango);
        double t;

        public double GeneracionAleatorios()
        {
            for (int i = 0; i < 1000; i++)
            {
                num_aleatorios[i] = ramd.NextDouble();
                num_pseudo[i] = (tiempo_pro_llegada * -1) * Math.Log(ramd.NextDouble());
                Console.WriteLine("iteracion " + i + " Valor Pseudo --> " + num_pseudo[i]);
                a[i] = num_pseudo[i];
                b[i] = num_pseudo[i];
                c[i] = num_pseudo[i];
                t = i;

                Console.WriteLine("a " + a[i]);
            }
            
            return t;
        }

        public double[] AleatorioEspejoa()
        {           
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Espejo a " + this.a[i]);
            }
                return a;
        }

        public double[] AleatorioEspejob()
        {
            Console.WriteLine("Espejo b " +b);
            return this.b;
        }

        public double[] AleatorioEspejoc()
        {
            Console.WriteLine("Espejo C " + c);
            return this.c;
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

