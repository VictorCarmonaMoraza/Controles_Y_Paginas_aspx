using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Controles_De_Servidores
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Siempre en la primera carga
            if (!IsPostBack)
            {
                //Carga texto por defecto al empezar
                TextBox1.Text = "Carmona";
            }
        }

        protected void btnMyPage_Click(object sender, EventArgs e)
        {
            //Cuando hacemos click sobre le boton nos ridirigue al web form MyPage.aspx
            Response.Redirect("MyPage.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello " + TextBox1.Text;
        }
    }
}