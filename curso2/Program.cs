using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso2
{
    class Program
    {
        static void Main(string[] args)
        {

            Datos d = new Datos();

        
            Console.WriteLine("PROGRAMA DE RECOPILACION DE DATOS PARA EL ESTADO MAYOR DE LA REPUBLICA");

            Console.WriteLine("Escriba su nombre");
            //set nombre(String readline);
            d.setNombre(Console.ReadLine());

            Console.WriteLine("Su nombre capturado es : " + d.getNombre());

            Datos a = new Datos();


            Console.WriteLine("Escriba su primer apellido");
            //set nombre(String readline);
            a.setApellido(Console.ReadLine());

            Console.WriteLine("Su apellido capturado es : " + a.getApellido1());

            Datos e = new Datos();


            Console.WriteLine("Escriba su segundo apellido");
            //set nombre(String readline);
            e.setApellido2(Console.ReadLine());

            Console.WriteLine("Su segundo apellido capturado es : " + e.getApellido2());

            Console.WriteLine("Su nombre completo es " + d.getNombre() + a.getApellido1() + e.getApellido2());
            Console.WriteLine("Enviando al servidor estoesunabroma.com");
            Console.WriteLine("Broma finalizada");
           

            Console.ReadKey();


        }
    }
}
