using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaNo9yNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int opccion = 0;
            bool continuar = true;
            Console.WriteLine(" Autor: Manuel Alejandro Rico Rodríguez ");
            Console.WriteLine(" Carnet: RR20044 ");
            Console.WriteLine(" GL:33");
            Console.WriteLine(" Descripción: Diseñar una solución que permita realizar las siguientes operaciones sobre vectores: ");
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\  ");
            Console.WriteLine("\t\t\t\t * Inicializar vectores.\n \t\t\t\t * Limpiar vectores.\n \t\t\t\t * Ingresar datos.\n \t\t\t\t * Ver datos almacenados.\n \t\t\t\t * Estadísticas de datos. ");
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\  ");
            do
            {
                Menu(ref opccion);
                
                switch (opccion)
                {
                    case 1://Inicializar vectores
                        break;
                    case 2://Limpiar memoria
                        break;
                    case 3://Ingresar datos
                        break;
                    case 4://Ver listado
                        break;
                    case 5://Ver estadísticas
                        break;
                    case 6://Salir
                        continuar = false;
                        break;
                }
            } while (continuar);
            

            Console.ReadKey();
        }
        public static void Menu (ref int opccion){

            do{
                Console.WriteLine("\n MENU DE OPCCIONES ");
                Console.WriteLine(" Ingrese el número correspondiente a la opcción de desea realizar ");
                Console.WriteLine(" 1. Inicializar vectores ");
                Console.WriteLine(" 2. Limpiar memoria ");
                Console.WriteLine(" 3. Ingresar datos ");
                Console.WriteLine(" 4. Ver listado ");
                Console.WriteLine(" 5. Ver estadística ");
                Console.WriteLine(" 6. Salir ");

                try {
                    opccion = int.Parse(Console.ReadLine());
                }
                catch(FormatException e){
                    opccion = 0;
                }
                
            } while (opccion <= 0 || opccion > 6);
            
        }
    }
}
