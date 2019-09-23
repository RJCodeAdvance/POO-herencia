using System;

namespace PracticaPOO
{
    public class Inmueble
    {
        //Estados - Atributos
        public string tipoInmueble;
        public string ubicacion;
        public double areaTerreno;
        public int cantBaños;
        public double precio;

        //Comportamientos - Métodos
        public void vender()
        {
            Console.WriteLine(tipoInmueble+ " VENDIDA por el precio de "+precio +"\nMas detalles:");            
        }

        public void alquilar()
        {
            Console.WriteLine(tipoInmueble + " puesto en ALQUILERpor el precio de " + precio + "\nMas detalles:");           
        }

    }
}
