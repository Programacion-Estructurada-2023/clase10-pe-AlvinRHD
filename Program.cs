// using System;

// namespace MyApp// Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//          static void Main(string[] args)
//         {

//             //EJERCICIOS CON ESTRUCTURA SWITCH-CASE

//             Console.WriteLine("\nOPciones de programas\n" 
//             + "1.Programa de edad\n" 
//             + "2.Programa de numero par o impar\n" 
//             + "Ingrese la opcion que desea ejecutar: ");

//             int opcion = Convert.ToInt32(Console.ReadLine());

//             switch (opcion)
//             {
//                 case 1:
//                 //PROGRAMA PARA PODER CALCULAR SI ES MAYOR DE EDAD

//                     Console.WriteLine("\n---PROGRAMA QUE DETERMINE SI ES MAYOR DE EDAD---\n");

//                     Console.WriteLine("\nIngrese tu edad: ");
//                     int edad=Convert.ToInt32(Console.ReadLine());

//                     if (edad >=18 || edad <=25)
//                     {
//                         Console.WriteLine("\nTu edad es " + edad +  " eres un adulto joven ");

//                     }

//                     else if (edad >=26 && edad <=59)
//                     {
//                          Console.WriteLine("\nTu edad es " + edad +  " eres un adulto ");
//                     }

//                     else if (edad >=60)
//                     {
//                         Console.WriteLine("\nTu edad es " + edad +  " eres un adulto mayor ");
//                     }
//                     else{

//                         Console.WriteLine("Tu edad es " + edad + " eres menor de edad");
//                     }

//                     break;

//                 case 2:


//                     Console.WriteLine("\n\n---PROGRAMA QUE DETERMINE SI UN NUMERO ES PAR O IMPAR---\n");
//                     Console.WriteLine("\nIngrese un numero: ");
//                     int numero=Convert.ToInt32(Console.ReadLine());

//                     if (numero % 2 == 0)
//                     {
//                         Console.WriteLine("\nEl numero " + numero + " es par");
//                     }
//                     else
//                     {
//                         Console.WriteLine("\nEl numero " + numero + " es impar");
//                     }

//                 break;
//                 default:
//                 Console.WriteLine("Numero invalido, ingresa la opcion 1 o 2.");
//                     break;
//             }//Fin del awitch

//             Console.ReadKey();
//         }
//     }
// }




using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero del mes");
            int Mes = Convert.ToInt32(Console.ReadLine());

            string nMes;

            switch (Mes)
            {
                case 1:
                    nMes = "Enero";
                    break;
                case 2:
                    nMes = "Febrero";
                    break;
                case 3:
                    nMes = "Marzo";
                    break;
                case 4:
                    nMes = "Abril";
                    break;
                case 5:
                    nMes = "Mayo";
                    break;
                case 6:
                    nMes = "Junio";
                    break;
                default:
                    nMes = "Advertencia numero de mes no valido, ingrese un numero del 1 al 6";
                    break;
            }

            Console.WriteLine("El nombre del mes es: " + nMes);
        }
    }
}

