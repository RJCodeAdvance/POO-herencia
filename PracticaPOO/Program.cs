using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    class Program
    {
    static void Main(string[] args)
    {
            Casa casa = new Casa();
            casa.tipoInmueble = "Casa de campo";
            casa.ubicacion = "Distrito 9";
            casa.areaTerreno = 250;
            casa.areaConstruida = 350;
            casa.cantDormitorios = 12;
            casa.cantPisos = 2;
            casa.cantBaños = 8;
            casa.precio = 98756455;
            casa.vender();
            casa.mostrarDatos();

            Departamento  departamento = new Departamento();
            departamento.tipoInmueble = "Departamento duplex";
            departamento.ubicacion = "Av Argentina";
            departamento.areaConstruida = 120;
            departamento.cantDormitorios = 4;           
            departamento.cantBaños = 2;
            departamento.precio = 3020;
            departamento.alquilar();
            departamento.mostrarDatos();

            Terreno terreno = new Terreno();
            terreno.tipoInmueble = "Terreno";
            terreno.ubicacion = "Av Ugarte";
            terreno.precio = 250000;
            terreno.vender();
            terreno.mostrarDatos();

        Console.ReadKey();
    }
    }
}
