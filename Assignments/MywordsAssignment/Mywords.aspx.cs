using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webformsAssignments
{
    public partial class Mywords : System.Web.UI.Page
    {
        // Use case-insensitive comparison for dictionary keys
        public static Dictionary<string, string> dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            var word = txtword.Text.Trim();

            if (dict.ContainsKey(word))
            {
                Response.Redirect($"MywordsDict.aspx?word={word}");
            }
            else
            {
                lbltxt.Text = $"{word} is not present in the application.";
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            var word1= txtnewword.Text;
            if (dict.ContainsKey(word1))
            {
                lbltxt1.Text = $"{word1} already present in the application";
            }
            else
            {
                dict.Add(word1, "");
                lbltxt1.Text=$"{word1} added successfully";
            }
        }
    }
}
