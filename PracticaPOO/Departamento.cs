using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Departamento:Inmueble
    {
        //Estados - Atributos
        public double areaConstruida;
        public int cantDormitorios;

        //Comportamientos - Métodos  
        public void mostrarDatos()
        {
            Console.WriteLine("Detalles de Inmueble");
            Console.WriteLine("\tTipo de Inmueble: " + tipoInmueble);
            Console.WriteLine("\tDireccion: " + ubicacion);      
            Console.WriteLine("\tArea construida: " + areaConstruida);
            Console.WriteLine("\tArea de terreno: " + areaTerreno);
            Console.WriteLine("\tCantidad de dormitorios: " + cantDormitorios);
            Console.WriteLine("\tCantidad de baños: " + cantBaños);
            Console.WriteLine("\tPrecio: "+precio);
            Console.WriteLine("---------------------------------\n\n");
        }
    }
}
