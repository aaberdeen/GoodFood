using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Good_Food_Database
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        public string UserInput
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }


        private void InputBoxcs_Load(object sender, EventArgs e)
        {

        }
    }
}
