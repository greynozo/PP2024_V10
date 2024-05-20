using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Odbc;



namespace PP2024_V10
{
    public partial class _Default : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaConexionPP2024"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtNombre.Text == "")
            //if (txtNombre.Text == String.Empty)
            if (!String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellido.Text))
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
           
                //Nombre del servidor o DataSource
                builder.DataSource = "BANGHO\\MSSQLSERVER19";
                //Nombre de la base de datos
                builder.InitialCatalog = "PP2024_V10";
                //Indicamos que se trata de Seguridad Integrada
                builder.IntegratedSecurity = true;
                builder.PersistSecurityInfo = true;
                builder.ApplicationName = "PP2024_V10";


                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    string script = "SELECT * FROM USUARIOS WHERE ID= 1";

                    conn.Open();

                    SqlCommand command = new SqlCommand(script, conn);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader.GetInt32(0).ToString();
                            string nombre = reader.GetString(1);
                            lblTexto.Text = "Se ha creado el usuario " + nombre;
                        }
                    }
                    reader.Close();
                    conn.Close();
                }

                //OdbcConnection cn = new OdbcConnection("DSN=NombreConexion;UID=sa;PWD=123456");
                //OdbcCommand cmd = new OdbcCommand("select minvalue,maxvalue from tblRDvalidRange");
                //cn.Open();
                //cmd.Connection = cn;
                //OdbcDataReader rd = cmd.ExecuteReader();

                //if (rd.Read())
                //{
                //    int minvalue = System.Convert.ToInt32(rd[0]);
                //    int maxvalue = System.Convert.ToInt32(rd[1]);
                //}

                //cn.Close();


                //lblTexto.Text = "Se ha generado el usuario para " + txtNombre.Text + " " + txtApellido.Text;
            }
            else
            {
                lblTexto.Text = "Todos los campos son obligatorios";
            }
        }
    }
}
