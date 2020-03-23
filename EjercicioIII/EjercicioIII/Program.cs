using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIII
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra, inversa, caracter;
            int i;
            Console.WriteLine("Ingrese la palabra para saber si es palindromo");
            palabra = Convert.ToString(Console.ReadLine());
            i = palabra.Length;
            inversa = "";

            for (int x = i - 1; x >= 0; x--)
            {
                caracter = palabra.Substring(x, 1);
                inversa = inversa + caracter;
            }
            if (palabra == inversa)
            {
                Console.WriteLine(palabra + " es un palindromo");
            }
            else
            {
                Console.WriteLine(palabra + " No es un palindromo");
            }

            Console.ReadKey();
        }
    }
    }
}
