using System;
using EjercicioBuilder.Buider;
using EjercicioBuilder.Models;
using EjercicioBuilder.Director;

namespace EjercicioBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var compu = new Ensambladora(new BuilderComputadoraGamer(TarjetaVideo._256gb));
            Console.WriteLine(compu.ObtenerComputadora().ToString());
            compu = new Ensambladora(new BuilderComputadoraOficina());
            Console.WriteLine(compu.ObtenerComputadora().ToString());
            compu = new Ensambladora(new BuilderUltraBook());
            Console.WriteLine(compu.ObtenerComputadora().ToString());
            Console.ReadKey();
        }
    }
}
