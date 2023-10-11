using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosBidimensionales
{
    internal class Arreglos
    {

        public void Matriz3()
        {
            int[,] arreglo = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i = 0; i < arreglo.GetLength(0); i++)
            {
                Console.WriteLine("Matriz "+ (i+1));
                for(int j = 0; j < arreglo.GetLength(1); j++)
                {
                    Console.Write(" " + arreglo[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Matriz2()
        {
            string[,] arreglo = { { "Rojo", "Verde" }, {"Azul", "Amarillo" } };
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                Console.WriteLine("Matriz "+ (i+1));
                for(int j = 0;j < arreglo.GetLength(1); j++)
                {
                    Console.Write(" " + arreglo[i, j]);
                }
                Console.WriteLine();
            }

        }

        public void Matriz4x3()
        {
            double[,] arreglo = { {1.1, 2.2, 3.3 }, { 4.4, 5.5, 6.6 }, { 7.7, 8.8, 9.9 }, { 10.1, 11.2, 12.3 } };

            double resultado = 0;

            for(int i = 0;i < arreglo.GetLength(0); i++)
            {
                for(int j = 0; j < arreglo.GetLength(1); j++)
                {
                    resultado += arreglo[i, j];
                }
            }

            Console.WriteLine($"El resultado de la suma es {resultado}");
        }

        public void Matriz2x4()
        {
            string[,] arreglo = { {"a", "b", "c", "d" }, { "e", "f","g","h"} };

            for(int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    Console.Write(arreglo[i, j]);
                }
                Console.WriteLine();
            }

        }

    }
}
