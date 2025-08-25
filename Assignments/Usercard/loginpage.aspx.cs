using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;

namespace SampleWebFormsApp
{
    public partial class loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            var name = txtname.Text;
            var password = txtpassword.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;
            string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", name);
                    conn.Open();

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedHash = reader["PasswordHash"].ToString();

                        bool isValid = SampleWebFormsApp.EncryptPass.HashPassword.VerifyPassword(password, storedHash);
                        if (isValid)
                        {
                            Response.Redirect("userinfo.aspx");
                        }
                        else
                        {
                            lbltext.Text = "Invalid password.";
                        }
                    }
                    else
                    {
                        lbltext.Text = "Username not found.";
                    }
                }
            }
        }



        protected void btnregister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}


