using EjercicioBuilder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBuilder.Buider
{
    public class BuilderComputadoraGamer : ComputadoraBuilder
    {
        public BuilderComputadoraGamer(TarjetaVideo tarjeta)
        {
            _computadora = new Computadora();
            _computadora.Nombre = "PC Gamer";
            _computadora.TipoPC = TipoPC.Escritorio;
            _computadora.TarjetaVideo = tarjeta;
            _computadora.Acesorios = new List<Acesorios>();
        }
        public override void ElegirRAM()
        {
            _computadora.RAM = RAM._64gb;
        }
        public override void ElegirProcesador()
        {
            _computadora.Procesador = Procesador._29Ghz;
        }
        public override void ElegirAlmacenamiento()
        {
            _computadora.Almacenamiento = Almacenamiento._2048gb;
        }
        public override void ElegirMonitor()
        {
            _computadora.Monitor = Monitor._32in;
        }
        public override void AniadirAccesorios()
        {
            _computadora.Acesorios.Add(Acesorios.Mouse);
            _computadora.Acesorios.Add(Acesorios.Teclado);
        }
    }
}
