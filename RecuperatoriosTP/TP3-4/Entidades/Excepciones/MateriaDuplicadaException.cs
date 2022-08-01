using System;

namespace Entidades
{
    class MateriaDuplicadaException : Exception
    {
        public MateriaDuplicadaException(string mensaje) : base(mensaje)
        {

        }

        public MateriaDuplicadaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
