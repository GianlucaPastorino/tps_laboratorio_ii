using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando() : this(0)
        {
        }

        public Operando(double numero) : this(numero.ToString())
        {
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        private string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        /// <summary>
        /// Convierte un número binario a decimal
        /// </summary>
        /// <param name="binario">Número binario a convertir</param>
        /// <returns>Número convertido, en caso de ser posible</returns>
        public string BinarioDecimal(string binario)
        {
            string strResutado = "Valor inválido";
            int resultado = 0;
            int potencia = 0;

            if (this.EsBinario(binario))
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    if (binario[i] == '1')
                    {
                        resultado += (int)Math.Pow(2, potencia);
                    }
                    potencia++;
                }
                strResutado = resultado.ToString();
            }

            return strResutado;
        }

        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero">Número decimal a convertir (double)</param>
        /// <returns>Número convertido, en caso de ser posible</returns>
        public string DecimalBinario(double numero)
        {
            int entero = (int)numero;
            string resultado = "";

            if (entero >= 0)
            {
                do
                {
                    if (entero % 2 == 1)
                    {
                        resultado = "1" + resultado;
                    }
                    else
                    {
                        resultado = "0" + resultado;
                    }
                    entero /= 2;
                } while (entero > 0);
            }
            else
            {
                resultado = "Valor inválido";
            }

            return resultado;
        }

        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero">Número decimal a convertir (cadena)</param>
        /// <returns>Número convertido, en caso de ser posible</returns>
        public string DecimalBinario(string numero)
        {
            double dblNumero;
            string resultado = "Valor inválido";

            if (Double.TryParse(numero, out dblNumero))
            {
                resultado = this.DecimalBinario(dblNumero);
            }

            return resultado;
        }

        /// <summary>
        /// Determina si un número es o no binario
        /// </summary>
        /// <param name="binario">Número a analizar</param>
        /// <returns>True si es binario, false si no lo es</returns>
        private bool EsBinario(string binario)
        {
            bool validez = true;

            foreach (char num in binario)
            {
                if (num != '0' && num != '1')
                {
                    validez = false;
                    break;
                }
            }

            return validez;
        }

        /// <summary>
        /// Resta dos operandos, según su atributo número
        /// </summary>
        /// <param name="n1">Número 1</param>
        /// <param name="n2">Número 2</param>
        /// <returns>Resultado de la resta</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Multiplica dos operandos, según su atributo número
        /// </summary>
        /// <param name="n1">Número 1</param>
        /// <param name="n2">Número 2</param>
        /// <returns>Resultado de la multiplicación</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Divide dos operandos, según su atributo número
        /// </summary>
        /// <param name="n1">Dividendo</param>
        /// <param name="n2">Divisor</param>
        /// <returns>Resultado de la división</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            return retorno;
        }

        /// <summary>
        /// Suma dos operandos, según su atributo número
        /// </summary>
        /// <param name="n1">Número 1</param>
        /// <param name="n2">Número 2</param>
        /// <returns>Resultado de la suma</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Valida que la cadena recibida sea un número
        /// </summary>
        /// <param name="strNumero">Cada a analizar</param>
        /// <returns>Si es un número, retorna dicho número. Si no lo es, retorna 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double.TryParse(strNumero, out double numero);
            return numero;
        }
    }
}
