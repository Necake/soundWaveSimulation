﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waveSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            
            VectorField polje = new VectorField(n, m);
            VectorField testMatrica = new VectorField(100, 100);

            //double dx = 0.01;
            //double dy = 0.01;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    testMatrica[i, j] = new Vector(i * i + 3 * j, 5 * j) ;
                }
            }

            /*
            //make matrix from given input
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //double x = Convert.ToDouble(Console.ReadLine());
                    //double y = Convert.ToDouble(Console.ReadLine());
                    //polje[i, j] = new Vector(i, j);
                    //testMatrica[i, j] = new Vector(x * , y);
                }
            }*/
            /*
             *  Vrsi izvod po X (ako je X2 onda je to drugi izvod)
             */
            VectorField izvodPolja = testMatrica.PojebiX(n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    testMatrica[i, j].X = izvodPolja[i, j].X;
                    //testMatrica[i, j].Y = izvodPolja[i, j].Y;
                }
            }

            /*
             *  Vrsi izvod po Y (ako je Y2 onda je to drugi izvod)
             */

            izvodPolja = testMatrica.PojebiY(n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //testMatrica[i, j].X = izvodPolja[i, j].X;
                    testMatrica[i, j].Y = izvodPolja[i, j].Y;
                    
                }
            }

            /*
             *  Stampa original matricu
             */

            //Console.WriteLine("posle prvog izvoda");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(testMatrica[i, j].stampanje());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n........end........");
        }
    }
}
