using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLO FOR

           // for (int x = 0; x < 100; x++)
           // {
             //    Console.WriteLine ("Hola Mundo " +   x);
           // }

           //float n, promedio, acumulador;         

             //for (int x = 0; x < 6; x++)
             //{
               // Console.WriteLine ("Ingrese un nro: ");
               // n = float.Parse (Console.ReadLine());
               // acumulador = n+=;
               // }  
           
               // promedio = acumulador / 6;

                //Console.WriteLine ("El promedio es: " + promedio);


              int n, contador = 0;

            Console.WriteLine ("Ingrese un nro");
            n = int. Parse (Console.ReadLine());

            while (n != 0)
            {
              contador++;
              Console.WriteLine ("Ingrese un numero:" );
              n = int.Parse (Console.ReadLine());
           
            }

              Console.WriteLine ( "la cantidad de numeros fue: " + contador);



        }
    }
}
