using System;

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

            string ext = System.IO.Path.GetExtension(FileUpload1.FileName);

            if (ext == ".txt")
            {
                string path = Server.MapPath("~\\Files\\");
                FileUpload1.SaveAs(path + FileUpload1.FileName);
            }
            else
            {
                Response.Write("Only .txt files are Allowed");
            }
           
        }
    }
  
}