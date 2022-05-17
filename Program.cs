using System;

namespace tp052022{

    class Program{



        static void Main(string[] args){

            Console.WriteLine("Ingrese el primer numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elija la opcion a hacer con sus numeros");
            Console.WriteLine("1-Sumar sus numero");
            Console.WriteLine("2 - Restar datos");
            Console.WriteLine("3 - Multiplar los numeros ");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("Ingrese su opcion");

            int opc = Convert.ToInt32(Console.ReadLine());
            float res;
            switch (opc)
            {
                case 1:
                     res = numero1 + numero2;
                     Console.WriteLine(res);
                    break;
                case 2:
                    res  = numero1 - numero2;
                    Console.WriteLine(res);
                    break;
                case 3:
                    res  = numero1 * numero2;
                    Console.WriteLine(res);
                    break;
                case 4:
                   if (numero2 == 0)
                   {
                        Console.WriteLine("No se puede dividr en cero");
                        
                   }else
                   {
                       res = numero1/numero2;
                       Console.WriteLine(res);
                   }
                    break;
                    
            }

           

            



        }

    }

}