using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class ProductoRefrigerado : Producto
    {
        #region Constructores

        /// <summary>
        /// Constructor público de la clase ProductoRefrigerado
        /// </summary>
        /// <param name="numArticulo">Numero de articulo del producto refrigerado</param>
        /// <param name="descripcion">Descripción del producto refrigerado</param>
        /// <param name="precio">Precio del producto refrigerado</param>
        /// <param name="stock">Stock del producto refrigerado</param>
        /// <param name="tipoProd">Tipo de producto</param>
        public ProductoRefrigerado(int numArticulo, string descripcion, double precio, int stock, ETipo tipoProd) : base(numArticulo, descripcion, precio, stock, tipoProd)
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
            StringBuilder prodRefrigerado = new StringBuilder();

            prodRefrigerado.AppendLine("Producto refrigerado\n");
            prodRefrigerado.AppendLine(base.MostrarProducto());
            prodRefrigerado.AppendLine("Debe guardarse en heladera y/o a baja temperatura");

            return prodRefrigerado.ToString();
        }

        #endregion
    }
}
