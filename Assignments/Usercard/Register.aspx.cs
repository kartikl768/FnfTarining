using SampleWebFormsApp.EncryptPass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SampleWebFormsApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var pass1 = txtpassword.Text;
            var pass2 = txtpassword2.Text;

            if (pass1 != pass2)
            {
                lbltxt.Text = "Passwords do not match.";
                return;
            }
            else
            {
                pass1 = HashPassword.Hashpassword(pass1); // Hash the password
            }
            var name = txtusername.Text;
            var mail = txtemail.Text;
            var age = txtage.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", name);
                    int userExists = (int)checkCmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        lbltxt.Text = "Username already exists. Please choose another.";
                        return;
                    }
                }

                // Insert new user
                string insertQuery = "INSERT INTO Users (Username, Email, Age, PasswordHash) VALUES (@Username, @Email, @Age, @PasswordHash)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Username", name);
                    insertCmd.Parameters.AddWithValue("@Email", mail);
                    insertCmd.Parameters.AddWithValue("@Age", age);
                    insertCmd.Parameters.AddWithValue("@PasswordHash", pass1);

                    insertCmd.ExecuteNonQuery();
                }
            }
            Response.Redirect("loginpage.aspx");
        }

    }
}