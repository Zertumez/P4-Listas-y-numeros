using System;
using System.Collections.Generic;

namespace P4_Listas_y_numeros
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Crear un arreglo de los siguientes 5 números enteros: 1, 2, 3, 4, 5
            int[] arreglo1 = {1, 2, 3, 4, 5};

            // Actualizar el segundo número del arreglo a 6. 
            arreglo1[1] = 6;

            // Actualizar el último número del arreglo a 7.
            arreglo1[4] = 7;

            // "Borrar" el primer número.
            for (int i = 0; i < 4; i++)
            {
                arreglo1[i] = arreglo1[i + 1];
            }
            
            // Agregar un número 8 al final.
            arreglo1[4] = 8;

            // Imprimir los números del arreglo.
            Console.WriteLine("Los números dentro del arreglo al final fueron:");
            Console.WriteLine("");

            for (int i = 0; i < arreglo1.Length; i++) 
            {
                Console.WriteLine(arreglo1[i]);
            }
            
            Console.WriteLine("");

            // Crear una lista de números enteros, y agregarle los siguientes 5 números.
            List<int> lista1 = new List<int>();
            lista1.Add(1);
            lista1.Add(2);
            lista1.Add(3);
            lista1.Add(4);
            lista1.Add(5);

            //Repetir los mismos pasos realizados sobre el arreglo hasta llegar a los números 6, 3, 4, 7, 8.
            // Actualizar el segundo número de la lista a 6. 
            lista1[1] = 6;
            
            // Actualizar el último número de la lista a 7.
            lista1[4] = 7;

            // "Borrar" el primer número.
            lista1.Remove(1);

            // Agregar un número 8 al final.
            lista1.Add(8);
            
            // Se deben imprimir estos números al final de las modificaciones.
            Console.WriteLine("Los números dentro de la primer lista al aplicar las modificaciones que tuvo el arreglo anterior fueron:");
            Console.WriteLine("");

            for (int i = 0; i < lista1.Count; i++) 
            {
                Console.WriteLine(lista1[i]);
            }

            Console.WriteLine("");

            // Agregar un número 9 al final.
            lista1.Add(9);

            // Iterar los elementos de la lista, y multiplicar los números por 3, actualizando cada valor de la lista.
            for (int i = 0; i < lista1.Count; i++) 
            {
                lista1[i] = lista1[i]*3;
            }

            // Iterar los elementos de la lista, y borrar aquellos elementos que sean mayores a 20 (usando una condición), e imprimir.
            for (int i = 0; i < lista1.Count; i++) 
            {
                if(lista1[i] > 20)
                {
                    lista1.RemoveAt(i);
                    i--;
                }

            }

            Console.WriteLine("Los números dentro de la primer lista al final fueron:");
            Console.WriteLine("");

            for (int i = 0; i < lista1.Count; i++) 
            {
            Console.WriteLine(lista1[i]);
            }
            
            Console.WriteLine("");

            // Crear una lista de números enteros, y agregarle los siguientes 10 números.
            List<int> lista2 = new List<int>();
            lista2.Add(2);
            lista2.Add(6);
            lista2.Add(19);
            lista2.Add(34);
            lista2.Add(65);
            lista2.Add(12);
            lista2.Add(42);
            lista2.Add(33);
            lista2.Add(40);
            lista2.Add(15);

            // Iterar la lista anterior y buscar cuál es el número mayor en la lista. 
            int numeroMayor = 0;

            for (int i = 0; i < lista2.Count; i++)
            {
                if (lista2[i] > numeroMayor)
                {
                    numeroMayor = lista2[i];
                }
            }
            
            // Después, imprimir los números de la lista, y cuál es el número mayor en la lista.
            Console.WriteLine("Los números dentro de la segunda lista al final fueron:");
            Console.WriteLine("");

            for (int i = 0; i < lista2.Count; i++) 
            {
            Console.WriteLine(lista2[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("El número mayor de la última lista creada es:" + numeroMayor);
        }
    }
}