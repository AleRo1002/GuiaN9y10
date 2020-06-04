using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaNo9yNo10
{
    class Program
    {
        const int TAM = 7, FILAS = 7, COLUMNAS = 3;


        static void Main(string[] args)
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
                        break;
                    case 2: //Limpiar memoria
                        LimpiezaMemoria(nombres, edades, esPeSa);
                        break;
                    case 3: //Ingresar datos
                        break;
                    case 4: //Ver listado
                        VerListado(nombres, edades, esPeSa);
                        break;
                    case 5: //Ver estadísticas
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

            } while (opccion <= 0 || occion > 6);

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
        }//LimpiezaMemoria
         ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void IncilizarValores(String[] nombre, int[] edad, double[,] esPeSa)
        {
            //Vectores para incilizar
            String[] cargarNombres = { "Carlos", "Mario", "Jose", "Manuel", "Juan" };
            int[] cargarEdades = { 23, 11, 24, 56, 34 };
            double[,] carEsPeSa = new double[5, 3] { { 1.8, 230, 449 }, { 1.6, 132, 1000.00 }, { 2.3, 134, 150.78 }, { 1.60, 4500, 2.09 }, { 2.0, 80.8, 600.9 } };

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

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void VerListado(String[] nombre, int[] edad, double[,] esPeSa)
        {

            Console.WriteLine("Nombres\t\t Edades\t\t Estatura\t  Peso\t\t Salario\t\t");
            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine("{0}\t\t   {1}\t\t   {2}\t\t  {3}\t\t {4}\t\t", nombre[z], edad[z], esPeSa[z, 0], esPeSa[z, 1], esPeSa[z, 2]);
            }
        }
    }
}
