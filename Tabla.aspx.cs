using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PP2024_V10
{
    public partial class Tabla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["Usuario"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    if (Session["Usuario"].ToString() == String.Empty)
                        Response.Redirect("Login.aspx");
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                //e.CommandArgument.ToString();
                int index = int.Parse(e.CommandArgument.ToString());
                string id = GridView1.DataKeys[index].Value.ToString();


                Response.Redirect("Modificar.aspx?ID=" + id);
                //GridView1.data

            }
        }
    }
}