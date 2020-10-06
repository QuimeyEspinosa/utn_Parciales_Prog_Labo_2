using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;

        #region Constructores

        /// <summary>
        /// Constructor privado de persona
        /// </summary>
        private Persona()
        {
            this.nombre = "Sin asignar";
            this.apellido = "Sin asignar";
        }

        /// <summary>
        /// Constructor público de persona
        /// </summary>
        public Persona(string nombre, string apellido) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Get nombre y apellido de la persona
        /// </summary>
        public string NombreYApellido
        {
            get { return this.Nombre + " " + this.Apellido; }
        }

        /// <summary>
        /// Get nombre de la persona
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
        }

        /// <summary>
        /// Get apellido de la persona
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
        }

        #endregion

    }
}
