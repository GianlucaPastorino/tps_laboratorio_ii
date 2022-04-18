using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza el cálculo
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operador</param>
        /// <returns>Resultado</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            switch (Calculadora.ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida el operador
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Si el operador es válido, lo retorna. Sino, retorna un +</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                operador = '+';
            }

            return operador;
        }
    }
}
