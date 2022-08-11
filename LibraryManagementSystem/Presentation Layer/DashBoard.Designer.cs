namespace LibraryManagementSystem.Presentation_Layer
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.librarianMenuStrip = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addLibrarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLibrarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMenuStrip = new System.Windows.Forms.MenuStrip();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdPanel = new System.Windows.Forms.Panel();
            this.stdPicBox = new System.Windows.Forms.PictureBox();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.adminPicBox = new System.Windows.Forms.PictureBox();
            this.libPanel = new System.Windows.Forms.Panel();
            this.libPicBox = new System.Windows.Forms.PictureBox();
            this.librarianMenuStrip.SuspendLayout();
            this.adminMenuStrip.SuspendLayout();
            this.studentMenuStrip.SuspendLayout();
            this.stdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdPicBox)).BeginInit();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPicBox)).BeginInit();
            this.libPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // librarianMenuStrip
            // 
            this.librarianMenuStrip.BackColor = System.Drawing.Color.Wheat;
            this.librarianMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.librarianMenuStrip.Location = new System.Drawing.Point(0, 196);
            this.librarianMenuStrip.Name = "librarianMenuStrip";
            this.librarianMenuStrip.Size = new System.Drawing.Size(1316, 109);
            this.librarianMenuStrip.TabIndex = 0;
            this.librarianMenuStrip.Text = "librarianMenu";
            this.librarianMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.librarianMenu_ItemClicked);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.viewBookInformationToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Margin = new System.Windows.Forms.Padding(250, 14, 0, 0);
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(83, 91);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.booksToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addBookToolStripMenuItem.Image")));
            this.addBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(276, 66);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // viewBookInformationToolStripMenuItem
            // 
            this.viewBookInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookInformationToolStripMenuItem.Image")));
            this.viewBookInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBookInformationToolStripMenuItem.Name = "viewBookInformationToolStripMenuItem";
            this.viewBookInformationToolStripMenuItem.Size = new System.Drawing.Size(276, 66);
            this.viewBookInformationToolStripMenuItem.Text = "View Book Info";
            this.viewBookInformationToolStripMenuItem.Click += new System.EventHandler(this.viewBookInformationToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentInfoToolStripMenuItem});
            this.studentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsToolStripMenuItem.Image")));
            this.studentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(14, 5, 0, 0);
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(103, 100);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem.Image")));
            this.addStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(300, 78);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            this.viewStudentInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentInfoToolStripMenuItem.Image")));
            this.viewStudentInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            this.viewStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(300, 78);
            this.viewStudentInfoToolStripMenuItem.Text = "View Student Info";
            this.viewStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.viewStudentInfoToolStripMenuItem_Click);
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksToolStripMenuItem.Image")));
            this.issueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(128, 105);
            this.issueBooksToolStripMenuItem.Text = "Issue Books";
            this.issueBooksToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.returnBooksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBooksToolStripMenuItem.Image")));
            this.returnBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBooksToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(145, 101);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            this.returnBooksToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 105);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(300, 3, 0, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(89, 102);
            this.exitToolStripMenuItem.Text = "Logout";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminMenuStrip
            // 
            this.adminMenuStrip.BackColor = System.Drawing.Color.Wheat;
            this.adminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLibrarianToolStripMenuItem,
            this.viewLibrarianToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.adminMenuStrip.Location = new System.Drawing.Point(0, 98);
            this.adminMenuStrip.Name = "adminMenuStrip";
            this.adminMenuStrip.Size = new System.Drawing.Size(1316, 98);
            this.adminMenuStrip.TabIndex = 3;
            this.adminMenuStrip.Text = "adminMenuStrip";
            // 
            // addLibrarianToolStripMenuItem
            // 
            this.addLibrarianToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(147)))));
            this.addLibrarianToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLibrarianToolStripMenuItem.Margin = new System.Windows.Forms.Padding(350, 0, 0, 0);
            this.addLibrarianToolStripMenuItem.Name = "addLibrarianToolStripMenuItem";
            this.addLibrarianToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.addLibrarianToolStripMenuItem.Size = new System.Drawing.Size(238, 94);
            this.addLibrarianToolStripMenuItem.Text = " Librarian Information";
            this.addLibrarianToolStripMenuItem.Click += new System.EventHandler(this.addLibrarianToolStripMenuItem_Click);
            // 
            // viewLibrarianToolStripMenuItem
            // 
            this.viewLibrarianToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLibrarianToolStripMenuItem.Name = "viewLibrarianToolStripMenuItem";
            this.viewLibrarianToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.viewLibrarianToolStripMenuItem.Size = new System.Drawing.Size(223, 94);
            this.viewLibrarianToolStripMenuItem.Text = "Student Information";
            this.viewLibrarianToolStripMenuItem.Click += new System.EventHandler(this.viewLibrarianToolStripMenuItem_Click_1);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(147)))));
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(350, 0, 0, 0);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(102, 94);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // studentMenuStrip
            // 
            this.studentMenuStrip.BackColor = System.Drawing.Color.Wheat;
            this.studentMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBookToolStripMenuItem,
            this.searchBookToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.studentMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.studentMenuStrip.Name = "studentMenuStrip";
            this.studentMenuStrip.Size = new System.Drawing.Size(1316, 98);
            this.studentMenuStrip.TabIndex = 4;
            this.studentMenuStrip.Text = "studentMenuStrip";
            this.studentMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.studentMenuStrip_ItemClicked);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(147)))));
            this.viewBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(400, 0, 0, 0);
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(198, 94);
            this.viewBookToolStripMenuItem.Text = "View Issued Book";
            this.viewBookToolStripMenuItem.Click += new System.EventHandler(this.viewBookToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(177, 94);
            this.searchBookToolStripMenuItem.Text = "Avaiable Books";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(206)))), ((int)(((byte)(147)))));
            this.logoutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(413, 0, 0, 0);
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(102, 94);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome To  Admin Portal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Welcome To Librarian Portal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome To Student Portal";
            // 
            // stdPanel
            // 
            this.stdPanel.BackColor = System.Drawing.Color.Wheat;
            this.stdPanel.Controls.Add(this.stdPicBox);
            this.stdPanel.Controls.Add(this.label1);
            this.stdPanel.Location = new System.Drawing.Point(891, 0);
            this.stdPanel.Name = "stdPanel";
            this.stdPanel.Size = new System.Drawing.Size(226, 98);
            this.stdPanel.TabIndex = 11;
            this.stdPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // stdPicBox
            // 
            this.stdPicBox.Location = new System.Drawing.Point(79, 32);
            this.stdPicBox.Name = "stdPicBox";
            this.stdPicBox.Size = new System.Drawing.Size(76, 60);
            this.stdPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stdPicBox.TabIndex = 13;
            this.stdPicBox.TabStop = false;
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.Wheat;
            this.adminPanel.Controls.Add(this.adminPicBox);
            this.adminPanel.Controls.Add(this.label2);
            this.adminPanel.Location = new System.Drawing.Point(836, 3);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(246, 95);
            this.adminPanel.TabIndex = 12;
            this.adminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // adminPicBox
            // 
            this.adminPicBox.Location = new System.Drawing.Point(88, 29);
            this.adminPicBox.Name = "adminPicBox";
            this.adminPicBox.Size = new System.Drawing.Size(76, 60);
            this.adminPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminPicBox.TabIndex = 12;
            this.adminPicBox.TabStop = false;
            // 
            // libPanel
            // 
            this.libPanel.BackColor = System.Drawing.Color.Wheat;
            this.libPanel.Controls.Add(this.libPicBox);
            this.libPanel.Controls.Add(this.label3);
            this.libPanel.Location = new System.Drawing.Point(1, 2);
            this.libPanel.Name = "libPanel";
            this.libPanel.Size = new System.Drawing.Size(227, 91);
            this.libPanel.TabIndex = 13;
            // 
            // libPicBox
            // 
            this.libPicBox.Location = new System.Drawing.Point(82, 38);
            this.libPicBox.Name = "libPicBox";
            this.libPicBox.Size = new System.Drawing.Size(76, 50);
            this.libPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.libPicBox.TabIndex = 11;
            this.libPicBox.TabStop = false;
            this.libPicBox.Click += new System.EventHandler(this.libPicBox_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1316, 643);
            this.Controls.Add(this.libPanel);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.stdPanel);
            this.Controls.Add(this.librarianMenuStrip);
            this.Controls.Add(this.adminMenuStrip);
            this.Controls.Add(this.studentMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.librarianMenuStrip;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.librarianMenuStrip.ResumeLayout(false);
            this.librarianMenuStrip.PerformLayout();
            this.adminMenuStrip.ResumeLayout(false);
            this.adminMenuStrip.PerformLayout();
            this.studentMenuStrip.ResumeLayout(false);
            this.studentMenuStrip.PerformLayout();
            this.stdPanel.ResumeLayout(false);
            this.stdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdPicBox)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPicBox)).EndInit();
            this.libPanel.ResumeLayout(false);
            this.libPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip librarianMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip adminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addLibrarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLibrarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip studentMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel stdPanel;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.PictureBox adminPicBox;
        private System.Windows.Forms.Panel libPanel;
        private System.Windows.Forms.PictureBox libPicBox;
        private System.Windows.Forms.PictureBox stdPicBox;
    }
}