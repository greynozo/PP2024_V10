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
    public partial class Modificar : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaConexionPP2024"].ConnectionString;
        private static string id = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                id = Request.QueryString["ID"];

                TraerLibro(id);
            }
        }


        public void TraerLibro(string id)
        {
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                try
                {

                    string script = "SELECT * FROM ALUMNOS WHERE ID= " + id;

                    connection.Open();

                    SqlCommand command = new SqlCommand(script, connection);

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        txtNombre.Text = reader.GetString(1);
                        txtEmail.Text = reader.GetString(2);
                        txtNota.Text = reader.GetInt32(3).ToString();
                    }

                    connection.Close();

                }
                catch (Exception)
                {
                    

                }
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                try
                {
                    string script = String.Format( "UPDATE ALUMNOS SET NOMBRE = '{0}', EMAIL = '{1}', NOTA = {2} WHERE ID = {3}", 
                        txtNombre.Text, txtEmail.Text, txtNota.Text, id);

                    connection.Open();

                    SqlCommand command = new SqlCommand(script, connection);

                   int resp = command.ExecuteNonQuery();

                   if (resp > 0)
                   {
                       lblMensaje.Visible = true;
                       lblMensaje.Text = "Se guardo el correctamente";
                   }
                   else
                   {
                       lblMensaje.Visible = true;
                       lblMensaje.Text = "Se guardo el correctamente";
                   }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}