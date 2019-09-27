using System;
using System.Collections.Generic;
using System.Text;

namespace Conversion_C
{
    class Principal
    {

        public void Convertir(int Totalcentavos,out int Pesos,out int Centavos)//Se crea un metodo para 
            //la conversión donde totalcentavos es un parametro de entrada y los otros dos son de salida que son los que retornan
            //valor.
        {
          //Se realizan las operaciónes de conversion.
            Pesos = Totalcentavos / 100;
           
            Centavos = Totalcentavos % 100;

        }
        //Metodo de menú
        public void Menu()
        {
            int Totalcentavos;
            int Pesos = 0;
            int Centavos = 0;
            Console.WriteLine("Hola, bienvenido a la conversión de pesos");
            Console.WriteLine("Ingrese valor a convertir:");
            Totalcentavos = Convert.ToInt32(Console.ReadLine());//Ingresa el valor que se convertira
            Convertir(Totalcentavos, out Pesos, out Centavos);//Se manda los parametros. Totalcentavo tomandolo como el
            //parametro de entrada mientras que los otros seran de salida.
            Console.WriteLine("El resultado es:" + Pesos +"."+ Centavos);//se imprimen los resultados
            Console.ReadKey();
                
        }
    }
}
