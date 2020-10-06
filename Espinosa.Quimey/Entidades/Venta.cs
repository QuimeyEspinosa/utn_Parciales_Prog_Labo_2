using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        static int idIncremental = 1; 
        int idVenta;
        Empleado empleadoVendedor;
        Cliente clienteComprador;
        List<Producto> productosVendidos;
        double precioTotal;

        #region Constructores

        /// <summary>
        /// Constructor privado de venta
        /// </summary>
        private Venta()
        {
            this.productosVendidos = new List<Producto>();
        }

        /// <summary>
        /// Constructor público de venta
        /// </summary>
        /// <param name="empleadoVendedor">Objeto de tipo Empleado</param>
        /// <param name="clienteComprador">Objeto de tipo Cliente</param>
        /// <param name="productosVendidos">Lista de tipo Producto</param>
        /// <param name="precioTotal">Precio Total de la compra</param>
        public Venta(Empleado empleadoVendedor, Cliente clienteComprador, List<Producto> productosVendidos, double precioTotal) : this()
        {
            this.idVenta = idIncremental++;
            this.empleadoVendedor = empleadoVendedor;
            this.clienteComprador = clienteComprador;
            this.productosVendidos = productosVendidos;
            this.precioTotal = precioTotal;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// get de la lista de productos vendidos
        /// </summary>
        public List<Producto> ProductosVendidos
        {
            get { return this.productosVendidos; }
        }

        /// <summary>
        /// get id de la venta
        /// </summary>
        public int IdVenta
        {
            get { return this.idVenta; }
        }

        /// <summary>
        /// get id del empleado vendedor
        /// </summary>
        public int IdEmpleado
        {
            get { return this.empleadoVendedor.Id; }
        }

        /// <summary>
        /// get nombre y apellido del empleado vendedor
        /// </summary>
        public string Vendedor
        {
            get { return this.empleadoVendedor.NombreYApellido; }
        }

        /// <summary>
        /// get precio total de la venta
        /// </summary>
        public double PrecioTotal
        {
            get { return this.precioTotal; }
        }

        /// <summary>
        /// get nombre y apellido del cliente comprador
        /// </summary>
        public string Comprador
        {
            get { return this.clienteComprador.NombreYApellido; }
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga operador '==' verifica si una venta ya existe en base al Id
        /// </summary>
        /// <param name="unVenta">Venta a buscar</param>
        /// <param name="misVentas">Lista de ventas</param>
        /// <returns></returns>
        public static bool operator ==(Venta unVenta, List<Venta> misVentas)
        {
            bool retorno = false;

            for (int i = 0; i < misVentas.Count; i++)
            {
                if (unVenta.IdVenta == misVentas[i].IdVenta)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga operador '!=' verifica si una venta es distinta de otra en base al Id
        /// </summary>
        /// <param name="unVenta"></param>
        /// <param name="misVentas"></param>
        /// <returns>True si es distinta, false si no</returns>
        public static bool operator !=(Venta unVenta, List<Venta> misVentas)
        {
            return !(unVenta == misVentas);
        }

        /// <summary>
        /// Sobrecarga operador '+' agrega una venta a la lista de ventas
        /// </summary>
        /// <param name="misVentas">lista de ventas</param>
        /// <param name="unVenta">venta a agregar</param>
        /// <returns>True si pudo agregar, false si no</returns>
        public static bool operator +(List<Venta> misVentas, Venta unVenta)
        {
            bool retorno = false;

            if (unVenta != misVentas)
            {
                misVentas.Add(unVenta);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga operador '-' elimina una venta de la lista de ventas
        /// </summary>
        /// <param name="misVentas">lista de ventas</param>
        /// <param name="unVenta">venta a eliminar</param>
        /// <returns>True si pudo eliminar, false si no</returns>
        public static bool operator -(List<Venta> misVentas, Venta unVenta)
        {
            return !(misVentas + unVenta);
        }

        #endregion

    }
}
