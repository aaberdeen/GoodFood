using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Good_Food_Database
{
    public partial class dataBaseCreationForm : Form
    {
        //private string _fileName;
       
        public dataBaseCreationForm()
        {
            InitializeComponent();
        }

        private void buttonBrowsFolders_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.s3db";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "SQLite3 DB |*.s3db";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
               // _fileName = saveFileDialog1.FileName;
                Properties.Settings.Default.fileName = saveFileDialog1.FileName;
                Properties.Settings.Default.Save();
                textBoxFileLocation.Text = Properties.Settings.Default.fileName;
                
            }
        }

        private void buttonCreateDataBase_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile(Properties.Settings.Default.fileName);
            SQLITE db = new SQLITE(Properties.Settings.Default.fileName);
            db.executeScript("CreateTableScript.txt");

           
            addSection(db, "Starters, Soups, Salads, Sides");
            addSection(db, "Fish & Seafood");
            addSection(db, "Poultry & Game");
            addSection(db, "Meat");
            addSection(db, "Vegetarian dishes");
            addSection(db, "Baking & Desserts");
            addSection(db, "Drinks");
            addSource(db, "BBC Good Food");

            this.Close();
        }

        private void addSection(SQLITE db, string section)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();


            if (section != "")
            {
                data.Add("section_name", section);
                db.Insert("Sections", data);
            }
        }
        private void addSource(SQLITE db, string source)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            if (source != "")
            {
                data.Add("source_name", source);
                db.Insert("source", data);
            }
        }
    }
}
