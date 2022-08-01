using System;

namespace Entidades
{
    public class CampoVacioException : Exception
    {
        public CampoVacioException(string mensaje) : base(mensaje)
        {

        }

        public CampoVacioException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
