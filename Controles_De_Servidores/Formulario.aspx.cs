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
            int a, b, c;
            a =int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);
            c = a + b;
            lblResult.Text ="Mi resultado es "+ c.ToString();

        }

        protected void lkbtnAdd_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);
            c = a + b;
            lblResult.Text = "Mi resultado es " + c.ToString();
        }

        protected void ImgbtnAdd_Click(object sender, ImageClickEventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);
            c = a + b;
            lblResult.Text = "Mi resultado es " + c.ToString();
        }

        /// <summary>
        /// Obtenemos el index del dropdownList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            //Obtiene el indice del combo
            string s ="Index s: "+ ddlQualification.SelectedIndex.ToString();
            //Obtiene la opcion seleccionada
             s += "<br/> Item seleccionado es: " + ddlQualification.SelectedItem.ToString();
            //Obtiene el valor de cada elemento
             s += "<br/> El valor del item seleccionado es: " + ddlQualification.SelectedValue.ToString();
            lblDDLResult.Text = s;
        }

        protected void ddlQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtiene el indice del combo
            string s = "Index s: " + ddlQualification.SelectedIndex.ToString();
            //Obtiene la opcion seleccionada
            s += "<br/> Item seleccionado es: " + ddlQualification.SelectedItem.ToString();
            //Obtiene el valor de cada elemento
            s += "<br/> El valor del item seleccionado es: " + ddlQualification.SelectedValue.ToString();
            lblDDLResult.Text = s;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string k = "";
            foreach (ListItem li in CheckBoxList1.Items)
            {

                if (li.Selected == true)
                {
                    k +="<br/>"+ li.Text.ToString();
                        
                }
            }
            Response.Write(k);
        }
    }
}