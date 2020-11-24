using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivoException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ArchivoException() : base("Archivo Exception")
        {
        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="mensaje"></param>
        public ArchivoException(string mensaje) : base(mensaje)
        {
        }

        /// <summary>
        /// Excepcion que controla si el archivo es null
        /// </summary>
        /// <param name="e"> Excepcion </param>
        public ArchivoException(Exception innerException) : base("Archivo Exception", innerException)
        {
        }
    }
}
