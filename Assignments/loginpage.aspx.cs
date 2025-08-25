using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            var encryptedPassword = HashPassword(password); 

            string connectionString = ConfigurationManager.ConnectionStrings["SampleDB"].ConnectionString;
            string insertQuery = "INSERT INTO loginpage (Username, Password) VALUES (@Username, @Password)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", name);
                    cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            Response.Redirect("userinfo.aspx");
        }

        public static string HashPassword(string password)
        {
            // Generate a salt
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // Derive the hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(32);

            // Combine salt and hash
            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);

            // Convert to Base64 for storage
            return Convert.ToBase64String(hashBytes);
        }


    }
}