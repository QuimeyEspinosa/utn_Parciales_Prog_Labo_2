using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        public enum ETipo
        {
            Almacen, Refrigerado, Revista
        }
        int numArticulo;
        string descripcion;
        double precio;
        int stock;
        ETipo tipoProducto;

        #region Constructores

        /// <summary>
        /// Constructor privado de la clase Producto
        /// </summary>
        private Producto()
        {
            this.numArticulo = -1;
            this.descripcion = "Sin asignar";
            this.precio = -1;
            this.stock = -1;
        }

        /// <summary>
        /// Constructor público de la clase Producto
        /// </summary>
        /// <param name="numArticulo">Numero de articulo del producto</param>
        /// <param name="descripcion">Descripción del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="stock">Stock del producto</param>
        /// <param name="tipoProd">Tipo de producto</param>
        public Producto(int numArticulo, string descripcion, double precio, int stock, ETipo tipoProd) : this()
        {
            this.numArticulo = numArticulo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.tipoProducto = tipoProd;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Get de numero de artículo
        /// </summary>
        public int NumArticulo
        {
            get { return this.numArticulo; }
        }

        /// <summary>
        /// Get de tipo de producto
        /// </summary>
        public string Tipo
        {
            get { return this.tipoProducto.ToString(); }
        }

        /// <summary>
        /// Get de descripción
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion; }
        }

        /// <summary>
        /// Get y Set del precio unitario, valida que el precio sea mayor a 0
        /// </summary>
        public double PrecioUnitario
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (Validaciones.EsPositivo(value))
                {
                    this.precio = value;
                }
            }
        }

        /// <summary>
        /// Get y Set de las unidades del producto, valida que la cantidad sea mayor a 0
        /// </summary>
        public int Unidades
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (Validaciones.EsPositivo(value))
                {
                    this.stock = value;
                }
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Muestra los datos del Producto
        /// </summary>
        /// <returns>String con los datos del producto</returns>
        public virtual string MostrarProducto()
        {
            StringBuilder miProd = new StringBuilder();

            miProd.AppendLine($"N° Artículo: {this.numArticulo}");
            miProd.AppendLine($"Descripcion: {this.descripcion}");
            miProd.AppendLine($"Precio: ${this.precio}");
            miProd.AppendLine($"Stock: {this.stock}");

            return miProd.ToString();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Override de MostrarProducto
        /// </summary>
        /// <returns>los datos del producto</returns>
        public override string ToString()
        {
            return this.MostrarProducto();
        }

        /// <summary>
        /// Sobrecarga de operador '==' que verifica si un Producto ya existe en base al Id
        /// </summary>
        /// <param name="unProducto">Producto a buscar</param>
        /// <param name="misProductos">lista de Productos</param>
        /// <returns>True si es igual, false si es distinto</returns>
        public static bool operator ==(Producto unProducto, List<Producto> misProductos)
        {
            bool retorno = false;

            for (int i = 0; i < misProductos.Count; i++)
            {
                if (unProducto.numArticulo == misProductos[i].numArticulo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga de operador '+' que agrega un producto a la lista de productos
        /// </summary>
        /// <param name="unProducto"></param>
        /// <param name="misProductos"></param>
        /// <returns>True si pudo agregar, false si no</returns>
        public static bool operator !=(Producto unProducto, List<Producto> misProductos)
        {
            return !(unProducto == misProductos);
        }

        /// <summary>
        /// Sobrecarga de operador '+' que agrega un producto a la lista de productos
        /// </summary>
        /// <param name="misProductos">Lista de productos</param>
        /// <param name="unProducto">Producto a agregar</param>
        /// <returns>True si pudo agregar, false si no</returns>
        public static bool operator +(List<Producto> misProductos, Producto unProducto)
        {
            bool retorno = false;

            if (unProducto != misProductos)
            {
                misProductos.Add(unProducto);
                retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// Sobrecarga de operador '-' que elimina un producto de la lista de productos
        /// </summary>
        /// <param name="misProductos">Lista de productos</param>
        /// <param name="unProducto">Producto a eliminar</param>
        /// <returns>True si pudo eliminar, false si no</returns>
        public static bool operator -(List<Producto> misProductos, Producto unProducto)
        {
            return !(misProductos + unProducto);
        }


        #endregion
    }
}
