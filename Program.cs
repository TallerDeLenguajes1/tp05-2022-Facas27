using System;

namespace tp052022{

    class Program{



        static void Main(string[] args){

            Console.WriteLine("Ingrese el primer numero");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double numero2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Elija la opcion a hacer con sus numeros");
            Console.WriteLine("1 - Sumar sus numero");
            Console.WriteLine("2 - Restar datos");
            Console.WriteLine("3 - Multiplar los numeros ");
            Console.WriteLine("5 - Valor Absoluto");
            Console.WriteLine("6 - Cuadrado");
            Console.WriteLine("7 - Raiz Cuadrada");
            Console.WriteLine("8 - Seno");
            Console.WriteLine("9 - Coseno");
            Console.WriteLine("10 - Parte entera de un float");
            Console.WriteLine("Ingrese su opcion");

            int opc = Convert.ToInt32(Console.ReadLine());
            double res;
            switch (opc)
            {
                case 1:
                     res = numero1 + numero2;
                     Console.WriteLine("El resultado de sumar {0} y {1} es {2}", numero1 , numero2 , res);
                    break;
                case 2:
                    res  = numero1 - numero2;
                    Console.WriteLine("El resultado de restar {0} con {1} es {2}", numero1 , numero2 , res);
                    break;
                case 3:
                    res  = numero1 * numero2;
                    Console.WriteLine("El resultado de multiplicar {0} por {1} es {2}", numero1 , numero2 , res);
                    break;
                case 4:
                   if (numero2 == 0)
                   {
                        Console.WriteLine("No se puede dividr en cero");
                        
                   }else
                   {
                       res = numero1/numero2;
                       Console.WriteLine("El resultado de dividir {0} en {1} es {2}", numero1 , numero2 , res);
                   }
                    break;
                case 5:
                    double num1 = System.Math.Abs(numero1);
                    double num2 = System.Math.Abs(numero2);
                    Console.WriteLine("El valor absoluto de {0} es {1}",numero1, num1);
                    Console.WriteLine("El valor absoluto de {0} es {2}",numero2, num2);
                    break;
                case 6:
                    Console.WriteLine("El cuadrado de {0} es {1}",numero1, System.Math.Pow(numero1, 2));
                    Console.WriteLine("El cuadrado de {0} es {1}",numero2, System.Math.Pow(numero2, 2));
                    break;
                case 7:
                    Console.WriteLine("La raiz cuadrada de {0} es {1}",numero1, System.Math.Pow(numero1, 1/2));
                    Console.WriteLine("La raiz cuadrada de {0} es {1}",numero2, System.Math.Pow(numero2, 1/2));
                    break;
                case 8:
                    Console.WriteLine("El seno de {0} es {1}",numero1, System.Math.Sin(numero1));
                    Console.WriteLine("El seno de {0} es {1}",numero2, System.Math.Sin(numero2));
                    break;
                case 9:
                    Console.WriteLine("El Coseno de  {0} es {1}",numero1, System.Math.Cos(numero1));
                    Console.WriteLine("El Coseno  de {0} es {1}",numero2, System.Math.Cos(numero2));
                    break;
                case 10:
                    Console.WriteLine("La parte entera  de {0} es {1}",numero1,System.Math.Truncate(numero1));
                    Console.WriteLine("La parte entera de {0} es {1}",numero2,System.Math.Truncate(numero2));
                    break;                        
                    
            }




        }

    }

}