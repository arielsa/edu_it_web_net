using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using misClases;

namespace WebApplication1
{
    public partial class AltaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = TextBox1.Text;
            p.Apellido = TextBox2.Text;
            p.setDocumento(TextBox3.Text);

            Label1.Text = "nombre: " + p.getNombre();
        }
    }
}