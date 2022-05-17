using System;

namespace tp052022{

    class Program{



        static void Main(string[] args){

            int numero = Convert.ToInt32(Console.ReadLine());
            string numInvertido = "";


            foreach(char c in Convert.ToString(numero)){
                numInvertido = c + numInvertido;
            }

            Console.WriteLine(numInvertido);



        }

    }

}