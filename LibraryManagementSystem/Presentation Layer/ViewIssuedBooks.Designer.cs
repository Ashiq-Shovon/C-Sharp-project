namespace LibraryManagementSystem.Presentation_Layer
{
    partial class ViewIssuedBooks
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
            this.book1 = new System.Windows.Forms.GroupBox();
            this.issued1 = new System.Windows.Forms.Label();
            this.bn1 = new System.Windows.Forms.Label();
            this.book2 = new System.Windows.Forms.GroupBox();
            this.issued2 = new System.Windows.Forms.Label();
            this.bn2 = new System.Windows.Forms.Label();
            this.book3 = new System.Windows.Forms.GroupBox();
            this.issued3 = new System.Windows.Forms.Label();
            this.bn3 = new System.Windows.Forms.Label();
            this.book1.SuspendLayout();
            this.book2.SuspendLayout();
            this.book3.SuspendLayout();
            this.SuspendLayout();
            // 
            // book1
            // 
            this.book1.Controls.Add(this.issued1);
            this.book1.Controls.Add(this.bn1);
            this.book1.Location = new System.Drawing.Point(95, 66);
            this.book1.Name = "book1";
            this.book1.Size = new System.Drawing.Size(293, 100);
            this.book1.TabIndex = 0;
            this.book1.TabStop = false;
            this.book1.Text = "Book 1";
            // 
            // issued1
            // 
            this.issued1.AutoSize = true;
            this.issued1.Location = new System.Drawing.Point(48, 49);
            this.issued1.Name = "issued1";
            this.issued1.Size = new System.Drawing.Size(64, 13);
            this.issued1.TabIndex = 1;
            this.issued1.Text = "Issue Date: ";
            this.issued1.Click += new System.EventHandler(this.an1_Click);
            // 
            // bn1
            // 
            this.bn1.AutoSize = true;
            this.bn1.Location = new System.Drawing.Point(48, 16);
            this.bn1.Name = "bn1";
            this.bn1.Size = new System.Drawing.Size(69, 13);
            this.bn1.TabIndex = 0;
            this.bn1.Text = "Book Name: ";
            this.bn1.Click += new System.EventHandler(this.label1_Click);
            // 
            // book2
            // 
            this.book2.Controls.Add(this.issued2);
            this.book2.Controls.Add(this.bn2);
            this.book2.Location = new System.Drawing.Point(95, 172);
            this.book2.Name = "book2";
            this.book2.Size = new System.Drawing.Size(293, 100);
            this.book2.TabIndex = 1;
            this.book2.TabStop = false;
            this.book2.Text = "Book 2";
            // 
            // issued2
            // 
            this.issued2.AutoSize = true;
            this.issued2.Location = new System.Drawing.Point(48, 64);
            this.issued2.Name = "issued2";
            this.issued2.Size = new System.Drawing.Size(64, 13);
            this.issued2.TabIndex = 2;
            this.issued2.Text = "Issue Date: ";
            // 
            // bn2
            // 
            this.bn2.AutoSize = true;
            this.bn2.Location = new System.Drawing.Point(48, 31);
            this.bn2.Name = "bn2";
            this.bn2.Size = new System.Drawing.Size(69, 13);
            this.bn2.TabIndex = 2;
            this.bn2.Text = "Book Name: ";
            // 
            // book3
            // 
            this.book3.Controls.Add(this.issued3);
            this.book3.Controls.Add(this.bn3);
            this.book3.Location = new System.Drawing.Point(95, 278);
            this.book3.Name = "book3";
            this.book3.Size = new System.Drawing.Size(293, 100);
            this.book3.TabIndex = 1;
            this.book3.TabStop = false;
            this.book3.Text = "Book 3";
            // 
            // issued3
            // 
            this.issued3.AutoSize = true;
            this.issued3.Location = new System.Drawing.Point(53, 64);
            this.issued3.Name = "issued3";
            this.issued3.Size = new System.Drawing.Size(64, 13);
            this.issued3.TabIndex = 3;
            this.issued3.Text = "Issue Date: ";
            // 
            // bn3
            // 
            this.bn3.AutoSize = true;
            this.bn3.Location = new System.Drawing.Point(48, 28);
            this.bn3.Name = "bn3";
            this.bn3.Size = new System.Drawing.Size(69, 13);
            this.bn3.TabIndex = 4;
            this.bn3.Text = "Book Name: ";
            this.bn3.Click += new System.EventHandler(this.label5_Click);
            // 
            // ViewIssuedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 481);
            this.Controls.Add(this.book2);
            this.Controls.Add(this.book3);
            this.Controls.Add(this.book1);
            this.Name = "ViewIssuedBooks";
            this.Text = "ViewIssuedBooks";
            this.Load += new System.EventHandler(this.ViewIssuedBooks_Load);
            this.book1.ResumeLayout(false);
            this.book1.PerformLayout();
            this.book2.ResumeLayout(false);
            this.book2.PerformLayout();
            this.book3.ResumeLayout(false);
            this.book3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox book1;
        private System.Windows.Forms.Label issued1;
        private System.Windows.Forms.Label bn1;
        private System.Windows.Forms.GroupBox book2;
        private System.Windows.Forms.Label bn2;
        private System.Windows.Forms.GroupBox book3;
        private System.Windows.Forms.Label bn3;
        private System.Windows.Forms.Label issued2;
        private System.Windows.Forms.Label issued3;
    }
}