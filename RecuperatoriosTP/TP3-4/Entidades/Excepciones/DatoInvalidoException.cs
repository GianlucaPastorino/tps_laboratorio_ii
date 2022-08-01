using System;

namespace Entidades
{
    public class DatoInvalidoException : Exception
    {
        public DatoInvalidoException(string mensaje) : base(mensaje)
        {

        }

        public DatoInvalidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
