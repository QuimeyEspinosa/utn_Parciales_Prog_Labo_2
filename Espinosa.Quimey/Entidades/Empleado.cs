using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Empleado : Persona
    {
        static int idIncremental = 1000; 
        int id;
        double sueldo;
        string usuario;
        string contraseña;

        #region Constructores

        /// <summary>
        /// Constructor público Empleado
        /// </summary>
        /// <param name="nombre">Nombre del empleado</param>
        /// <param name="apellido">Apellido del empleado</param>
        /// <param name="sueldo">Sueldo del empleado</param>
        /// <param name="usuario">Usuario del empleado</param>
        /// <param name="contraseña">Contraseña del empleado</param>
        public Empleado(string nombre, string apellido, double sueldo, string usuario, string contraseña) : base(nombre, apellido)
        {
            this.id = idIncremental++;
            this.sueldo = sueldo;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        #endregion


        #region Propiedades

        /// <summary>
        /// Get id Empleado
        /// </summary>
        public int Id
        {
            get { return this.id; }
        }

        /// <summary>
        /// Get sueldo Empleado
        /// </summary>
        public double Sueldo
        {
            get { return this.sueldo; }
        }

        /// <summary>
        /// Get usuario Empleado
        /// </summary>
        public string Usuario
        {
            get { return this.usuario; }
        }

        /// <summary>
        /// Get contraseña Empleado
        /// </summary>
        public string Contraseña
        {
            get { return this.contraseña; }
        }

        #endregion


        #region Sobrecargas

        /// <summary>
        /// Sobrecarga de operador '==' que verifica si un empleado ya existe en base al Id
        /// </summary>
        /// <param name="unEmpleado">empleado a buscar</param>
        /// <param name="misEmpleados">lista de empleados</param>
        /// <returns>True si es igual, false si es distinto</returns>
        public static bool operator ==(Empleado unEmpleado, List<Empleado> misEmpleados)
        {
            bool retorno = false;

            for (int i = 0; i < misEmpleados.Count; i++)
            {
                if (unEmpleado.id == misEmpleados[i].id)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga de operador '!=' que verifica si un empleado es distinto a otro en base al Id
        /// </summary>
        /// <param name="unEmpleado">empleado a buscar</param>
        /// <param name="misEmpleados">lista de empleados</param>
        /// <returns>True si es distinto, false si es igual</returns>
        public static bool operator !=(Empleado unEmpleado, List<Empleado> misEmpleados)
        {
            return !(unEmpleado == misEmpleados);
        }

        /// <summary>
        /// Sobrecarga de operador '+' que agrega un empleado a la lista de empleados
        /// </summary>
        /// <param name="misEmpleados">Lista de empleados</param>
        /// <param name="unEmpleado">Empleado a agregar</param>
        /// <returns>True si pudo agregar, false si no</returns>
        public static bool operator +(List<Empleado> misEmpleados, Empleado unEmpleado)
        {
            bool retorno = false;

            if (unEmpleado != misEmpleados)
            {
                misEmpleados.Add(unEmpleado);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga de operador '-' que elimina un empleado de la lista de empleados
        /// </summary>
        /// <param name="misEmpleados">Lista de empleados</param>
        /// <param name="unEmpleado">Empleado a eliminar</param>
        /// <returns>True si pudo eliminar, false si no</returns>
        public static bool operator -(List<Empleado> misEmpleados, Empleado unEmpleado)
        {
            return !(misEmpleados + unEmpleado);
        }

        #endregion
    }
}

