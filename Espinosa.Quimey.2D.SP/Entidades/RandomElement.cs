using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class RandomElement
    {
        static Random nRand;

        /// <summary>
        /// Constructor estático de clase
        /// </summary>
        static RandomElement()
        {
            nRand = new Random();
        }

        #region Métodos

        /// <summary>
        /// Genera y devuelve un nombre aleatorio
        /// </summary>
        /// <returns>Nombre generado</returns>
        public static string Nombre()
        {
            string[] nombres = new string[] { "Ezequiel", "Lucas", "Quimey", "Elias", "Santiago", "Alejo", "Sergio", "Ludmila", "Juliana",
                                               "Joaquin", "Federico", "Gonzalo", "Daniela", "Ana", "Nehuen", "Julieta", "Abril", "Pepe", };
            int indexNombres = nRand.Next(0, nombres.Length);

            return nombres[indexNombres];
        }

        /// <summary>
        /// Genera y devuelve una calle aleatoria
        /// </summary>
        /// <returns>Calle generada</returns>
        public static string Calle()
        {
            string[] calles = new string[] { "9 de Julio", "Corrientes", "Av. Libertador", "Av. Alvear", "Av. Córdoba", "Peatonal Florida" };

            int indexCalles = nRand.Next(0, calles.Length);

            return calles[indexCalles] + " " + nRand.Next(100, 3500).ToString();
        }

        /// <summary>
        /// Devuelve un boolean aleatorio
        /// </summary>
        /// <returns></returns>
        public static bool Boolean()
        {
            bool miBool = nRand.Next(0, 2) > 0;

            return miBool;
        }

        /// <summary>
        /// Devuelve un tiempo de entrega random entre 7200ms y 11001ms
        /// </summary>
        /// <returns></returns>
        public static int TiempoEntregaRandom()
        {
            return nRand.Next(7200, 11001);
        }

        /// <summary>
        /// Devuelve un tiempo de preparación random entre 4 y 7 segundos
        /// </summary>
        /// <returns></returns>
        public static int TiempoPreparacionRandom()
        {
            return nRand.Next(3000, 7000);
        }

        #endregion
    }
}
