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
    public partial class Projects : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            // String com = "SELECT name FROM Introduction WHERE catId='2'";
            SqlCommand cmd = new SqlCommand("SELECT name FROM Introduction WHERE catId='2'", con);
           
            advisorlist.DataSource = cmd.ExecuteReader();
            advisorlist.DataTextField = "name";
            advisorlist.DataBind();
            
            
        }

        protected void manage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manage.aspx");
        }

        protected void advisorlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void addmore_Click(object sender, EventArgs e)
        {
            this.advisorlist.SelectedValue = null;
            projectname.Text = "";
            projectdescription.Text = "";

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into project values('" + projectname.Text + "','" + projectdescription.Text + "','" + advisorlist.SelectedValue + "')",conn);
            cmd.ExecuteNonQuery();
        }
    }
}