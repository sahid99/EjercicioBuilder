using EjercicioBuilder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBuilder.Buider
{
    public class BuilderUltraBook : ComputadoraBuilder
    {
        public BuilderUltraBook()
        {
            _computadora = new Computadora();
            _computadora.Nombre = "PC para Oficina";
            _computadora.TipoPC = TipoPC.Escritorio;
            _computadora.TarjetaVideo = TarjetaVideo.SinTarjetaVideo;
            _computadora.Acesorios = new List<Acesorios>();
        }
        public override void ElegirRAM()
        {
            _computadora.RAM = RAM._8gb;
        }
        public override void ElegirProcesador()
        {
            _computadora.Procesador = Procesador._25Ghz;
        }
        public override void ElegirAlmacenamiento()
        {
            _computadora.Almacenamiento = Almacenamiento._512gb;
        }
        public override void ElegirMonitor()
        {
        }
        public override void AniadirAccesorios()
        {
        }
    }
}
