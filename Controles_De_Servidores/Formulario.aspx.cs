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
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //Obtenemos la fecha para la caja de texto
            //TextBox1.Text = Calendar1.SelectedDate.ToString();

            //Fecha corta
            //TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();

            //Formato de fecha
            TextBox1.Text = Calendar1.SelectedDate.ToString("dd-MM-yyyy");

            //Formato de fecha 2
            TextBox1.Text = Calendar1.SelectedDate.ToString("dd MMMM, yyyy");

            Calendar1.Visible = false;
        }
    }
}