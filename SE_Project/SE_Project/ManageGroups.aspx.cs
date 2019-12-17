using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SE_Project
{
    public partial class ManageGroups : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT project_name FROM project ", con);
           allprojects.DataSource = cmd.ExecuteReader();
            allprojects.DataTextField = "project_name";
            allprojects.DataBind();
        }

        protected void addgroup_Click(object sender, EventArgs e)
        {
              
        }

        protected void check_Click(object sender, EventArgs e)
        {
            String a =allprojects.SelectedValue.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT advisor_name from project WHERE project_name='a'", con);
            cmd.ExecuteNonQuery();
            


        }
    }
}