using EjercicioBuilder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBuilder.Buider
{
    public abstract class ComputadoraBuilder
    {
        public TarjetaVideo tarjeta { set; get; }
        public Computadora _computadora;
        public Computadora ObtenerComputadora
        {
            get { return this._computadora; }
        }
        public virtual void ElegirRAM()
        {

        }
        public virtual void ElegirAlmacenamiento()
        {

        }
        public virtual void ElegirProcesador()
        {

        }
        public virtual void ElegirMonitor()
        {

        }
        public virtual void AniadirAccesorios()
        {

        }
    }
}
