using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Configuration;



namespace AdoDemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = new SqlConnection(CS);
            
                SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from employee";
            cmd.Connection = con;
               con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            con.Close();

           

                

            

        }
    }
}