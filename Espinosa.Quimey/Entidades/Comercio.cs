using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio
    {
        static List<Empleado> misEmpleados;
        static List<Cliente> misClientes;
        static List<Producto> misProductos;
        static List<Venta> misVentas;
        static string nombreUsuarioLog;

        #region Constructores

        /// <summary>
        /// Constructor de clase estática
        /// </summary>
        static Comercio()
        {
            misEmpleados = new List<Empleado>();
            misClientes = new List<Cliente>();
            misProductos = new List<Producto>();
            misVentas = new List<Venta>();
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Get de los empleados del comercio
        /// </summary>
        public static List<Empleado> MisEmpleados
        {
            get { return misEmpleados; }
        }

        /// <summary>
        /// Get de los clientes del comercio
        /// </summary>
        public static List<Cliente> MisClientes
        {
            get { return misClientes; }
        }
        /// <summary>
        /// Get de los productos del comercio
        /// </summary>
        public static List<Producto> MisProductos
        {
            get { return misProductos; }
        }
        /// <summary>
        /// Get de las ventas del comercio
        /// </summary>
        public static List<Venta> MisVentas
        {
            get { return misVentas; }
        }

        /// <summary>
        /// Get del usuario logueado
        /// </summary>
        public static string NombreUsuarioLog
        {
            get { return nombreUsuarioLog; }
        }

        #endregion

        #region Productos

        /// <summary>
        /// Agrega un producto a la lista de productos
        /// </summary>
        /// <param name="miProducto">Producto a agregar</param>
        /// <returns></returns>
        public static bool AgregarProducto(Producto miProducto)
        {
            bool retorno = false;

            if (miProducto != misProductos)
            {
                misProductos.Add(miProducto);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve una lista con los productos en Stock
        /// </summary>
        /// <returns>lista de productos en Stock</returns>
        public static List<Producto> ProductosEnStock()
        {
            List<Producto> productosEnStock = new List<Producto>();

            foreach (Producto productoStock in misProductos)
            {
                if (productoStock.Unidades != 0)
                {
                    productosEnStock.Add(productoStock);
                }
            }

            return productosEnStock;
        }

        /// <summary>
        /// Devuelve una lista con los productos en bajo Stock
        /// </summary>
        /// <returns>lista de productos bajo Stock</returns>
        public static List<Producto> ProductosBajoStock()
        {
            List<Producto> productosBajoStock = new List<Producto>();

            foreach (Producto productoStock in misProductos)
            {
                if (productoStock.Unidades < 10)
                {
                    productosBajoStock.Add(productoStock);
                }
            }

            return productosBajoStock;
        }

        /// <summary>
        /// Descuenta el stock del producto en el indice especificado
        /// </summary>
        /// <param name="indiceProducto">indice del producto a descontar</param>
        /// <param name="cantUnidades">cantidad a descontar</param>
        /// <returns>true si pudo descontar, false si no</returns>
        public static bool DescontarStock(int indiceProducto, int cantUnidades)
        {
            bool pudoDescontar = false;

            if (cantUnidades <= misProductos[indiceProducto].Unidades)
            {
                misProductos[indiceProducto].Unidades = misProductos[indiceProducto].Unidades - cantUnidades;
                pudoDescontar = true;
            }

            return pudoDescontar;
        }

        /// <summary>
        /// Obtiene el indice del producto en base a su numero de articulo
        /// </summary>
        /// <param name="numArticulo">numero de articulo a buscar en la lista</param>
        /// <returns>true si pudo obtener el indice, false si no</returns>
        public static int GetIndiceProductoByIdProducto(int numArticulo)
        {
            int retorno = -1;

            for (int i = 0; i < misProductos.Count; i++)
            {
                if (numArticulo == misProductos[i].NumArticulo)
                {
                    retorno = i;
                    break;
                }
            }

            return retorno;
        }

        #endregion

        #region Ventas

        /// <summary>
        /// Agrega una venta a la lista de ventas
        /// </summary>
        /// <param name="nuevaVenta">venta a agregar a la lista</param>
        /// <returns>true si pudo agregar, false si no</returns>
        public static bool AgregarVenta(Venta nuevaVenta)
        {
            return misVentas + nuevaVenta;
        }

        /// <summary>
        /// Genera un ticket de la compra realizada
        /// </summary>
        /// <param name="miVenta">Venta a generar ticket</param>
        public static void GenerarTicketCompra(Venta miVenta)
        {
            StringBuilder informacionCompra = new StringBuilder();

            informacionCompra.AppendLine("Kwik E Mart");
            informacionCompra.AppendLine();
            informacionCompra.AppendLine("|| N°Art. ||   Tipo   ||  Descripción  || Unidades || Precio Unitario ||");
            informacionCompra.AppendLine("-------------------------------------------------------------------");
            for (int i = 0; i < miVenta.ProductosVendidos.Count; i++)
            {
                informacionCompra.AppendLine($"   {miVenta.ProductosVendidos[i].NumArticulo}    " +
                    $"{miVenta.ProductosVendidos[i].Tipo}    " +
                    $"{miVenta.ProductosVendidos[i].Descripcion}    " +
                    $"{miVenta.ProductosVendidos[i].Unidades}             " +
                    $"${miVenta.ProductosVendidos[i].PrecioUnitario}");
            }
            informacionCompra.AppendLine("-------------------------------------------------------------------");
            informacionCompra.AppendLine($"Cliente: {miVenta.Comprador}");
            informacionCompra.AppendLine($"Total Us$: {miVenta.PrecioTotal}");

            StringBuilder nombreTicket = new StringBuilder();
            nombreTicket.Append("Ticket emitido el " +
                                DateTime.Now.Day + "-" +
                                DateTime.Now.Month + "-" +
                                DateTime.Now.Year + " a las " +
                                DateTime.Now.Hour + "hs" +
                                DateTime.Now.Minute + "m" +
                                DateTime.Now.Second + "s");
            string fechaCompra = nombreTicket.ToString();

            //Obtengo la dirección del escritorio de la pc en la que se ejecuta el programa
            string direccionEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            //Si no existe la carpeta Tickets de compra, la creo
            Directory.CreateDirectory(direccionEscritorio + "\\Tickets de Compra KwikEMart");

            //Creo un nuevo txt con los datos de la compra y lo guardo en la carpeta "Tickets de Compra" en el escritorio
            using (Stream fs = new FileStream($"{direccionEscritorio}\\Tickets de Compra KwikEMart\\{fechaCompra}.txt", FileMode.CreateNew, FileAccess.Write))
            {
                using (StreamWriter ticketCompra = new StreamWriter(fs))
                {
                    ticketCompra.Write(informacionCompra.ToString());
                }
            }
        }
        #endregion

        #region Clientes

        /// <summary>
        /// Agrega un cliente a la lista de clientes
        /// </summary>
        /// <param name="miCliente">Cliente a agregar</param>
        /// <returns>true si pudo agregar, false si no</returns>
        public static bool AgregarCliente(Cliente miCliente)
        {
            return misClientes + miCliente;
        }

        #endregion

        #region Login

        /// <summary>
        /// Valida que los datos de usuario ingresados coincidan con los usuarios registrados
        /// </summary>
        /// <param name="usuario">usuario a comparar</param>
        /// <param name="contraseña">contraseña a comparar</param>
        /// <returns>true si el empleado existe, false si no</returns>
        public static bool LoginEmpleadoValido(string usuario, string contraseña)
        {
            bool esEmpleado = false;

            for (int i = 0; i < misEmpleados.Count; i++)
            {
                if (misEmpleados[i].Usuario == usuario && misEmpleados[i].Contraseña == contraseña)
                {
                    return true;
                }
            }

            return esEmpleado;
        }

        /// <summary>
        /// Asigna el usuario logueado
        /// </summary>
        /// <param name="usuario">usuario a asignar</param>
        public static void AsignarUsuarioLogueado(string usuario)
        {
            nombreUsuarioLog = usuario;
        }
        #endregion

        #region Hardcode

        /// <summary>
        /// Hardcodeo de productos
        /// </summary>
        public static void HardcodeKeM()
        {
            #region HardcodeEmpleados

            misEmpleados.Add(new Empleado("Apu", "Nahasapeemapetilon", 3000, "Apusin", "apusote123"));          //0
            misEmpleados.Add(new Empleado("Sanjay", "Nahasapeemapetilon", 2100, "Sanjasin", "sanjasote123"));   //1
            misEmpleados.Add(new Empleado("Lucas", "Rodriguez", 2500, "Lucas1234", "lucas1234"));               //2
            misEmpleados.Add(new Empleado("Ezequiel", "Oggioni", 2500, "Eze1234", "ezequiel1234"));             //3

            #endregion

            #region HardcodeClientes

            misClientes.Add(new Cliente(666459, "Homero", "Simpson"));    //0
            misClientes.Add(new Cliente(777568, "Moe", "Szyslak"));       //1
            misClientes.Add(new Cliente(100671, "Montgomery", "Burns"));  //2
            misClientes.Add(new Cliente(999235, "Nelson", "Muntz"));      //3
            misClientes.Add(new Cliente(667563, "Bart", "Simpson"));      //4
            misClientes.Add(new Cliente(123442, "Seymour", "Skinner"));   //5
            misClientes.Add(new Cliente(436852, "Rafa", "Gorgory"));      //6
            misClientes.Add(new Cliente(232123, "Lenny", "Leonard"));     //7
            misClientes.Add(new Cliente(212798, "Carl", "Carlson"));      //8
            misClientes.Add(new Cliente(373844, "Ned", "Flanders"));      //9

            #endregion

            #region HardcodeProductos

            misProductos.Add(new ProductoAlmacen(4562, "Cerveza Duff", 2, 17, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoAlmacen(2782, "Cereales Krusty-O's", 3, 34, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoRevista(7345, "Comics Radioactive Man", 1.50, 20, Producto.ETipo.Revista));
            misProductos.Add(new ProductoRefrigerado(1212, "Helado", 0.50, 45, Producto.ETipo.Refrigerado));
            misProductos.Add(new ProductoAlmacen(1101, "Manzana", 0.50, 3, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoAlmacen(9183, "Buzz Cola", 1, 85, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoRevista(5678, "Krusty Comics", 2.50, 0, Producto.ETipo.Revista));
            misProductos.Add(new ProductoRevista(8219, "Glass Eater", 0.75, 31, Producto.ETipo.Revista));
            misProductos.Add(new ProductoRefrigerado(1982, "Carne", 3, 25, Producto.ETipo.Refrigerado));
            misProductos.Add(new ProductoAlmacen(4342, "Yerba Canarias", 5, 0, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoRefrigerado(2654, "Viejo congelado", 1000, 0, Producto.ETipo.Refrigerado));
            misProductos.Add(new ProductoRevista(5577, "Boleto de Lotería", 0.25, 120, Producto.ETipo.Revista));
            misProductos.Add(new ProductoRefrigerado(3434, "Leche's", 1, 0, ProductoRefrigerado.ETipo.Refrigerado));
            misProductos.Add(new ProductoAlmacen(2323, "Café La Virginia", 2, 5, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoRevista(2000, "PlayDude", 5, 85, Producto.ETipo.Revista));
            misProductos.Add(new ProductoRefrigerado(7373, "Paty", 0.50, 45, Producto.ETipo.Refrigerado));
            misProductos.Add(new ProductoAlmacen(2222, "Galletitas Frutigran", 2, 2, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoAlmacen(3342, "Chupetin Pop", 0.25, 4, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoRefrigerado(5656, "Batido Squishees", 1, 32, Producto.ETipo.Refrigerado));
            misProductos.Add(new ProductoAlmacen(8384, "Papas Pringles", 0.15, 10, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoAlmacen(2888, "Banana", 0.50, 21, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoAlmacen(9999, "Salsa de tomate", 2, 34, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoAlmacen(9929, "Fideos", 0.50, 77, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoRefrigerado(1231, "Jamón", 0.15, 10, ProductoRefrigerado.ETipo.Refrigerado));
            misProductos.Add(new ProductoAlmacen(3333, "Mayonesa Natura", 0.50, 23, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoAlmacen(1111, "Yerba Cruz Malta", 3.50, 42, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoRefrigerado(4433, "Yogurt", 0.50, 3, Producto.ETipo.Refrigerado));
            misProductos.Add(new ProductoRevista(5567, "Simpson Comics", 1, 58, Producto.ETipo.Revista));
            misProductos.Add(new ProductoAlmacen(8821, "Atún La Campagnola", 2, 49, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoAlmacen(7235, "Naranja", 0.50, 45, Producto.ETipo.Almacen));
            misProductos.Add(new ProductoRefrigerado(7474, "Queso", 0.10, 57, Producto.ETipo.Refrigerado));

            #endregion

            #region HardcodeCompras

            List<Producto> auxProductosCompra1 = new List<Producto>();
            auxProductosCompra1.Add(new ProductoAlmacen(1111, "Yerba Cruz Malta", 3.50, 2, Producto.ETipo.Almacen));
            auxProductosCompra1.Add(new ProductoRefrigerado(4433, "Yogurt", 0.50, 2, Producto.ETipo.Refrigerado));
            auxProductosCompra1.Add(new ProductoRevista(5567, "Simpson Comics", 1, 1, Producto.ETipo.Revista));
            misVentas.Add(new Venta(Comercio.misEmpleados[3], Comercio.misClientes[9], auxProductosCompra1, 9));

            List<Producto> auxProductosCompra2 = new List<Producto>();
            auxProductosCompra2.Add(new ProductoRevista(2000, "PlayDude", 5, 1, Producto.ETipo.Revista));
            misVentas.Add(new Venta(Comercio.misEmpleados[2], Comercio.misClientes[4], auxProductosCompra2, 5));

            List<Producto> auxProductosCompra3 = new List<Producto>();
            auxProductosCompra3.Add(new ProductoRefrigerado(1982, "Carne", 3, 2, Producto.ETipo.Refrigerado));
            auxProductosCompra3.Add(new ProductoAlmacen(4342, "Yerba Canarias", 5, 4, Producto.ETipo.Almacen));
            auxProductosCompra3.Add(new ProductoRevista(5577, "Boleto de Lotería", 0.25, 10, Producto.ETipo.Revista));
            auxProductosCompra3.Add(new ProductoRefrigerado(3434, "Leche's", 1, 3, ProductoRefrigerado.ETipo.Refrigerado));
            auxProductosCompra3.Add(new ProductoAlmacen(2323, "Café La Virginia", 2, 5, Producto.ETipo.Almacen));
            auxProductosCompra3.Add(new ProductoRevista(2000, "PlayDude", 5, 3, Producto.ETipo.Revista));
            auxProductosCompra3.Add(new ProductoRefrigerado(7373, "Paty", 0.50, 12, Producto.ETipo.Refrigerado));
            auxProductosCompra3.Add(new ProductoAlmacen(2222, "Galletitas Frutigran", 2, 5, Producto.ETipo.Almacen));
            auxProductosCompra3.Add(new ProductoAlmacen(3342, "Chupetin Pop", 0.25, 4, Producto.ETipo.Almacen));
            misVentas.Add(new Venta(Comercio.misEmpleados[0], Comercio.misClientes[2], auxProductosCompra3, 72.25));

            List<Producto> auxProductosCompra4 = new List<Producto>();
            auxProductosCompra4.Add(new ProductoAlmacen(4562, "Cerveza Duff", 2, 24, Producto.ETipo.Almacen));
            misVentas.Add(new Venta(Comercio.misEmpleados[3], Comercio.misClientes[0], auxProductosCompra4, 48));

            List<Producto> auxProductosCompra5 = new List<Producto>();
            auxProductosCompra5.Add(new ProductoRefrigerado(2654, "Viejo congelado", 1000, 1, Producto.ETipo.Refrigerado));
            misVentas.Add(new Venta(Comercio.misEmpleados[0], Comercio.misClientes[3], auxProductosCompra5, 1000));

            List<Producto> auxProductosCompra6 = new List<Producto>();
            auxProductosCompra6.Add(new ProductoAlmacen(4342, "Yerba Canarias", 5, 2, Producto.ETipo.Almacen));
            auxProductosCompra6.Add(new ProductoAlmacen(7474, "Chicle Bubbaloo", 0.10, 3, Producto.ETipo.Almacen));
            auxProductosCompra6.Add(new ProductoAlmacen(8821, "Atún La Campagnola", 2, 1, Producto.ETipo.Almacen));
            auxProductosCompra6.Add(new ProductoAlmacen(9929, "Fideos", 0.50, 3, Producto.ETipo.Almacen));
            misVentas.Add(new Venta(Comercio.misEmpleados[0], Comercio.misClientes[6], auxProductosCompra6, 13.80));

            List<Producto> auxProductosCompra7 = new List<Producto>();
            auxProductosCompra7.Add(new ProductoAlmacen(9183, "Buzz Cola", 1, 2, Producto.ETipo.Almacen));
            misVentas.Add(new Venta(Comercio.misEmpleados[1], Comercio.misClientes[5], auxProductosCompra7, 2));

            List<Producto> auxProductosCompra8 = new List<Producto>();
            auxProductosCompra8.Add(new ProductoAlmacen(4342, "Yerba Canarias", 5, 3, Producto.ETipo.Almacen));
            misVentas.Add(new Venta(Comercio.misEmpleados[3], Comercio.misClientes[7], auxProductosCompra8, 15));

            List<Producto> auxProductosCompra9 = new List<Producto>();
            auxProductosCompra9.Add(new ProductoAlmacen(3342, "Chupetin Pop", 0.25, 4, Producto.ETipo.Almacen));
            auxProductosCompra9.Add(new ProductoAlmacen(2222, "Galletitas Frutigran", 2, 2, Producto.ETipo.Almacen));
            misVentas.Add(new Venta(Comercio.misEmpleados[2], Comercio.misClientes[2], auxProductosCompra9, 5));

            List<Producto> auxProductosCompra10 = new List<Producto>();
            auxProductosCompra10.Add(new ProductoAlmacen(2323, "Café La Virginia", 2, 2, Producto.ETipo.Almacen));
            misVentas.Add(new Venta(Comercio.misEmpleados[2], Comercio.misClientes[9], auxProductosCompra10, 4.50));


            #endregion
        }

        #endregion
    }
}
