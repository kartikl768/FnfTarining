using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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
                string query = "SELECT Username FROM loginpage";

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

    }
}
