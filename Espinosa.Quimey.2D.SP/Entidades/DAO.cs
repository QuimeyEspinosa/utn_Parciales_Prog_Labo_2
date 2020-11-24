using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Excepciones;

namespace Entidades
{
    public static class DAO
    {
        static SqlConnection conexionDB;

        #region Constructores

        /// <summary>
        /// Constructor estático de DataAccessObject (DAO)
        /// </summary>
        static DAO()
        {
            conexionDB = new SqlConnection(@"Data Source=DESKTOP-V9PJ831\SQLEXPRESS;" +
                " Initial Catalog=Parcial;" +
                " Integrated security =true;");
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Devuelve la lista de hamburguesas de la base
        /// </summary>
        public static List<Hamburguesa> GetHamburguesas()
        {
            List<Hamburguesa> auxCangreBurguers = new List<Hamburguesa>();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM HAMBURGUESAS";

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                SqlDataReader datosDevueltos = comando.ExecuteReader();

                while (datosDevueltos.Read())
                {
                    auxCangreBurguers.Add(new Hamburguesa(
                        int.Parse(datosDevueltos["Id"].ToString()),
                        datosDevueltos["Descripcion"].ToString(),
                        float.Parse(datosDevueltos["Precio"].ToString())
                        ));
                }                
            }
            catch (ConexionALaBaseException miEx)
            {
                MessageBox.Show(miEx.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                miEx.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                ex.Guardar();
            }
            finally
            {
                conexionDB.Close();
            }
            
            return auxCangreBurguers;
        }

        /// <summary>
        /// Devuelve el Id del último Id generado
        /// </summary>
        /// <returns>Id último pedido</returns>
        public static int GetIdUltimoPedido()
        {
            SqlCommand comando = new SqlCommand();
            int idUltimoPedido = -1;

            try
            {
                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from Pedidos where Id in(select MAX(Id) as maximo from Pedidos)";

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                SqlDataReader datosDevueltos = comando.ExecuteReader();

                while (datosDevueltos.Read())
                {
                    idUltimoPedido = int.Parse(datosDevueltos["Id"].ToString());
                }
            }
            catch (ConexionALaBaseException miEx)
            {
                MessageBox.Show(miEx.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                miEx.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                ex.Guardar();
            }
            finally
            {
                conexionDB.Close();
            }

            return idUltimoPedido;
        }

        /// <summary>
        /// Inserta un pedido en la base de datos
        /// </summary>
        /// <param name="miPedido"></param>
        /// <returns>True si pudo insertar, false si no</returns>
        public static bool InsertarPedido(Pedido miPedido)
        {
            SqlCommand comando = new SqlCommand();
            bool pudoInsertar = false;

            string descripcionPedido = "Hamburguesa x" + miPedido.Burguers.Count.ToString();

            try
            {
                comando.Connection = conexionDB;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Pedidos (Cliente, Descripcion, Delivery, Direccion, PrecioTotal) VALUES(@Cliente, @Descripcion, @Delivery, @Direccion, @PrecioTotal)";
                comando.Parameters.Clear();
                comando.Parameters.Add(new SqlParameter("@Cliente", miPedido.NombreCliente));
                comando.Parameters.Add(new SqlParameter("@Descripcion", descripcionPedido));
                comando.Parameters.Add(new SqlParameter("@Delivery", miPedido.TieneDelivery.ToString()));
                comando.Parameters.Add(new SqlParameter("@Direccion", miPedido.DireccionEntrega));
                comando.Parameters.Add(new SqlParameter("@PrecioTotal", miPedido.PrecioTotal));

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                comando.ExecuteNonQuery();
                pudoInsertar = true;
            }
            catch (ArchivoException miEx)
            {
                MessageBox.Show(miEx.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                miEx.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                ex.Guardar();
            }
            finally
            {
                conexionDB.Close();
            }

            return pudoInsertar;
        }

        #endregion
    }
}
