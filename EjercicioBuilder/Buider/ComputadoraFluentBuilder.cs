using EjercicioBuilder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBuilder.Buider
{
    public class ComputadoraFluentBuilder
    {
        private Computadora _computadora;
        private ComputadoraFluentBuilder(TarjetaVideo tarjeta)
        {
            _computadora = new Computadora();
            _computadora.Nombre = "Custom PC Escritorio";
            _computadora.TipoPC = TipoPC.Escritorio;
            _computadora.Acesorios = new List<Acesorios>();
        }
        public static ComputadoraFluentBuilder Crear(TarjetaVideo tarjeta)
        {
            return new ComputadoraFluentBuilder(tarjeta);
        }
        public ComputadoraFluentBuilder RAM8Gb()
        {
            _computadora.RAM = RAM._8gb;
            return this;
        }
        public ComputadoraFluentBuilder RAM16Gb()
        {
            _computadora.RAM = RAM._16gb;
            return this;
        }
        public ComputadoraFluentBuilder RAM32Gb()
        {
            _computadora.RAM = RAM._32gb;
            return this;
        }
        public ComputadoraFluentBuilder RAM64Gb()
        {
            _computadora.RAM = RAM._64gb;
            return this;
        }

        public ComputadoraFluentBuilder Almacenamiento256Gb()
        {
            _computadora.Almacenamiento = Almacenamiento._256gb;
            return this;
        }
        public ComputadoraFluentBuilder Almacenamiento512Gb()
        {
            _computadora.Almacenamiento = Almacenamiento._512gb;
            return this;
        }
        public ComputadoraFluentBuilder Almacenamiento1024Gb()
        {
            _computadora.Almacenamiento = Almacenamiento._1024gb;
            return this;
        }
        public ComputadoraFluentBuilder Almacenamiento2048Gb()
        {
            _computadora.Almacenamiento = Almacenamiento._2048gb;
            return this;
        }

        public ComputadoraFluentBuilder Procesador20GHz()
        {
            _computadora.Procesador = Procesador._20Ghz;
            return this;
        }
        public ComputadoraFluentBuilder Procesador25GHz()
        {
            _computadora.Procesador = Procesador._25Ghz;
            return this;
        }
        public ComputadoraFluentBuilder Procesador28GHz()
        {
            _computadora.Procesador = Procesador._28Ghz;
            return this;
        }
        public ComputadoraFluentBuilder Procesador29GHz()
        {
            _computadora.Procesador = Procesador._29Ghz;
            return this;
        }
        public ComputadoraFluentBuilder TarjetVideo64()
        {
            _computadora.TarjetaVideo = TarjetaVideo._64gb;
            return this;
        }
        public ComputadoraFluentBuilder TarjetVideo128()
        {
            _computadora.TarjetaVideo = TarjetaVideo._128gb;
            return this;
        }
        public ComputadoraFluentBuilder TarjetVideo256()
        {
            _computadora.TarjetaVideo = TarjetaVideo._256gb;
            return this;
        }
        public ComputadoraFluentBuilder TarjetVideo512()
        {
            _computadora.TarjetaVideo = TarjetaVideo._512gb;
            return this;
        }

        public ComputadoraFluentBuilder Monitor24in()
        {
            _computadora.Monitor = Monitor._24in;
            return this;
        }
        public ComputadoraFluentBuilder Monitor25in()
        {
            _computadora.Monitor = Monitor._25in;
            return this;
        }
        public ComputadoraFluentBuilder Monitor27in()
        {
            _computadora.Monitor = Monitor._27in;
            return this;
        }
        public ComputadoraFluentBuilder Monitor32in()
        {
            _computadora.Monitor = Monitor._32in;
            return this;
        }
        public ComputadoraFluentBuilder AgregarAccesorio(Acesorios acesorios)
        {
            _computadora.Acesorios.Add(acesorios);
            return this;
        }
    }
}
