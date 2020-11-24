using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NuevoPedidoException : Exception
    {
        /// <summary>
        /// Excepcion que se lanza si no pudo generarse un nuevo pedido
        /// </summary>
        public NuevoPedidoException() : base("No se pudo generar un nuevo pedido")
        {
        }
        /// <summary>
        /// Excepcion que se lanza si no pudo generarse un nuevo pedido
        /// </summary>
        /// <param name="message">mensaje recibido por parámetro</param>
        public NuevoPedidoException(string message) : base(message)
        {
        }
    }
}
