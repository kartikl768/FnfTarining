using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class userinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUsernames();
            }
        }

        private void LoadUsernames()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;
                string query = "SELECT Username FROM Users";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        var reader = cmd.ExecuteReader();
                        var usernames = new List<string>();
                        while (reader.Read())
                        {
                            usernames.Add(reader["Username"].ToString());
                        }
                        Repeater1.DataSource = usernames.Select(u => new { Username = u });
                        Repeater1.DataBind();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "ViewMore")
            {
                string selectedUsername = e.CommandArgument.ToString();

                string connectionString = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;
                string query = "SELECT Username, Email, Age FROM Users WHERE Username = @Username";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", selectedUsername);
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string name = reader["Username"].ToString();
                            string email = reader["Email"].ToString();
                            string age = reader["Age"].ToString();

                            lblDetails.Text = $"Username: {name}<br/>Email: {email}<br/>Age: {age}";
                        }
                        else
                        {
                            lblDetails.Text = "User not found.";
                        }
                    }
                }
            }
        }

    }
}
