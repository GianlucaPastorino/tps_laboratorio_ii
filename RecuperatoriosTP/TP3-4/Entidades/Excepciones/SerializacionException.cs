using System;

namespace Entidades
{
    public class SerializacionException : Exception
    {
        public SerializacionException(string mensaje) : base(mensaje)
        {

        }

        public SerializacionException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
