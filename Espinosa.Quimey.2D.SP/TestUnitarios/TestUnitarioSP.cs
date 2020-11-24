using System;
using Archivos;
using Entidades;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarioSP
    {
        /// <summary>
        /// Valida que lance la excepción de NuevaVentaException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NuevoPedidoException))]
        public void Test_NuevoPedidoException()
        {
            Pedido miPedido = null;
            Comercio.ConfirmarPedido(miPedido);
        }

        /// <summary>
        /// Valida que lance la excepcion ArchivoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]
        public void Test_ArchivoException()
        {
            Texto txt = new Texto();

            txt.Guardar(string.Empty, string.Empty);
        }

        /// <summary>
        /// Valida que las Queues de pedidos estén instanciadas en el comercio.
        /// </summary>
        [TestMethod]
        public void Test_Coleccion()
        {
            Assert.IsNotNull(Comercio.PedidosEnPreparacion);
            Assert.IsNotNull(Comercio.PedidosListosParaRetirar);
            Assert.IsNotNull(Comercio.PedidosEntregados);
        }
    }
}
