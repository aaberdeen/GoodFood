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
        private string _fileName;
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
                _fileName = saveFileDialog1.FileName;
                textBoxFileLocation.Text = _fileName;
            }
        }

        private void buttonCreateDataBase_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile(_fileName);
            SQLITE db = new SQLITE(_fileName);
            db.executeScript("CreateTableScript.txt");
            
        }
    }
}
