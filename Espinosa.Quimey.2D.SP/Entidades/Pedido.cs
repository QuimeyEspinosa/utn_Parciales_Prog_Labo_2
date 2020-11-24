using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        string nombreCliente;
        List<Hamburguesa> burguers;
        int numPedido;
        bool tieneDelivery;
        string direccionEntrega;
        float montoTotal;

        #region Constructores

        /// <summary>
        /// Constructor público de clase
        /// </summary>
        public Pedido()
        {
            this.nombreCliente = "";
            this.burguers = new List<Hamburguesa>();
            this.numPedido = -1;
            this.tieneDelivery = false;
            this.direccionEntrega = " N/A";
            this.montoTotal = 0;
        }

        /// <summary>
        /// Constructor público parametrizado de clase
        /// </summary>
        /// <param name="nombreCliente"></param>
        /// <param name="burguers"></param>
        /// <param name="numPedido"></param>
        /// <param name="tieneDelivery"></param>
        /// <param name="montoTotal"></param>
        public Pedido(string nombreCliente, List<Hamburguesa> burguers, int numPedido, bool tieneDelivery, float montoTotal) : this()
        {
            this.nombreCliente = nombreCliente;
            this.burguers = burguers;
            this.numPedido = numPedido;
            this.tieneDelivery = tieneDelivery;
            this.montoTotal = montoTotal;
        }

        /// <summary>
        /// Constructor público parametrizado de clase
        /// </summary>
        /// <param name="nombreCliente"></param>
        /// <param name="burguers"></param>
        /// <param name="numPedido"></param>
        /// <param name="tieneDelivery"></param>
        /// <param name="direccion"></param>
        /// <param name="montoTotal"></param>
        public Pedido(string nombreCliente, List<Hamburguesa> burguers, int numPedido, bool tieneDelivery, string direccion, float montoTotal) : this()
        {
            this.nombreCliente = nombreCliente;
            this.burguers = burguers;
            this.numPedido = numPedido;
            this.tieneDelivery = tieneDelivery;
            this.direccionEntrega = direccion;
            this.montoTotal = montoTotal;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Get y set del nombre del cliente
        /// </summary>
        public string NombreCliente
        {
            get { return this.nombreCliente; }
            set { this.nombreCliente = value; }
        }

        /// <summary>
        /// Get y set de los productos del pedido
        /// </summary>
        public List<Hamburguesa> Burguers
        {
            get { return this.burguers; }
            set { this.burguers = value; }
        }

        /// <summary>
        /// Get y set del numero de pedido
        /// </summary>
        public int NumPedido
        {
            get { return this.numPedido; }
            set { this.numPedido = value; }
        }

        /// <summary>
        /// Get y set de Tiene delivery
        /// </summary>
        public bool TieneDelivery
        {
            get { return this.tieneDelivery; }
            set { this.tieneDelivery = value; }
        }

        /// <summary>
        /// Get y set de la dirección de entrega del pedido
        /// </summary>
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        /// <summary>
        /// Get y set del monto total del pedido
        /// </summary>
        public float PrecioTotal
        {
            get { return this.montoTotal; }
            set { this.montoTotal = value; }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Devuelve un string con los datos del pedido
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder datosPedido = new StringBuilder();

            datosPedido.AppendLine($"Cliente: {this.nombreCliente}");
            datosPedido.Append(this.GetDescripcionPedido());
            if (this.tieneDelivery)
            {
                datosPedido.AppendLine("Delivery: Si");
            }
            else
            {
                datosPedido.AppendLine("Delivery: No");
            }
            datosPedido.AppendLine($"Direccion: {this.direccionEntrega}");
            datosPedido.AppendLine($"Total: ${this.montoTotal}");
            datosPedido.AppendLine($"N° Pedido: {this.numPedido}");
            datosPedido.AppendLine("-----------------------------------------");

            return datosPedido.ToString();
        }

        /// <summary>
        /// Devuelve un string con los productos del pedido
        /// </summary>
        /// <returns></returns>
        public string GetDescripcionPedido()
        {
            StringBuilder descPedido = new StringBuilder();

            foreach (Hamburguesa burguer in this.burguers)
            {
                descPedido.AppendLine($"       {burguer}");
            }           

            return descPedido.ToString();
        }

        #endregion
    }
}
