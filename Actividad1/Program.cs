using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
             

            int n1, n2, menu=1, i, j, t, temp;
            string palabra, temp2;
            int verdad = 0;

            int primo(int num) // num = 7 ... 3, 4, 5, 6
            {
                for (i = 3; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return n2 = 0 ; // false
                    }                    
                }
                return n2 = 1; // true
            }

            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Digite el número del ejercicio que quiere ejecutar\nOprima 0 para salir\n");
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (menu)
                    {
                        case 0:
                            break;
                        case 1:
                            // 1. Leer un número por teclado y definir si es par o impar
                            Console.WriteLine("Digite un número entero");
                            n1 = Convert.ToInt32(Console.ReadLine());

                            if (n1 % 2 == 0)
                            {
                                Console.WriteLine("El número es par");
                            }
                            else
                            {
                                Console.WriteLine("El número es impar");
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            // 2. Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10 
                            Console.WriteLine("Digite el número de la tabla");
                            n1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("La tabla del " + n1);

                            for (i = 1; i <= 10; i++)
                            {
                                Console.WriteLine(n1 + " X " + i + " = " + n1 * i);

                            }

                            Console.ReadKey();
                            break;
                        case 3:

                            // Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10 

                            for (i = 2; i < 10; i++)
                            {
                                for (j = 1; j <= 10; j++)
                                {
                                    Console.WriteLine(i + " x " + j + " = " + i * j);
                                }
                                Console.Write("\t");
                            }
                            Console.ReadKey();
                            break;
                        case 4:
                            //Leer un número por teclado y definir si es primo o no
                            Console.WriteLine("Digite un número entero mayor a 1");
                            n1 = Convert.ToInt32(Console.ReadLine());

                            if (n1 < 1)
                            {
                                Console.WriteLine("Este número no es primo");
                            }
                            else if (n1 == 2)
                            {
                                Console.WriteLine("El número 2 es primo");
                            }
                            else if (primo(n1) == 1)
                            {
                                Console.WriteLine("El número es primo");
                            }
                            else
                            {
                                Console.WriteLine("El número no es primo");
                            }

                            Console.ReadKey();
                            break;
                        case 5:
                            // Dado el vector edad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45], ordenarlos en forma ascendiente
                            int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };

                            Console.WriteLine("--- El Arreglo original es ---");

                            foreach (int elemento in edad)
                            {
                                Console.Write(elemento + " | ");
                            }
                            Console.WriteLine("\n");

                            t = edad.Length;
                            Console.WriteLine("El largo del arreglo es " + t);

                            for (j = 1; j < t; j++)
                            {
                                for (i = 0; i < t - j; i++)
                                {
                                    if (edad[i] > edad[i + 1])
                                    {
                                        temp = edad[i];
                                        edad[i] = edad[i + 1];
                                        edad[i + 1] = temp;
                                    }
                                }
                            }

                            Console.WriteLine("-- Arreglo Ordenado --");
                            foreach (int elemento in edad)
                            {
                                Console.Write(elemento + " | ");
                            }
                            Console.ReadKey();
                            break;
                        case 6:
                            /* Datos los vectores edad = [12,50,23,10,18,35,41,85,16,45] 
                            nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
                            Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
                            que el nombre no existe */
                            int[] edad_ = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

                            foreach(string nombre in nombres)
                            {
                                Console.Write(nombre + " | ");
                            }
                            Console.WriteLine("\n");


                            Console.WriteLine("Escriba un nombre");
                            palabra = Console.ReadLine();

                            for (i = 0; i < nombres.Length; i++)
                            {
                                if (palabra == nombres[i])
                                {
                                    Console.WriteLine("La edad de " + palabra + " es " + edad_[i]);
                                    verdad = 1;
                                    break;
                                }
                                else
                                {
                                    verdad = 0;
                                }
                            }

                            if (verdad == 0)
                            {
                                Console.WriteLine("El nombre " + palabra + " no existe dentro del arreglo");
                            }

                            Console.ReadKey();
                            break;
                        case 7:
                            // Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres con su edad.
                            Console.WriteLine("Buscar Usuario y mostrar su edad");

                            int[] edad_1 = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                            string[] nombres_1 = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                            string NombreBuscar;

                            /* definir dos variables */
                            Boolean existe = false; /* me a decir si el ususario exisete */
                            int indice = 0;  /* guardare el valor de la posicion del arreglo  donde existe el usasrio */

                            int indiceMayor = 0;
                            int edadMayor = 0;

                            Console.WriteLine(" - muestra el array de nombre");

                            foreach (string nombre in nombres_1)
                            {
                                Console.Write(nombre + " - ");
                            }

                            Console.Write("\n");

                            /*   leer el nombre a buscar */
                            Console.Write("Digite el nombre a buscar: ");
                            NombreBuscar = Console.ReadLine();


                            /*  recorra el vector y me diga si existe y la posiscion */
                            for (i = 0; i < nombres_1.Length; i++)
                            {

                                // - busco el nombre
                                if (NombreBuscar == nombres_1[i])
                                {
                                    existe = true;
                                    indice = i;
                                }
                                // comparo las edades 
                                if (edad_1[i] > edadMayor)
                                {
                                    edadMayor = edad_1[i];
                                    indiceMayor = i;
                                }


                            }


                            /*  buscar el mayot el array edad*/
                            /*for (int i = 0; i < edad.Length; i++)
                            {
                                if (edad[i] > edadMayor)
                                {
                                    edadMayor = edad[i];
                                    indiceMayor = i;
                                }
                            }*/

                            /*   mostrar quien es el mayor */

                            Console.WriteLine(" el Mayor es " + nombres_1[indiceMayor] + " y su edad es  " + edad_1[indiceMayor]);


                            /* validad si existe el usuario */
                            if (existe)
                                Console.WriteLine(" El usuario " + NombreBuscar + " tiene " + edad_1[indice]);
                            else
                                Console.WriteLine(" El usuario " + NombreBuscar + " no exiiste ");
                            Console.ReadKey();
                            break;
                        case 8:
                            //Dado una palabra definir si es palíndromo o no
                            Console.WriteLine("Digite una palabra: ");
                            palabra = Console.ReadLine();
                            string palabra2 = Regex.Replace(palabra, @"\s", "");
                            string alreves = "";

                            Console.WriteLine(palabra2);

                            foreach (var letra in palabra2)
                            {
                                Console.Write(letra + " | ");
                                alreves = letra + alreves;

                                //Console.Write("\n"+alreves + " | ");
                            }

                            Console.WriteLine("\n" + alreves + "\n");

                            if (palabra2 == alreves)
                            {
                                Console.WriteLine("Es palindromo");
                            }
                            else
                            {
                                Console.WriteLine("No es palindromo");
                            }
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("\n/-------------------------------------------------------------------------/\n" +
                                              "   Aún no existe este programa, vuelva a ejecutar otro programa disponible \n" +
                                              "/-------------------------------------------------------------------------/");
                            Console.ReadKey();
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nNo has digitado un valor valido recuerdo son números de ejercicios enteros");
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
                
                Console.Clear();
                
            }
            Console.ReadKey();
        }
    }
}
