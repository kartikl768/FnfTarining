using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webformsAssignments
{
    public partial class MywordsDict : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string word = Request.QueryString["word"];
                if (!string.IsNullOrEmpty(word))
                {
                    BindRepeater(word);
                }
                else
                {
                    lblStatus.Text = "No word was passed to this page.";
                }
            }
        }

        private void BindRepeater(string word)
        {
            var wordItems = new List<WordItem>
            {
                new WordItem { Word = word }
            };
            rpMyWords.DataSource = wordItems;
            rpMyWords.DataBind();
        }

        protected void rpMyWords_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {
                string word = e.CommandArgument.ToString();
                TextBox txtTranslation = (TextBox)e.Item.FindControl("txtTranslation");

                if (txtTranslation != null)
                {
                    string translation = txtTranslation.Text.Trim();

                    if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(translation))
                    {
                        if (!Mywords.dict.ContainsKey(word))
                        {
                            Mywords.dict.Add(word, translation);
                            lblStatus.Text = $"Added '{word}' with translation '{translation}' to dictionary.";
                        }
                        else
                        {
                            Mywords.dict[word] = translation; // Update translation
                            lblStatus.Text = $"Updated '{word}' with new translation '{translation}'.";
                        }
                    }
                    else
                    {
                        lblStatus.Text = "Please enter a valid translation.";
                    }
                }
            }
        }

        public class WordItem
        {
            public string Word { get; set; }
            public string Translation { get; set; }
        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            Response.Redirect("displaymywords.aspx");
        }
    }
}
