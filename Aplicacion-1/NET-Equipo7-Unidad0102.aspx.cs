using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Aplicacion_1
{
    public partial class NET_Equipo7_Unidad0102 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txt_correo.Text, @"") || txt_correo.Text == "")
            {
                Response.Write("<script> alert('ERROR: Correo no valido'); </script>");
                Response.Redirect("/NET-Equipo7-Unidad0102.aspx");
            }

            if (!Regex.IsMatch(txt_tel.Text, @"{3}[0-9]+{7}[0-9]") || txt_tel.Text == "")
            {
                Response.Write("<script> alert('ERROR: Telefono no valido'); </script>");
                Response.Redirect("/NET-Equipo7-Unidad0102.aspx");
            }

            if (!Regex.IsMatch(txt_CURP.Text, @"") || txt_CURP.Text == "")
            {
                Response.Write("<script> alert('ERROR: CURP no valido'); </script>");
                Response.Redirect("/NET-Equipo7-Unidad0102.aspx");
            }

            if (!Regex.IsMatch(txt_RFC.Text, @"") || txt_RFC.Text == "")
            {
                Response.Write("<script> alert('ERROR: RFC no valido'); </script>");
                Response.Redirect("/NET-Equipo7-Unidad0102.aspx");
            }

        }
    }
}