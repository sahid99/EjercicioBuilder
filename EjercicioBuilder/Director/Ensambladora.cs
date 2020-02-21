using System;
using System.Collections.Generic;
using System.Text;
using EjercicioBuilder.Buider;
using EjercicioBuilder.Models;

namespace EjercicioBuilder.Director
{
    public class Ensambladora
    {
        private ComputadoraBuilder _computadoraBuilder;
        public Ensambladora(ComputadoraBuilder computadoraBuilder)
        {
            _computadoraBuilder = computadoraBuilder;
        }
        public Computadora ObtenerComputadora()
        {
            _computadoraBuilder.ElegirRAM();
            _computadoraBuilder.ElegirAlmacenamiento();
            _computadoraBuilder.ElegirProcesador();
            _computadoraBuilder.AniadirAccesorios();
            _computadoraBuilder.ElegirMonitor();
            return _computadoraBuilder.ObtenerComputadora;
        }

    }
}
