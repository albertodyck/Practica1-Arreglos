using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir un arreglo de nombre Arreglo, tipo string y llenarlo con los elementos
            string[] Arreglo = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };

            bool bandera = false;
            while (!bandera)
            {
                Console.Clear();
                //Seleccionar el dia a imprimir
                Console.WriteLine("Teclee el Número de día de la semana a imprimir (1-7):");
                Console.WriteLine("1-Domingo, 2-Lunes, 3-Martes, 4-Miercoles, 5-Jueves, 6-Viernes, 7-Sabado");

                try
                {
                    int num = int.Parse(Console.ReadLine());

                    //Verificar que se selecciono un numero valido
                    if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5 || num == 6 || num == 7)
                    {
                        //Imprimir el dia seleccionado
                        Console.WriteLine($"El día Seleccionado es: -{Arreglo[num - 1]}-");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No se selecciono un número valido");
                        Console.WriteLine();
                        //Imprimir el contenido del arreglo
                        foreach (string DiaDeLaSemana in Arreglo)
                        {
                            Console.WriteLine($"-{DiaDeLaSemana}-");
                        }
                        Console.WriteLine();
                    }
                }
                catch 
                {
                    Console.WriteLine("No tecleo un Número");
                    //Imprimir el contenido del arreglo
                    Console.WriteLine("Días de la semana:");
                    Console.WriteLine();
                    foreach (string DiaDeLaSemana in Arreglo)
                    {
                        Console.WriteLine($"-{DiaDeLaSemana}-");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("1.- Otra Selección");
                Console.WriteLine("2.- Salir");
                if (int.Parse(Console.ReadLine()) == 2)
                {
                    bandera = true;
                }
            }
        }
    }
}
