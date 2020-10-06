using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class ProductoRevista : Producto
    {
        #region Constructores

        /// <summary>
        /// Constructor Público de la clase ProductoRevista
        /// </summary>
        /// <param name="numArticulo">Numero de articulo del producto de revista</param>
        /// <param name="descripcion">Descripción del producto de revista</param>
        /// <param name="precio">Precio del producto de revista</param>
        /// <param name="stock">Stock del producto de revista</param>
        /// <param name="tipoProd">Tipo de producto</param>
        public ProductoRevista(int numArticulo, string descripcion, double precio, int stock, ETipo tipoProd) : base(numArticulo, descripcion, precio, stock, tipoProd)
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
            StringBuilder prodRevista = new StringBuilder();

            prodRevista.AppendLine("Producto de tipo Revista\n");
            prodRevista.AppendLine(base.MostrarProducto());
            prodRevista.AppendLine("No almacenar junto a los alimentos");

            return prodRevista.ToString();
        }

        #endregion
    }
}
