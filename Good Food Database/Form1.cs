using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;




namespace Good_Food_Database
{
    public partial class Form1 : Form
    {
        //SQLiteDatabase db;
       // SQLiteConnection db;
        DataTable recipe;
        DataTable Mags;
        DataTable Sections;
        SQLITE db;

        List<Recipe> recipeList = new List<Recipe>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dbConnection = @"C:\Users\andy.DDDES\Documents\Visual Studio 2012\Projects\Good Food Database\Good Food Database\SqliteTestDB.s3db"; 
            db = new SQLITE(dbConnection);
            Mags = db.GetDataTable("Magazines");
            Sections = db.GetDataTable("Sections");
            recipe = db.GetDataTable("Recipes");
            updateForm();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //db = new SQLiteDatabase();

               // string dbConnection = @"Data Source=C:\Users\andy.DDDES\Documents\Visual Studio 2012\Projects\Good Food Database\Good Food Database\SqliteTestDB.s3db";
               // string dbConnection = @"C:\Users\andy.DDDES\Documents\Visual Studio 2012\Projects\Good Food Database\Good Food Database\SqliteTestDB.s3db"; 
               // db = new SQLITE(dbConnection);
             
                           
               // String query = "select * from Recipes";



                recipe = db.GetDataTable("Recipes");

                //recipe.RowChanged += new DataRowChangeEventHandler(Row_Changed);
                // The results can be directly applied to a DataGridView control

                updateForm();
                


                //foreach (DataRowCollection recipeRow in recipe.Rows)
                //{
                //    Recipe recipeTemp = new Recipe();
                //    recipeTemp.recipe_id = recipeRow

                //    // add a recoipe card to a list and then we can populate the cards from the list.
                    
                //   // tabControl1.TabPages.Add("test");
                //    recipeCard.Parent = tabControl1;
                //}
                /*

                // Or looped through for some other reason

                foreach (DataRow r in recipe.Rows)

                {

                    MessageBox.Show(r["Name"].ToString());

                    MessageBox.Show(r["Description"].ToString());

                    MessageBox.Show(r["Prep Time"].ToString());

                    MessageBox.Show(r["Cooking Time"].ToString());

                }

   

                */

            }

            catch (Exception fail)
            {

                String error = "The following error has occurred:\n\n";

                error += fail.Message.ToString() + "\n\n";

                MessageBox.Show(error);

                this.Close();

            }
        }

        private void updateForm()
        {
            recipeDataGrid.DataSource = recipe;



            foreach (TabPage page in tabControl1.TabPages)
            {
                if (page.Text != "Add New")
                {
                    tabControl1.TabPages.Remove(page);
                }
            }
            recipeList.Clear();


            for (int i = 0; i < recipe.Rows.Count; i++)
            {
                Recipe recipeTemp = new Recipe(Mags,Sections, db);
                recipeTemp.recipe_id = Convert.ToInt32(recipe.Rows[i]["Recipe_id"]);
                recipeTemp.recipe_name = recipe.Rows[i]["recipe_name"].ToString();
                




                recipeTemp.recipeCard.recipe_ID = recipeTemp.recipe_id.ToString();
                recipeTemp.recipeCard.recipe_Name = recipeTemp.recipe_name;
                recipeTemp.recipeCard.page_number = recipe.Rows[i]["page_number"].ToString();
                recipeTemp.recipeCard.author = recipe.Rows[i]["author"].ToString();
                recipeTemp.recipeCard.magazine_id = Convert.ToInt32(recipe.Rows[i]["magazine_id"].ToString());
                recipeTemp.recipeCard.issue_month = Convert.ToInt32(recipe.Rows[i]["issue_month"].ToString());

                recipeTemp.recipeCard.section_id = Convert.ToInt32(recipe.Rows[i]["section_id"].ToString());  //recipe.Rows[i]["section_id"].ToString();
                recipeTemp.recipeCard.comments = recipe.Rows[i]["Comments"].ToString();
                recipeTemp.recipeCard.rating = recipe.Rows[i]["rating"].ToString();
                recipeTemp.recipeCard.issue_year = recipe.Rows[i]["issue_year"].ToString();
                recipeTemp.recipeCard.method = recipe.Rows[i]["method"].ToString();





                recipeTemp.recipeCard.Text = string.Format("{0}", i + 1);
                recipeList.Add(recipeTemp);

            }

            foreach (Recipe res in recipeList)
            {
                TabPage temp = res.recipeCard as TabPage;

                tabControl1.TabPages.Add(res.recipeCard);
                //res.recipeCard.Parent = tabControl1;
            }
        }

        private void Row_Changed(object sender, DataRowChangeEventArgs e)
        {
           //// throw new NotImplementedException();

           // //so we need to see what rows have changed and then do an update for each one 

           // if (e.Action == DataRowAction.Add)
           // {  
           //     Dictionary<String, String> data = new Dictionary<String, String>();
           //     string row = e.Row.ItemArray[0].ToString();
           //     int i =0;
           //     foreach(DataColumn col in e.Row.Table.Columns)
           //     {
           //         if (i == 5)
           //         {
           //             data.Add(col.ColumnName,(e.Row.ItemArray[i++].ToString()));
           //         }
           //         else
           //         {
           //             data.Add(col.ColumnName, e.Row.ItemArray[i++].ToString());
           //         }
           //    // data.Add(e.Row.Table.Columns[0].ColumnName,e.Row.Table.Columns[0].ToString()); 
           //     }

           //     //db.Update("Recipes", data, row);
           //     //db.Insert("Recipes", data);
           // }
           // if (e.Action == DataRowAction.Change)
           // {
           // }
           // if (e.Action == DataRowAction.Delete)
           // {
           // }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            update();

        }

        private void update()
        {
            //db = new SQLiteDatabase();

            string dbConnection = @"C:\Users\andy.DDDES\Documents\Visual Studio 2012\Projects\Good Food Database\Good Food Database\SqliteTestDB.s3db";
            db = new SQLITE(dbConnection);


           // Dictionary<String, String> data = new Dictionary<String, String>();

           // DataTable rows;

            //data.Add("NAME", nameTextBox.Text);

            //data.Add("DESCRIPTION", descriptionTextBox.Text);

            //data.Add("PREP_TIME", prepTimeTextBox.Text);

            //data.Add("COOKING_TIME", cookingTimeTextBox.Text);

            try
            {

                //    db.Update("RECIPE", data, String.Format("RECIPE.ID = {0}", this.RecipeID));
                db.SaveDataTable(recipe);

            }

            catch (Exception crap)
            {

                MessageBox.Show(crap.Message);

            }
        }

 
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("Recipe_Name", textBoxName.Text);
            data.Add("magazine_id", Convert.ToString(comboBoxSource.SelectedIndex));
            data.Add("page_number", textBoxPage.Text);
            data.Add("section_id", Convert.ToString(comboBoxSection.SelectedIndex));
            data.Add("author", textBoxAuthor.Text);
            data.Add("Comments", textBoxComments.Text);
            data.Add("Rating", textBoxRating.Text);
            data.Add("issue_year", textBoxYear.Text);
            data.Add("issue_month", Convert.ToString(comboBoxMonth.SelectedIndex));
            data.Add("method", textBoxMethod.Text);
          //  data.Add("magazine_id", textBoxSource.Text);
            
            //data.Add("issue", textBoxIssue.Text);
            
            
            


            if (db != null)
            {
                db.Insert("Recipes", data);
            }
            else
            {
                MessageBox.Show("not connected I think db=null");
            }
        }

        private void comboBoxSource_Click(object sender, EventArgs e)
        {
            ComboBox temp = sender as ComboBox;
            getSources(temp);

        }

        private void getSources(ComboBox temp)
        {
            temp.Items.Clear();

            Mags = db.GetDataTable("Magazines");

            for (int i = 0; i < Mags.Rows.Count; i++)
            {

                temp.Items.Add(Mags.Rows[i]["magazine_name"]);
            }
        }

        private void getSections(ComboBox temp)
        {
            temp.Items.Clear();

            Sections = db.GetDataTable("Sections");

            for (int i = 0; i < Sections.Rows.Count; i++)
            {

                temp.Items.Add(Sections.Rows[i]["section_name"]);
            }
        }

        private void getMonths(ComboBox temp)
        {
            temp.Items.Clear();

            temp.Items.Add("Month");
            temp.Items.Add("Jan");
            temp.Items.Add("Feb");
            temp.Items.Add("Mar");
            temp.Items.Add("Apr");
            temp.Items.Add("May");
            temp.Items.Add("June");
            temp.Items.Add("Jul");
            temp.Items.Add("Aug");
            temp.Items.Add("Sept");
            temp.Items.Add("Oct");
            temp.Items.Add("Nov");
            temp.Items.Add("Dec");
            
        }



        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            
            InputBox ip = new InputBox();
            DialogResult result = ip.ShowDialog(this);
            if (result == DialogResult.OK)
            {
               data.Add("magazine_name", ip.UserInput); 
                db.Insert("Magazines", data);
            }


        }

        private void comboBoxSourceFilter_Click(object sender, EventArgs e)
        {
            ComboBox temp = sender as ComboBox;
            getSources(temp);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {

            string[] where = new string[10];
            string temp;
            int i = 0;

            if (comboBoxSourceFilter.Text != "")
            {
                temp = String.Format("magazine_id = {0}", Convert.ToString(comboBoxSourceFilter.SelectedIndex));
                where[i++] = temp;
            }
            if (comboBoxSectionFilter.Text !="")
            {
                temp = string.Format("section_id = {0}", Convert.ToString(comboBoxSectionFilter.SelectedIndex));
                where[i++] = temp;   
            }
            if (textBoxRatingFilter.Text != "")
            {
                temp = String.Format("rating = {0}", textBoxRatingFilter.Text);
                where[i++] = temp;
            }
            if(comboBoxMonthFilter.Text != "")
            {
                temp = string.Format("issue_month = {0}", Convert.ToString(comboBoxMonthFilter.SelectedIndex));
                where[i++] = temp;
            }
            if(textBoxYearFilter.Text != "")
            {
                temp = string.Format("issue_year = {0}", textBoxYearFilter.Text);
                where[i++] = temp;
            }
           
            

            
           // recipe = db.GetDataTable("Recipes",Convert.ToString(comboBoxSourceFilter.SelectedIndex+1));

            if (i != 0)
            {
                recipe = db.GetDataTable("Recipes", where);

                updateForm();
            }
            else
            {
                recipe = db.GetDataTable("Recipes");
                updateForm();
            }
        }

        private void comboBoxSection_Click(object sender, EventArgs e)
        {
            getSections(sender as ComboBox);
        }

        private void comboBoxMonth_Click(object sender, EventArgs e)
        {
            getMonths(sender as ComboBox);
        }

        private void comboBoxSectionFilter_Click(object sender, EventArgs e)
        {
            getSections(sender as ComboBox);
        }

        private void comboBoxMonthFilter_Click(object sender, EventArgs e)
        {
            getMonths(sender as ComboBox);
        }

        private void createNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBaseCreationForm dbCreate = new dataBaseCreationForm();
            dbCreate.Show();
        }


    }
}
