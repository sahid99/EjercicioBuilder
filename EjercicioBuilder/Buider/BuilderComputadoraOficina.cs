using EjercicioBuilder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBuilder.Buider
{
    public class BuilderComputadoraOficina : ComputadoraBuilder
    {
        public BuilderComputadoraOficina()
        {
            _computadora = new Computadora();
            _computadora.Nombre = "PC para Oficina";
            _computadora.TipoPC = TipoPC.Escritorio;
            _computadora.TarjetaVideo = TarjetaVideo.SinTarjetaVideo;
            _computadora.Acesorios = new List<Acesorios>();
        }
        public override void ElegirRAM()
        {
            _computadora.RAM = RAM._16gb;
        }
        public override void ElegirProcesador()
        {
            _computadora.Procesador = Procesador._20Ghz;
        }
        public override void ElegirAlmacenamiento()
        {
            _computadora.Almacenamiento = Almacenamiento._1024gb;
        }
        public override void ElegirMonitor()
        {
            _computadora.Monitor = Monitor._27in;
        }
        public override void AniadirAccesorios()
        {
            _computadora.Acesorios.Add(Acesorios.Mouse);
            _computadora.Acesorios.Add(Acesorios.Teclado);
        }
    }
}
