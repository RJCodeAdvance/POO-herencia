using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Terreno : Inmueble
    {
        //Estados - Atributos 
        //Comportamientos - Métodos
        public void mostrarDatos()
        {
            Console.WriteLine("Detalles de Inmueble");
            Console.WriteLine("\tTipo de Inmueble: " + tipoInmueble);
            Console.WriteLine("\tDireccion: " + ubicacion);
            Console.WriteLine("\tArea de terreno: " + areaTerreno);
            Console.WriteLine("\tCantidad de baños: " + cantBaños);
            Console.WriteLine("\tPrecio: " + precio);
            Console.WriteLine("---------------------------------\n\n");
        }
    }
}
