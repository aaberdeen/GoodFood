using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Good_Food_Database
{
    public partial class RecipeCardControl : TabPage//TabPage  //UserControl  //alternate to user control to edit
    {
        private SQLITE _db;

        public RecipeCardControl(DataTable Source,DataTable Sections, SQLITE db)
        {
            InitializeComponent();
            _db = db;
             for (int i = 0; i < Source.Rows.Count; i++)
            {

               comboBoxSource.Items.Add(Source.Rows[i]["source_name"]);
                
            }
             for (int i = 0; i < Sections.Rows.Count; i++)
             {
                 comboBoxSection.Items.Add(Sections.Rows[i]["section_name"]);

             }
            
        {
            comboBoxMonth.Items.Clear();

            comboBoxMonth.Items.Add("Month");
            comboBoxMonth.Items.Add("Jan");
            comboBoxMonth.Items.Add("Feb");
            comboBoxMonth.Items.Add("Mar");
            comboBoxMonth.Items.Add("Apr");
            comboBoxMonth.Items.Add("May");
            comboBoxMonth.Items.Add("June");
            comboBoxMonth.Items.Add("Jul");
            comboBoxMonth.Items.Add("Aug");
            comboBoxMonth.Items.Add("Sept");
            comboBoxMonth.Items.Add("Oct");
            comboBoxMonth.Items.Add("Nov");
            comboBoxMonth.Items.Add("Dec");
            
        }

        }

        public string recipe_ID
        {
            get{ return textBoxID.Text;}
            set { textBoxID.Text = value; }
        }

        public string recipe_Name
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public string page_number
        {
            get { return textBoxPage.Text; }
            set { textBoxPage.Text = value; }
        }
        public string author
        {
            get { return textBoxAuthor.Text; }
            set { textBoxAuthor.Text = value; }
        }
        public int source_id
        {
            get { return  comboBoxSource.SelectedIndex; }
            set { comboBoxSource.SelectedIndex = value; }
        }
        public int issue_month
        {
            get { return comboBoxMonth.SelectedIndex; }
            set { comboBoxMonth.SelectedIndex = value; }
        }
        public int section_id
        {
            get { return  comboBoxSection.SelectedIndex; }
            set { comboBoxSection.SelectedIndex = value; }
        }
        public string comments
        {
            get { return textBoxComments.Text; }
            set { textBoxComments.Text = value; }
        }
        public string rating
        {
            get { return textBoxRating.Text; }
            set { textBoxRating.Text = value; }
        }
        public string issue_year
        {
            get { return textBoxYear.Text; }
            set { textBoxYear.Text = value; }
        }
        public string method
        {
            get { return textBoxMethod.Text; }
            set { textBoxMethod.Text = value; }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("Recipe_Name", textBoxName.Text);
            data.Add("source_id", Convert.ToString(comboBoxSource.SelectedIndex));
            data.Add("page_number", textBoxPage.Text);
            data.Add("section_id", Convert.ToString(comboBoxSection.SelectedIndex));
            data.Add("author", textBoxAuthor.Text);
            data.Add("Comments", textBoxComments.Text);
            data.Add("Rating", textBoxRating.Text);
            data.Add("issue_year", textBoxYear.Text);
            data.Add("issue_month", Convert.ToString(comboBoxMonth.SelectedIndex));
            data.Add("method", textBoxMethod.Text);

            string where = string.Format("Recipe_id = {0}", textBoxID.Text);


            _db.Update("Recipes", data, where);

           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string where = string.Format("Recipe_id = {0}", textBoxID.Text);
            _db.Delete("Recipes", where);
        }





    }
}
