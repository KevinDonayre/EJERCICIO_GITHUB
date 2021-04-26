using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_GITHUB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5];
            int[] x = new int[] { 1, 5, 112, 3, 7 };
            int n = 5;
            int m = mayorElemento(x, n - 1, x[0]);
            Console.WriteLine(m);
            Console.Read();
        }

        /*private static int mayorElemento(int[] x)
        {
            int aux = x[1];
            for (int i = 0; i < 5; i++)
            {
                if (aux < x[i])
                {
                    aux = x[i];
                }
            }
             return aux;
        }*/
        private static int mayorElemento(int[] x, int n, int maximo)
        {

            if (n == 0)
            {
                return maximo;
            }
            else
            {
                if (x[n] > maximo)
                {
                    maximo = x[n];
                }
                return mayorElemento(x, n - 1, maximo);
            }
        }
    }
}