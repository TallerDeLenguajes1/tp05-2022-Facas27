using System;

namespace tp052022{

    class Program{



        static void Main(string[] args){
            

            Console.WriteLine("Ingrese la cadena");
            string palabra = Console.ReadLine();
            string subpala = palabra.Substring(0,2);
            string palabra2 ="Helado";
            Console.WriteLine(subpala);
            foreach (var item in palabra)
            {
               Console.WriteLine(item);
            }
            
         
          
            
            int longi = palabra.Length;
            string conc = palabra+palabra2;
            Console.WriteLine(palabra.ToUpper());
            Console.WriteLine(palabra.ToLower());
            if (palabra.Equals(palabra2))
            {
                Console.WriteLine("Son iguales");
            }else
            {
                Console.WriteLine("NO son iguales");
            }
            string CorPal = "Hola . Mundo . Cortado . En . Partes";
            string[] sub = CorPal.Split('.');
            foreach (var item in sub)
            {
                Console.WriteLine($"SubsStrinfs: {item}");
            }




           
            Console.WriteLine(palabra);
            Console.WriteLine(longi);
            Console.WriteLine(conc);



        

    }

}
}