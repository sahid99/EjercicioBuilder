using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBuilder.Models
{
    public enum TipoPC
    {
        Escritorio,
        Portatil
    }
    public enum RAM
    {
        _8gb,
        _16gb,
        _32gb,
        _64gb
    }
    public enum Almacenamiento
    {
        _256gb, 
        _512gb, 
        _1024gb, 
        _2048gb
    }
    public enum Procesador
    {
        _20Ghz,
        _25Ghz,
        _28Ghz,
        _29Ghz
    }
    public enum TarjetaVideo
    {
        _64gb,
        _128gb,
        _256gb,
        _512gb,
        SinTarjetaVideo
    }
    public enum Monitor
    {
        _24in,
        _25in,
        _27in, 
        _32in,
    }
    public enum Acesorios
    {
        Teclado,
        Mouse,
    }
            
 
}
