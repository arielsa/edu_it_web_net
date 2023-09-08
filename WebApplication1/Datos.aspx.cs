using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using misClases;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Datos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblConectar.Text = Ado.Conectar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblEscalar.Text = Ado.ContarProductos().ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (Empleado emp in Ado.ListarEmpleados())
            {
                lblReader.Text += emp.Id + " " + emp.Nombre + " " + emp.Apellido + "<br/>";
            }
        }

        protected void TopProducts_Click(object sender, EventArgs e)
        {
            foreach (string product in Ado.TopTenProductosCaros())
            {
                lblTopProducts.Text += product.ToString() + "<br/>";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DateTime desde = Convert.ToDateTime(TextBoxDesde.Text);
            DateTime hasta = Convert.ToDateTime(TextBoxHasta.Text);

            foreach (var x in Ado.VentasPorPeriodo(desde, hasta))
            {
                lblVentas.Text += x + "<br/>";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(TextBoxNombre.Text, TextBoxApellido.Text);
            lblResult.Text = Ado.GuardarEmpleado(emp).ToString();
        }
        void cargarEmpleados()
        { 
            LblDatos.Text = string.Empty;

            foreach (Empleado emp in Ado.ListarEmpleados())
            {               
                LblDatos.Text += emp.Id + " " + emp.Nombre + " " + emp.Apellido + "<br/>";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(Convert.ToInt32(TextBoxCodigo.Text), TextBoxNombreModificar.Text, TextBoxApellidoModificar.Text);
            LblModificar.Text = "se modifico " + Ado.ModificarEmpleado(emp).ToString() + " registro(s)";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(Convert.ToInt32(TextBoxCodigo.Text));
            lblEliminar.Text = "se eliminaron " + Ado.EliminarEmpleado(emp).ToString() + " registro(s)";
        }
    }
}