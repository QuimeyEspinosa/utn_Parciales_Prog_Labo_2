using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Hamburguesa
    {
        int id;
        string descripcion;
        float precio;

        #region Constructores

        /// <summary>
        /// Constructor de clase, se utiliza para poder generar el archivo xml
        /// </summary>
        public Hamburguesa()
        {
        }

        /// <summary>
        /// Constructor público de clase
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        public Hamburguesa(int id, string descripcion, float precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Get y set del id
        /// </summary>
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Get y set de la descripción
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        /// <summary>
        /// Get y set del precio
        /// </summary>
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Genera un string con los datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder datosCB = new StringBuilder();

            datosCB.Append($"ID:{this.id} | Hamburguesa {this.descripcion} ${this.precio}");

            return datosCB.ToString();
        }

        #endregion
    }
}
