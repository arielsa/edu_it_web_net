using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
    public class Ado
    { 
        public static string CadenaConexion = Properties.Settings.Default.Conexion_NW;

        public static SqlConnection Conexion = null;

        public static string Conectar()
        {
            Conexion = new SqlConnection(CadenaConexion);
            Conexion.Open();
            return "Conectado a : " + Conexion.Database;
        } 

        public static int ContarProductos()
        {
            Conexion = new SqlConnection(CadenaConexion);
            SqlCommand sentencia = new SqlCommand("SELECT COUNT(*) FROM Products", Conexion);
            Conexion.Open();

            return Convert.ToInt32( sentencia.ExecuteScalar());
        }

        public static List<Empleado> ListarEmpleados()
        {

            Conexion = new SqlConnection(CadenaConexion);
            SqlCommand sentencia = new SqlCommand("select EmployeeID Id, FirstName Nombre, " +
                "LastName Apellido from Employees ", Conexion);
            Conexion.Open();
            SqlDataReader datareader = null;
            List<Empleado> listaEmpleados = new List<Empleado>();

            datareader = sentencia.ExecuteReader();

            while (datareader.Read())
            {
                Empleado emp = new Empleado(Convert.ToInt32(datareader[0]),
                                    Convert.ToString(datareader[1]), Convert.ToString(datareader[2]));
                listaEmpleados.Add(emp);
            }
            Conexion.Close();
            return listaEmpleados;
        }
        public static List<string> TopTenProductosCaros()
        {
            Conexion = new SqlConnection(CadenaConexion);
            SqlCommand sentencia = new SqlCommand("Ten Most Expensive Products", Conexion);
            Conexion.Open();
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader datareader = null;
            List<string> toptenproducts = new List<string>();

            datareader = sentencia.ExecuteReader();

            while (datareader.Read())
            {
                toptenproducts.Add("Producto" + Convert.ToString(datareader[0]) + "Precio: $ " + datareader[1].ToString() );
            }
            Conexion.Close();
            return toptenproducts;
        }
        public static List<string> VentasPorPeriodo(DateTime desde, DateTime hasta)
        {
            Conexion = new SqlConnection(CadenaConexion);
            SqlCommand sentencia = new SqlCommand("Sales by Year", Conexion);
            Conexion.Open();
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter paramDesde = new SqlParameter("@Beginning_Date", desde);
            SqlParameter paramHasta = new SqlParameter("@Ending_Date", hasta);

            sentencia.Parameters.Add(paramDesde);
            sentencia.Parameters.Add(paramHasta);

            SqlDataReader datareader = null;
            List<string> ventas = new List<string>();

            datareader = sentencia.ExecuteReader();

            while (datareader.Read())
            {
                ventas.Add("nº: " + Convert.ToString(datareader[1]) + "Fecha: $ " + datareader[0].ToString() + "Precio: $ " + datareader[2].ToString());
            }
            Conexion.Close();
            return ventas;

        }

        public static int GuardarEmpleado(Empleado empleado)
        {
            Conexion = new SqlConnection(CadenaConexion);

            SqlCommand sentencia = new SqlCommand("InsertarEmpleado", Conexion);
            
            sentencia.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter paramNombre= new SqlParameter("@Nombre", empleado.Nombre);
            SqlParameter paraApellido = new SqlParameter("@Apellido", empleado.Apellido);

            sentencia.Parameters.Add(paramNombre);
            sentencia.Parameters.Add(paraApellido);

            Conexion.Open();

            return sentencia.ExecuteNonQuery();

        }
        public static int ModificarEmpleado(Empleado empleado)
        {

            try
            {

                Conexion = new SqlConnection(CadenaConexion);

                SqlCommand sentencia = new SqlCommand("update emplooyees set lastname = @apellido, firstname = @nombre where employeeid = @codigo", Conexion);

                sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramNombre = new SqlParameter("@Nombre", empleado.Nombre);
                SqlParameter paraApellido = new SqlParameter("@Apellido", empleado.Apellido);
                SqlParameter paramCodigo = new SqlParameter("@Codigo", empleado.Id);


                sentencia.Parameters.Add(paramNombre);
                sentencia.Parameters.Add(paraApellido);
                sentencia.Parameters.Add(paramCodigo);


                Conexion.Open();

                return sentencia.ExecuteNonQuery();
            }
            catch (Exception) 
            { 
                throw new Exception("Error de acceso"); 
            
            }
            finally
            {
                Conexion.Close();
            }

        }
        public static int EliminarEmpleado(Empleado empleado)
        {
            try
            {

                Conexion = new SqlConnection(CadenaConexion);

                SqlCommand sentencia = new SqlCommand("delete emplooyees where employeeid = @codigo", Conexion);

                sentencia.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramCodigo = new SqlParameter("@Codigo", empleado.Id);

                sentencia.Parameters.Add(paramCodigo);

                Conexion.Open();

                return sentencia.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error de acceso");

            }
            finally
            {
                Conexion.Close();
            }

        }

    }
}
