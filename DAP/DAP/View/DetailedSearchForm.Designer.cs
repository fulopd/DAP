namespace DAP.View
{
    partial class DetailedSearchForm
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxCompany = new System.Windows.Forms.ListBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.textBoxSearchCompany = new System.Windows.Forms.TextBox();
            this.listBoxResultCompany = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxResultCategory = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxResultContent = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(680, 372);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Keresés";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxCompany
            // 
            this.listBoxCompany.FormattingEnabled = true;
            this.listBoxCompany.Location = new System.Drawing.Point(11, 54);
            this.listBoxCompany.Name = "listBoxCompany";
            this.listBoxCompany.Size = new System.Drawing.Size(230, 108);
            this.listBoxCompany.TabIndex = 1;
            this.listBoxCompany.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCompany_MouseDoubleClick);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(267, 54);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(230, 108);
            this.listBoxCategory.TabIndex = 1;
            // 
            // listBoxContent
            // 
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.Location = new System.Drawing.Point(525, 54);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(230, 108);
            this.listBoxContent.TabIndex = 1;
            // 
            // textBoxSearchCompany
            // 
            this.textBoxSearchCompany.Location = new System.Drawing.Point(11, 28);
            this.textBoxSearchCompany.Name = "textBoxSearchCompany";
            this.textBoxSearchCompany.Size = new System.Drawing.Size(230, 20);
            this.textBoxSearchCompany.TabIndex = 2;
            this.textBoxSearchCompany.TextChanged += new System.EventHandler(this.textBoxSearchCompany_TextChanged);
            // 
            // listBoxResultCompany
            // 
            this.listBoxResultCompany.FormattingEnabled = true;
            this.listBoxResultCompany.Location = new System.Drawing.Point(11, 200);
            this.listBoxResultCompany.Name = "listBoxResultCompany";
            this.listBoxResultCompany.Size = new System.Drawing.Size(230, 95);
            this.listBoxResultCompany.TabIndex = 1;
            this.listBoxResultCompany.DoubleClick += new System.EventHandler(this.listBoxResultCompany_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cég";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kiválasztott cégek:";
            // 
            // listBoxResultCategory
            // 
            this.listBoxResultCategory.FormattingEnabled = true;
            this.listBoxResultCategory.Location = new System.Drawing.Point(267, 200);
            this.listBoxResultCategory.Name = "listBoxResultCategory";
            this.listBoxResultCategory.Size = new System.Drawing.Size(230, 95);
            this.listBoxResultCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kiválasztott cégek:";
            // 
            // listBoxResultContent
            // 
            this.listBoxResultContent.FormattingEnabled = true;
            this.listBoxResultContent.Location = new System.Drawing.Point(525, 200);
            this.listBoxResultContent.Name = "listBoxResultContent";
            this.listBoxResultContent.Size = new System.Drawing.Size(230, 95);
            this.listBoxResultContent.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kiválasztott cégek:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kategória";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tartalom";
            // 
            // DetailedSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSearchCompany);
            this.Controls.Add(this.listBoxResultContent);
            this.Controls.Add(this.listBoxResultCategory);
            this.Controls.Add(this.listBoxResultCompany);
            this.Controls.Add(this.listBoxContent);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.listBoxCompany);
            this.Controls.Add(this.buttonSearch);
            this.Name = "DetailedSearchForm";
            this.Text = "DetailedSearchForm";
            this.Load += new System.EventHandler(this.DetailedSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxCompany;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.TextBox textBoxSearchCompany;
        private System.Windows.Forms.ListBox listBoxResultCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxResultCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxResultContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}