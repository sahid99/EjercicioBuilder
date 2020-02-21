using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBuilder.Models
{
    public class Computadora
    {
        public TipoPC TipoPC { set; get; }
        public RAM RAM { set; get; }
        public Almacenamiento Almacenamiento { set; get; }
        public Procesador Procesador { set; get; }
        public TarjetaVideo TarjetaVideo { set; get; }
        public Monitor Monitor { set; get; }
        public List<Acesorios> Acesorios { set; get; }
        public string Nombre { set; get; }
        public Computadora()
        {
            this.Acesorios = new List<Acesorios>();
        }
        public Computadora(string nombre, TipoPC tipo,RAM ram, Almacenamiento almacenamiento, 
            Procesador procesador, TarjetaVideo tarjeta, Monitor monitor, List<Acesorios> acesorios)
        {
            this.Nombre = nombre;
            this.TipoPC = tipo;
            this.RAM = ram;
            this.Almacenamiento = almacenamiento;
            this.Procesador = procesador;
            this.TarjetaVideo = tarjeta;
            this.Monitor = monitor;
            this.Acesorios = acesorios;
        }
        public override string ToString()
        {
            return $"Nombre: {this.Nombre}/ Tipo de Computadora: {this.TipoPC}, RAM: {this.RAM}, " +
                $"Almacenamiente: {this.Almacenamiento}, " +
                $"Procesador: {this.Procesador}, Tarjeta de Video: {this.TarjetaVideo}, Monitor: {this.Monitor}," +
                $" Accesorios: {string.Join(",", this.Acesorios)}";
        }
    }
}
