using System;
using System.Collections.Generic;
using System.Web.UI;

namespace webformsAssignments
{
    public partial class displaymywords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindMyWords();
            }
        }

        private void BindMyWords()
        {
            var wordList = new List<WordItem>();

            foreach (var entry in Mywords.dict)
            {
                wordList.Add(new WordItem
                {
                    Word = entry.Key,
                    Translation = entry.Value
                });
            }
            gvMyWords.DataSource = wordList;
            gvMyWords.DataBind();
        }

        public class WordItem
        {
            public string Word { get; set; }
            public string Translation { get; set; }
        }
    }
}
