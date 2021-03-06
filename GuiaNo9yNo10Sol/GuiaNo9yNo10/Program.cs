﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaNo9yNo10
{
    class Program
    {
        public static void Main(string[] args)
        {
            /////////////////////////////////////Vectores de programa
            String[] nombres = new String[7];
            int[] edades = new int[7];
            double[,] esPeSa = new double[7, 3];
            /////////////////////////////////////Variables de programa
            int cantPersonas = 0, opccion = 0;
            bool continuar = true;
            do
            {
                Menu(ref opccion);

                switch (opccion)
                {
                    case 1: //Inicializar vectores
                        IncilizarValores(nombres, edades, esPeSa);
                        cantPersonas = 5;
                        break;
                    case 2: //Limpiar memoria
                        LimpiezaMemoria(nombres, edades, esPeSa);
                        cantPersonas = 0;
                        break;
                    case 3: //Ingresar datos
                        IngresarDatos(nombres, edades, esPeSa, ref cantPersonas);
                        break;
                    case 4: //Ver listado
                        if (cantPersonas >= 1)
                            VerListado(nombres, edades, esPeSa, cantPersonas);
                        
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t\t ...No se han encontrado datos. ");
                            Console.WriteLine("\n\t\t ...Intente ingresando datos. ");
                        }

                        break;
                    case 5: //Ver estadísticas
                        if (cantPersonas >= 1)
                            Estadisticas(nombres, edades, esPeSa);
                        
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t\t ...No se han encontrado . ");
                            Console.WriteLine("\n\t\t ...Intente ingresando datos. ");
                        }
                        break;
                    case 6: //Salir
                        continuar = false;
                        break;
                }
            } while (continuar);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void Menu(ref int opccion)
        {

            do
            {
                Console.WriteLine("\n MENU DE OPCCIONES ");
                Console.WriteLine(" 1. Inicializar vectores ");
                Console.WriteLine(" 2. Limpiar memoria ");
                Console.WriteLine(" 3. Ingresar datos ");
                Console.WriteLine(" 4. Ver listado ");
                Console.WriteLine(" 5. Ver estadística ");
                Console.WriteLine(" 6. Salir ");
                Console.Write(" Ingrese el número correspondiente a la opcción de desea realizar :");
                try
                {
                    opccion = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    opccion = 0;
                }

            } while (opccion <= 0 || opccion > 6);

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void LimpiezaMemoria(String[] nombre, int[] edad, double[,] esPeSa)
        {

            for (int i = 0; i < 7; i++)
            {
                nombre[i] = " ";
                edad[i] = 0;
            }

            for (int j = 0; j < 7; j++)
            {
                for (int x = 0; x < 3; x++)
                {
                    esPeSa[j, x] = 0;
                }
            }
            Console.Clear();
            Console.WriteLine("\n\t\t ...Se ha limpiado la memoria. ");
        }//LimpiezaMemoria
         ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void IncilizarValores(String[] nombre, int[] edad, double[,] esPeSa)
        {
            //Vectores para incilizar
            String[] cargarNombres = { "Carlos", "Mario", "Jose", "Manuel", "Juan" };
            int[] cargarEdades = { 23, 11, 24, 56, 34 };
            double[,] carEsPeSa = new double[5, 3] { { 1.8, 230, 449 }, { 1.6, 132, 1500.00 }, { 2.3, 134, 150.78 }, { 1.60, 4500, 2.09 }, { 2.0, 80.8, 600.9 } };

            for (int w = 0; w < 5; w++)
            {
                nombre[w] = cargarNombres[w];
                edad[w] = cargarEdades[w];
            }
            for (int j = 0; j < 5; j++)
            {
                for (int x = 0; x < 3; x++)
                {
                    esPeSa[j, x] = carEsPeSa[j, x];
                }
            }
            Console.Clear();
            Console.WriteLine("\n\t\t ...Vectores inicializados. ");

        }
        //////////////////////////////inializar valores///////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void VerListado(String[] nombre, int[] edad, double[,] esPeSa, int cantPersonas)

        {

            Console.WriteLine("Nombres\t\t Edades\t\t Estatura\t  Peso\t\t Salario\t\t");
            for (int z = 0; z < cantPersonas; z++)
            {
                Console.WriteLine("{0}\t\t   {1}\t\t   {2}\t\t  {3}\t\t {4}\t\t", nombre[z], edad[z], esPeSa[z, 0], esPeSa[z, 1], esPeSa[z, 2]);
            }

        }

        public static void IngresarDatos(String[] nombre, int[] edad, double[,] esPeSa, ref int cantPersonas)
        {

            if (cantPersonas < 7)
            {
                //for (int i = cantPersonas; i < cantPersonas + 1; i++);
                //for (int i = 5; i < 5 + 1; i++);
                for (int i = cantPersonas; i < cantPersonas + 1; i++)
                {
                    Console.WriteLine(" Ingrese el nombre:");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine(" Ingrese la edad:");
                    edad[i] = int.Parse(Console.ReadLine());
                }

                for (int j = cantPersonas; j < cantPersonas + 1; j++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (x == 0) Console.WriteLine(" Ingrese la estatura (metros):");

                        else
                        {
                            if (x == 1) Console.WriteLine(" Ingrese el peso en (lbs):");

                            else Console.WriteLine(" Ingrese el salario (dolares):");
                        }
                        esPeSa[j, x] = double.Parse(Console.ReadLine());
                    }
                }
                Console.Clear();
                Console.WriteLine("\n\t\t ...Se han ingresado los datos correctamente. ");
                cantPersonas += 1;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\t\t ...Memoria llena. ");
            }
            //////////////////////////////////////////////////////////////////

        }

        public static void Estadisticas(String[] nombre, int[] edad, double[,] esPeSa)
        {
            int  total = 0,numeroElementos = 0,limitePeso = 200,limiteSalario = 1000;
            double promedioEdad = 0,limiteDeAltura = 1.65;

            foreach (int elementos in edad)
                total += elementos;

            numeroElementos = edad.Length;

            promedioEdad = total / numeroElementos;

            Console.WriteLine("\n Edad promedio: {0}", Math.Round(promedioEdad, 2));
            Console.WriteLine("\n personas con edad menor al promedio ");
            Console.WriteLine("\n Nombres\t Edades\t");

            for (int i = 0; i < edad.Length;i++)
                if(edad[i] < Math.Round(promedioEdad,2) && edad[i] != 0)
                    Console.WriteLine(" {0}\t\t {1}", nombre[i], edad[i]);

            Console.WriteLine("\n Datos de personas con altura menor a {0}m ",limiteDeAltura);
            Console.WriteLine("\nNombres\t\t Edades\t\t Estatura\t  Peso\t\t Salario\t\t");

            for (int z = 0; z < 7 ; z++)
                if(esPeSa[z,0] < limiteDeAltura && esPeSa[z,0] != 0)
                    Console.WriteLine(" {0}\t\t   {1}\t\t   {2}\t\t  {3}\t\t {4}\t\t", nombre[z], edad[z], esPeSa[z, 0], esPeSa[z, 1], esPeSa[z, 2]);

            Console.WriteLine("\n personas con peso mayor a {0}lbs ",limitePeso);
            Console.WriteLine("\n Nombres\t  Pesos\t");

            for (int x = 0; x < 7; x++)
                if (esPeSa[x, 1] >= limitePeso && esPeSa[x, 1] != 0)
                    Console.WriteLine(" {0}\t\t   {1}\t\t ", nombre[x],esPeSa[x, 1]);


            Console.WriteLine("\n personas con un salario mayor ${0} ",limiteSalario);
            Console.WriteLine("\n Nombres\t Salarios\t");

            for (int y = 0; y < 7; y++)
                if (esPeSa[y, 2] > limiteSalario && esPeSa[y, 2] != 0)
                    Console.WriteLine(" {0}\t\t   {1}\t\t ", nombre[y], esPeSa[y, 2]);

        }
    }
}
