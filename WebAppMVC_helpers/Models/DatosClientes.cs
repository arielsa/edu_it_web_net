using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppMVC_helpers.Models
{
    public class DatosClientes
    {
        private SqlConnection conexion;

        private void Conectar()
        {
            string stringConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            conexion = new SqlConnection(stringConexion);

        }
        public List<Cliente> GetClientes()
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("SELECT * FROM clientes", conexion);

            conexion.Open();

            List<Cliente> clientes = new List<Cliente>();

            SqlDataReader reader = sentencia.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente
                {
                    Codigo = Convert.ToInt32(reader["codigo"].ToString()),
                    Nombre = reader["nombre"].ToString(),
                    Apellido = reader["apellido"].ToString(),
                    Email = reader["email"].ToString()
                };
                clientes.Add(cliente);
            }
            conexion.Close();
            return clientes;
        }
        public int Alta(Cliente pCliente)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("insert Clientes values (@codigo, @nombre, @apellido, @email)", conexion);

            sentencia.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCliente.Codigo;

            sentencia.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
            sentencia.Parameters["@nombre"].Value = pCliente.Nombre;

            sentencia.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar);
            sentencia.Parameters["@apellido"].Value = pCliente.Apellido;

            sentencia.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            sentencia.Parameters["@email"].Value = pCliente.Email;

            conexion.Open();

            int i = sentencia.ExecuteNonQuery();

            conexion.Close();

            return i;

        }
        public int Borrar(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("delete Clientes where codigo = @codigo", conexion);

            sentencia.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;

            conexion.Open();
            int i = sentencia.ExecuteNonQuery();
            conexion.Close();
            return i;
        }
        public Cliente GetCliente(int pCodigo)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Clientes where codigo = @codigo", conexion);
            sentencia.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCodigo;

            conexion.Open();
            Cliente cliente = new Cliente();
            SqlDataReader reader = sentencia.ExecuteReader();

            if (reader.Read())
            {
                cliente.Codigo = int.Parse(reader["codigo"].ToString());
                cliente.Nombre = reader["nombre"].ToString();
                cliente.Apellido = reader["apellido"].ToString();
                cliente.Email = reader["email"].ToString();

            }
            conexion.Close();
            return cliente;

        }
        public int Modificar(Cliente pCliente)
        {
            Conectar();
            SqlCommand sentencia = new SqlCommand("update Clientes set nombre = @nombre, apelido = @apellido, email = @email where codigo = @codigo", conexion);

            sentencia.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            sentencia.Parameters["@codigo"].Value = pCliente.Codigo;

            sentencia.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
            sentencia.Parameters["@nombre"].Value = pCliente.Nombre;

            sentencia.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar);
            sentencia.Parameters["@apellido"].Value = pCliente.Apellido;

            sentencia.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            sentencia.Parameters["@email"].Value = pCliente.Email;

            conexion.Open();

            int i = sentencia.ExecuteNonQuery();

            conexion.Close();

            return i;
        }

    }
}