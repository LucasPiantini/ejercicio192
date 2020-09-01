using System;
using System.Collections.Generic;
using System.Text;
namespace AplicacionBase
{
    class Program
    {
        //funcion principal donde inicia la aplicacion
        static void Main(string[] args)
        {
            //variables necesarias
            int cantidad = 0; //cantidad de alumnos
            int n = 0; // variable de control del ciclo
            string valor = "";

            //variable para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;

            float minima = 10.0f; //variable para la clasificacion minima
            float maxima = 0.0f; //variable para la calificacion maxima
           
            //pedimos la cantidad de alumnos
            Console.WriteLine("Dame la cantidad de alumnos");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            //creamos el arreglo
            float[] calif = new float[cantidad];

            //capturamos la informacion
            for (n = 0; n < cantidad; n++)
            {
                Console.Write("Dame la calificacion ");
                valor = Console.ReadLine();
                calif[n] = Convert.ToSingle(valor);
            }
            //Encontramos el promedio
            for (n = 0; n < cantidad; n++)
            {
                suma += calif[n];
            }
            promedio = suma / cantidad;
            //encontramos la calificacion minima
            for (n = 0; n < cantidad; n++)
            {

                if(calif[n] > maxima)
                minima = calif[n];
        }
        //encontramos la calificacion maxima
        for (n = 0; n < cantidad; n++)
        {
        if (calif[n] > maxima)
            maxima = calif[n];
      }
        //desplegamos los resultados
            Console.WriteLine("El primedio es {0}" , promedio );
            Console.WriteLine("La calificacion minima es {0}" , minima);
            Console.WriteLine("La calificacion maxima es {0}" , maxima);
            Console.ReadKey();
        } //cierre del main
}//cierre de la clase
    
}

