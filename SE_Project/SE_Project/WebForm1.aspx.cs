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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            int category;
            if (student.Checked)
            {
                category = 1;
            }
            else
            {
                category = 2;
            }
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Introduction values('" + name.Text + "','" + registrationnumber.Text + "','" + degree.Text + "','" + rank.Text + "','" + contact.Text + "','" + category + "')";
            cmd.ExecuteNonQuery();
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            name.Text = "";
            registrationnumber.Text = "";
            degree.Text = "";
            rank.Text = "";
            contact.Text = "";
            this.student.Checked = false;
            this.advisor.Checked = false;
        }

        protected void addprojects_Click(object sender, EventArgs e)
        {
            Response.Redirect("Projects.aspx");
        }
    }
}