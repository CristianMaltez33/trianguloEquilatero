using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianguloEquilatero
{
    /// <summary>
    /// Calcula si un triangulo es equilatero o no, en base a valor de todos sus lados
    /// </summary>
    class Calculos
    {
        /// <summary>
        /// Calcula si un triangulo es equilatero o no, en base a valor de todos sus lados
        /// </summary>
        /// <param name="ladoA"> Guarda el valor del lado A del triangulo </param>
        /// <param name="ladoB"> Guarda el valor del lado B del triangulo </param>
        /// <param name="ladoC"> Guarda el valor del lado C del triangulo </param>
        /// <returns> Retorna un string, confirmando o negando si un triangulo ingresado es equilatero o no </returns>
        public string calcularEquilatero(double ladoA, double ladoB, double ladoC)
        {
            string respuesta;

            if (ladoA == ladoB && ladoA == ladoC)
                respuesta = "Es equilatero";
            else
                respuesta = "No es equilatero";

            return respuesta;
        }
    }
}
