namespace Good_Food_Database
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoad = new System.Windows.Forms.Button();
            this.recipeDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAddNew = new System.Windows.Forms.TabPage();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.textBoxYearFilter = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxMonthFilter = new System.Windows.Forms.ComboBox();
            this.Sectionlbl = new System.Windows.Forms.Label();
            this.comboBoxSectionFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRatingFilter = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSourceFilter = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAddNew.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(633, 544);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load All";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // recipeDataGrid
            // 
            this.recipeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeDataGrid.Enabled = false;
            this.recipeDataGrid.Location = new System.Drawing.Point(8, 532);
            this.recipeDataGrid.Name = "recipeDataGrid";
            this.recipeDataGrid.Size = new System.Drawing.Size(774, 44);
            this.recipeDataGrid.TabIndex = 1;
            this.recipeDataGrid.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(714, 544);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Refresh";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAddNew);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 100);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageAddNew
            // 
            this.tabPageAddNew.Controls.Add(this.comboBoxMonth);
            this.tabPageAddNew.Controls.Add(this.comboBoxSection);
            this.tabPageAddNew.Controls.Add(this.label11);
            this.tabPageAddNew.Controls.Add(this.textBoxMethod);
            this.tabPageAddNew.Controls.Add(this.label12);
            this.tabPageAddNew.Controls.Add(this.label10);
            this.tabPageAddNew.Controls.Add(this.textBoxYear);
            this.tabPageAddNew.Controls.Add(this.label9);
            this.tabPageAddNew.Controls.Add(this.textBoxAuthor);
            this.tabPageAddNew.Controls.Add(this.buttonAddNew);
            this.tabPageAddNew.Controls.Add(this.label6);
            this.tabPageAddNew.Controls.Add(this.textBoxRating);
            this.tabPageAddNew.Controls.Add(this.label5);
            this.tabPageAddNew.Controls.Add(this.textBoxComments);
            this.tabPageAddNew.Controls.Add(this.label4);
            this.tabPageAddNew.Controls.Add(this.label3);
            this.tabPageAddNew.Controls.Add(this.label2);
            this.tabPageAddNew.Controls.Add(this.textBoxPage);
            this.tabPageAddNew.Controls.Add(this.label1);
            this.tabPageAddNew.Controls.Add(this.comboBoxSource);
            this.tabPageAddNew.Controls.Add(this.Namelbl);
            this.tabPageAddNew.Controls.Add(this.textBoxName);
            this.tabPageAddNew.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddNew.Name = "tabPageAddNew";
            this.tabPageAddNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddNew.Size = new System.Drawing.Size(766, 400);
            this.tabPageAddNew.TabIndex = 0;
            this.tabPageAddNew.Text = "Add New";
            this.tabPageAddNew.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(77, 87);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(75, 21);
            this.comboBoxMonth.TabIndex = 25;
            this.comboBoxMonth.Click += new System.EventHandler(this.comboBoxMonth_Click);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(77, 60);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(217, 21);
            this.comboBoxSection.TabIndex = 3;
            this.comboBoxSection.Click += new System.EventHandler(this.comboBoxSection_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Method";
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Location = new System.Drawing.Point(77, 142);
            this.textBoxMethod.Multiline = true;
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(217, 230);
            this.textBoxMethod.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(193, 87);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(101, 20);
            this.textBoxYear.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Author";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(359, 63);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(217, 20);
            this.textBoxAuthor.TabIndex = 4;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(597, 7);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(163, 365);
            this.buttonAddNew.TabIndex = 10;
            this.buttonAddNew.Text = "Add";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "/ 10";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(77, 116);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(24, 20);
            this.textBoxRating.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rating";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(359, 142);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(217, 230);
            this.textBoxComments.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Page";
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(359, 37);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(59, 20);
            this.textBoxPage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source";
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(77, 33);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(217, 21);
            this.comboBoxSource.TabIndex = 1;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            this.comboBoxSource.Click += new System.EventHandler(this.comboBoxSource_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(11, 10);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(35, 13);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 7);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(514, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createNewDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createNewDatabaseToolStripMenuItem
            // 
            this.createNewDatabaseToolStripMenuItem.Name = "createNewDatabaseToolStripMenuItem";
            this.createNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.createNewDatabaseToolStripMenuItem.Text = "Create New Database";
            this.createNewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createNewDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSourceToolStripMenuItem,
            this.addNewSectionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewSourceToolStripMenuItem
            // 
            this.addNewSourceToolStripMenuItem.Name = "addNewSourceToolStripMenuItem";
            this.addNewSourceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addNewSourceToolStripMenuItem.Text = "Add New Source";
            this.addNewSourceToolStripMenuItem.Click += new System.EventHandler(this.addNewSourceToolStripMenuItem_Click);
            // 
            // addNewSectionToolStripMenuItem
            // 
            this.addNewSectionToolStripMenuItem.Name = "addNewSectionToolStripMenuItem";
            this.addNewSectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addNewSectionToolStripMenuItem.Text = "Add New Section";
            this.addNewSectionToolStripMenuItem.Click += new System.EventHandler(this.addNewSectionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.textBoxYearFilter);
            this.groupBoxFilter.Controls.Add(this.label14);
            this.groupBoxFilter.Controls.Add(this.label13);
            this.groupBoxFilter.Controls.Add(this.comboBoxMonthFilter);
            this.groupBoxFilter.Controls.Add(this.Sectionlbl);
            this.groupBoxFilter.Controls.Add(this.comboBoxSectionFilter);
            this.groupBoxFilter.Controls.Add(this.label8);
            this.groupBoxFilter.Controls.Add(this.textBoxRatingFilter);
            this.groupBoxFilter.Controls.Add(this.buttonGo);
            this.groupBoxFilter.Controls.Add(this.label7);
            this.groupBoxFilter.Controls.Add(this.comboBoxSourceFilter);
            this.groupBoxFilter.Enabled = false;
            this.groupBoxFilter.Location = new System.Drawing.Point(0, 27);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(795, 67);
            this.groupBoxFilter.TabIndex = 5;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // textBoxYearFilter
            // 
            this.textBoxYearFilter.Location = new System.Drawing.Point(401, 38);
            this.textBoxYearFilter.Name = "textBoxYearFilter";
            this.textBoxYearFilter.Size = new System.Drawing.Size(74, 20);
            this.textBoxYearFilter.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(419, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Month";
            // 
            // comboBoxMonthFilter
            // 
            this.comboBoxMonthFilter.FormattingEnabled = true;
            this.comboBoxMonthFilter.Location = new System.Drawing.Point(320, 38);
            this.comboBoxMonthFilter.Name = "comboBoxMonthFilter";
            this.comboBoxMonthFilter.Size = new System.Drawing.Size(75, 21);
            this.comboBoxMonthFilter.TabIndex = 26;
            this.comboBoxMonthFilter.Click += new System.EventHandler(this.comboBoxMonthFilter_Click);
            // 
            // Sectionlbl
            // 
            this.Sectionlbl.AutoSize = true;
            this.Sectionlbl.Location = new System.Drawing.Point(160, 24);
            this.Sectionlbl.Name = "Sectionlbl";
            this.Sectionlbl.Size = new System.Drawing.Size(43, 13);
            this.Sectionlbl.TabIndex = 6;
            this.Sectionlbl.Text = "Section";
            // 
            // comboBoxSectionFilter
            // 
            this.comboBoxSectionFilter.FormattingEnabled = true;
            this.comboBoxSectionFilter.Location = new System.Drawing.Point(123, 39);
            this.comboBoxSectionFilter.Name = "comboBoxSectionFilter";
            this.comboBoxSectionFilter.Size = new System.Drawing.Size(140, 21);
            this.comboBoxSectionFilter.TabIndex = 5;
            this.comboBoxSectionFilter.Click += new System.EventHandler(this.comboBoxSectionFilter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rating";
            // 
            // textBoxRatingFilter
            // 
            this.textBoxRatingFilter.Location = new System.Drawing.Point(269, 39);
            this.textBoxRatingFilter.Name = "textBoxRatingFilter";
            this.textBoxRatingFilter.Size = new System.Drawing.Size(45, 20);
            this.textBoxRatingFilter.TabIndex = 3;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(707, 39);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Source";
            // 
            // comboBoxSourceFilter
            // 
            this.comboBoxSourceFilter.FormattingEnabled = true;
            this.comboBoxSourceFilter.Location = new System.Drawing.Point(16, 40);
            this.comboBoxSourceFilter.Name = "comboBoxSourceFilter";
            this.comboBoxSourceFilter.Size = new System.Drawing.Size(101, 21);
            this.comboBoxSourceFilter.TabIndex = 0;
            this.comboBoxSourceFilter.Click += new System.EventHandler(this.comboBoxSourceFilter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 588);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.recipeDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Good Food Beta 1.0.0.X";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAddNew.ResumeLayout(false);
            this.tabPageAddNew.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridView recipeDataGrid;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAddNew;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSourceToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSourceFilter;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRatingFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label Sectionlbl;
        private System.Windows.Forms.ComboBox comboBoxSectionFilter;
        private System.Windows.Forms.ComboBox comboBoxMonthFilter;
        private System.Windows.Forms.TextBox textBoxYearFilter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem addNewSectionToolStripMenuItem;
    }
}

