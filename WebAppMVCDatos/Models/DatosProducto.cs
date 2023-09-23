using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppMVCDatos.Models
{
    public class DatosProducto
    {
        private SqlConnection conexion;

        private void Conectar()
        {
            string stringConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            conexion = new SqlConnection(stringConexion);

        }
        public List<Producto> GetProductos()
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Productos", conexion);

            conexion.Open();

            List<Producto> productos = new List<Producto>();    

            SqlDataReader reader = sentencia.ExecuteReader();

            while (reader.Read())
            {
                Producto producto = new Producto
                {
                    Id = Convert.ToInt32(reader["codigo"].ToString()),
                    Nombre = reader["descripcion"].ToString(),
                    Precio = float.Parse(reader["precio"].ToString())
                };
                productos.Add(producto);
            }
            conexion.Close();
            return productos;
        }
        public int Alta(Producto producto)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("insert Productos values (@codigo, @descripcion, @precio)", conexion);

            sentencia.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = producto.Id;

            sentencia.Parameters.Add("@descripcion", System.Data.SqlDbType.VarChar);
            sentencia.Parameters["@descripcion"].Value = producto.Nombre;

            sentencia.Parameters.Add("@precio", System.Data.SqlDbType.Float);
            sentencia.Parameters["@precio"].Value = producto.Precio;

            conexion.Open();

            int i = sentencia.ExecuteNonQuery();

            conexion.Close();

            return i;

        }
        public int Borrar(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("delete Productos where codigo = @codigo", conexion);

            sentencia.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;

            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }
        public Producto GetProducto(int pId)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Productos where codigo = @codigo", conexion);
            sentencia.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pId;

            conexion.Open();
            Producto producto = new Producto();
            SqlDataReader reader = sentencia.ExecuteReader();

            if(reader.Read())
            {
                producto.Id = int.Parse(reader["codigo"].ToString());
                producto.Nombre = reader["descripcion"].ToString();
                producto.Precio = float.Parse(reader["precio"].ToString());

            }
            conexion.Close();
            return producto;
            
        }
        public int Modificar(Producto producto)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("update Productos set descripcion = @descripcion, precio = @precio where codigo = @codigo", conexion);

            sentencia.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = producto.Id;

            sentencia.Parameters.Add("@descripcion", System.Data.SqlDbType.VarChar);
            sentencia.Parameters["@descripcion"].Value = producto.Nombre;

            sentencia.Parameters.Add("@precio", System.Data.SqlDbType.Float);
            sentencia.Parameters["@precio"].Value = producto.Precio;

            conexion.Open();

            int i = sentencia.ExecuteNonQuery();

            conexion.Close();

            return i;
        }
    }
}