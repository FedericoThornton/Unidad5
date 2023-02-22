using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

          // for (int x = 0; x < 10; x++)
           // {
          //      Console.WriteLine ("nro: " + (x + 1));
            //}
           
          // int con = 1;

          //while (con < 11)
         // {
           // Console.WriteLine ("nro: " + con);
           // con++;

          //}

          // Hacer un programa que solicite el ingreso de 10 números y 
          //que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            //int n = 0, mayor = 0;

          //for (int x = 0; x < 10; x++)
          //{
            
           //Console.WriteLine ("Ingrese un nro: ");
            //n = int.Parse (Console.ReadLine ());
           
          
              //if (x == 0)
              
                //mayor = n;
              
                  //else if (n > mayor)
                  
                    //mayor = n;
                  //}


            //Console.WriteLine ("El nro mayor es: " + mayor);


          // Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

          //int edad, acu = 0, con = 0;

          //float promedio;

          //for (int x = 0; x < 20; x++)
          //{

            //Console.WriteLine ("Ingrese su edad: ");
            //edad = int.Parse (Console.ReadLine());

            //if (edad > 18)
            //{
              //acu += edad;
              //con ++;
            //}
          //}

         // promedio = acu / con;

         // Console.WriteLine ("El promedio de edades mayores a 18 es: " + promedio);

           //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
           // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.


           // int n, con = 0;

          //Console.WriteLine ("Ingrese un nro: ");
          //n = int.Parse (Console.ReadLine());

  
          //for (int x = 1; x <= n; x++)
         // {
           //  if (n % x == 0)
            // {
             //  con++;
            // }

           // }   

           // if (con == 2)
           // {
           //   Console.WriteLine ("El nro es primo");
           // }         
             //   else
               // {
                 // Console.WriteLine ("El nro no es primo");
               // }

              // 5. Hacer un programa que solicite 20 números
               // y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.


               int n, maxpar, minimpar; 
               int conpar = 0, conimpar = 0; 

               for (int x = 0; x < 5; x++) 
               {
               
                Console.WriteLine ("ingrese un nro: ");
                n = int.Parse (Console.ReadLine ());

                if (n % 2 == 0) {
              
                     if (conpar == 0)
                    
                      maxpar = n;
                      conpar = 1;
                    

                     else if (n > maxpar)
                    
                      maxpar = n;
                    
                    }       

                    conpar++;
                 
                    else 
                      {
                       conimpar++;

                      if (conimpar = 1)
                  
                    minimpar = n;
                    conimpar = 1;
                  
                      else if (n < minimpar)
                    
                      minimpar = n;
                    
                      }
                   }
                
                
                     
                  
               

                Console.WriteLine ( "el maximo de los nros pares es: " + maxpar);
                Console.WriteLine ( "el minimo de los nros impares es: " + minimpar);
                                                 

                    
               



                     
                  
                
                

               

               
                    
                
                

               
              
          
        }
    }
}
