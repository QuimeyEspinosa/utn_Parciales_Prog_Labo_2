using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cliente : Persona
    {
        int dni;

        #region Constructores

        /// <summary>
        /// Constructor público de Cliente
        /// </summary>
        /// <param name="dni">Dni del cliente</param>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="apellido">Apellidp del cliente</param>
        public Cliente(int dni, string nombre, string apellido) : base(nombre, apellido)
        {
            this.dni = dni;
        }

        #endregion


        #region Propiedades

        /// <summary>
        /// Get del Dni del cliente
        /// </summary>
        public int Dni
        {
            get { return this.dni; }
        }
        #endregion


        #region Sobrecargas

        /// <summary>
        /// Sobrecarga de operador '==' que verifica si un cliente ya existe en base al Id
        /// </summary>
        /// <param name="unCliente">cliente a buscar</param>
        /// <param name="misClientes">lista de clientes</param>
        /// <returns>True si es igual, false si es distinto</returns>
        public static bool operator ==(Cliente unCliente, List<Cliente> misClientes)
        {
            bool retorno = false;

            for (int i = 0; i < misClientes.Count; i++)
            {
                if (unCliente.dni == misClientes[i].dni)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga de operador '!=' que verifica si un cliente es distinto a otro en base al Dni
        /// </summary>
        /// <param name="unCliente">cliente a buscar</param>
        /// <param name="misClientes">lista de clientes</param>
        /// <returns>True si es distinto, false si es igual</returns>
        public static bool operator !=(Cliente unCliente, List<Cliente> misClientes)
        {
            return !(unCliente == misClientes);
        }

        /// <summary>
        /// Sobrecarga de operador '+' que agrega un cliente a la lista de clientes
        /// </summary>
        /// <param name="misClientes">Lista de clientes</param>
        /// <param name="unCliente">Cliente a agregar</param>
        /// <returns>True si pudo agregar, false si no</returns>
        public static bool operator +(List<Cliente> misClientes, Cliente unCliente)
        {
            bool retorno = false;

            if (unCliente != misClientes)
            {
                misClientes.Add(unCliente);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga de operador '-' que elimina un Cliente de la lista de Clientes
        /// </summary>
        /// <param name="misClientes">Lista de Clientes</param>
        /// <param name="unCliente">Cliente a eliminar</param>
        /// <returns>True si pudo eliminar, false si no</returns>
        public static bool operator -(List<Cliente> misClientes, Cliente unCliente)
        {
            return !(misClientes + unCliente);
        }

        #endregion
    }
}
