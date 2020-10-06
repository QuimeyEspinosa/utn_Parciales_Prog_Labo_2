using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class ProductoAlmacen : Producto
    {
        #region Constructores

        /// <summary>
        /// Constructor publico de la clase productoAlmacen
        /// </summary>
        /// <param name="numArticulo">Numero de articulo del producto de Almacen</param>
        /// <param name="descripcion">Descripción del producto de Almacen</param>
        /// <param name="precio">Precio del producto de Almacen</param>
        /// <param name="stock">Stock del producto de Almacen</param>
        /// <param name="tipoProd">Tipo de producto</param>
        public ProductoAlmacen(int numArticulo, string descripcion, double precio, int stock, ETipo tipoProd) : base(numArticulo, descripcion, precio, stock, tipoProd)
        {
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Override de Mostrar Producto
        /// </summary>
        /// <returns>String con los datos del producto</returns>
        public override string MostrarProducto()
        {
            StringBuilder prodAlmacen = new StringBuilder();

            prodAlmacen.AppendLine("Producto de Almacen\n");
            prodAlmacen.AppendLine(base.MostrarProducto());
            prodAlmacen.AppendLine("No mezclar con las revistas");

            return prodAlmacen.ToString();
        }

        #endregion
    }
}
