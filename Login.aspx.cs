using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace PP2024_V10
{
    public partial class Login : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaConexionPP2024"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                try
                {
                    //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    //builder.DataSource = "BANGHO";
                    //builder.InitialCatalog = "ABM_BIB";
                    //builder.UserID = "sa";
                    //builder.Password = "13213";

                    string script = "SELECT USUARIO FROM LOGIN WHERE USUARIO = '" + txtUsuario.Text + "' AND" +
                        " PASS = '" + txtPassword.Text + "'";

                    connection.Open();

                    SqlCommand command = new SqlCommand(script, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    string user = String.Empty;

                    while (reader.Read())
                    {
                        user = reader.GetString(0);
                    }
                    reader.Close();

                    if (user != String.Empty)
                    {
                        Session["Usuario"] = txtUsuario.Text;

                        //Agregar "false" en el redirect. Le indicamos a la aplicacion
                        //que debe terminar el codigo en esta pagina y redigir a la siguiente.
                        Response.Redirect("Inicio.aspx",false);
                    }

                    //else
                        //lblError.Text = "Usuario o Password incorrectos.";

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }


        }


    }
}