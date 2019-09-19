namespace DAP
{
    partial class MainForm
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
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.buttonNewDocument = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonFileBrows = new System.Windows.Forms.Button();
            this.buttonFileDelete = new System.Windows.Forms.Button();
            this.dataGridViewMainGrid = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBoxMultioperations = new System.Windows.Forms.GroupBox();
            this.buttonMultiModify = new System.Windows.Forms.Button();
            this.buttonMultiExport = new System.Windows.Forms.Button();
            this.buttonMultiDelete = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxContent = new System.Windows.Forms.ComboBox();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainGrid)).BeginInit();
            this.groupBoxMultioperations.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.comboBoxContent);
            this.groupBoxDetails.Controls.Add(this.comboBoxCategory);
            this.groupBoxDetails.Controls.Add(this.comboBoxCompany);
            this.groupBoxDetails.Controls.Add(this.buttonFileDelete);
            this.groupBoxDetails.Controls.Add(this.buttonFileBrows);
            this.groupBoxDetails.Controls.Add(this.listView1);
            this.groupBoxDetails.Controls.Add(this.textBoxDescription);
            this.groupBoxDetails.Controls.Add(this.textBoxDate);
            this.groupBoxDetails.Controls.Add(this.label6);
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Controls.Add(this.label3);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 75);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(276, 490);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Részletek:";
            // 
            // buttonNewDocument
            // 
            this.buttonNewDocument.Location = new System.Drawing.Point(12, 12);
            this.buttonNewDocument.Name = "buttonNewDocument";
            this.buttonNewDocument.Size = new System.Drawing.Size(76, 23);
            this.buttonNewDocument.TabIndex = 1;
            this.buttonNewDocument.Text = "Új";
            this.buttonNewDocument.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(94, 12);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(95, 23);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "Módosítás";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(195, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 42);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(158, 42);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Mégsem";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cég:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mappa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tartalom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dátum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Leírás:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Csatolt elemek:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(6, 178);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(264, 20);
            this.textBoxDate.TabIndex = 9;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(6, 222);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(264, 67);
            this.textBoxDescription.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 321);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 135);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonFileBrows
            // 
            this.buttonFileBrows.Location = new System.Drawing.Point(6, 461);
            this.buttonFileBrows.Name = "buttonFileBrows";
            this.buttonFileBrows.Size = new System.Drawing.Size(125, 23);
            this.buttonFileBrows.TabIndex = 12;
            this.buttonFileBrows.Text = "Tallóz";
            this.buttonFileBrows.UseVisualStyleBackColor = true;
            // 
            // buttonFileDelete
            // 
            this.buttonFileDelete.Location = new System.Drawing.Point(145, 461);
            this.buttonFileDelete.Name = "buttonFileDelete";
            this.buttonFileDelete.Size = new System.Drawing.Size(125, 23);
            this.buttonFileDelete.TabIndex = 13;
            this.buttonFileDelete.Text = "Töröl";
            this.buttonFileDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMainGrid
            // 
            this.dataGridViewMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainGrid.Location = new System.Drawing.Point(310, 85);
            this.dataGridViewMainGrid.Name = "dataGridViewMainGrid";
            this.dataGridViewMainGrid.Size = new System.Drawing.Size(779, 480);
            this.dataGridViewMainGrid.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(415, 20);
            this.textBox6.TabIndex = 8;
            // 
            // groupBoxMultioperations
            // 
            this.groupBoxMultioperations.Controls.Add(this.buttonMultiDelete);
            this.groupBoxMultioperations.Controls.Add(this.buttonMultiExport);
            this.groupBoxMultioperations.Controls.Add(this.buttonMultiModify);
            this.groupBoxMultioperations.Location = new System.Drawing.Point(743, 12);
            this.groupBoxMultioperations.Name = "groupBoxMultioperations";
            this.groupBoxMultioperations.Size = new System.Drawing.Size(346, 67);
            this.groupBoxMultioperations.TabIndex = 9;
            this.groupBoxMultioperations.TabStop = false;
            this.groupBoxMultioperations.Text = "Tömeges műveletek";
            // 
            // buttonMultiModify
            // 
            this.buttonMultiModify.Location = new System.Drawing.Point(6, 38);
            this.buttonMultiModify.Name = "buttonMultiModify";
            this.buttonMultiModify.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiModify.TabIndex = 0;
            this.buttonMultiModify.Text = "Módosítás";
            this.buttonMultiModify.UseVisualStyleBackColor = true;
            // 
            // buttonMultiExport
            // 
            this.buttonMultiExport.Location = new System.Drawing.Point(88, 38);
            this.buttonMultiExport.Name = "buttonMultiExport";
            this.buttonMultiExport.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiExport.TabIndex = 1;
            this.buttonMultiExport.Text = "Export";
            this.buttonMultiExport.UseVisualStyleBackColor = true;
            // 
            // buttonMultiDelete
            // 
            this.buttonMultiDelete.Location = new System.Drawing.Point(169, 38);
            this.buttonMultiDelete.Name = "buttonMultiDelete";
            this.buttonMultiDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiDelete.TabIndex = 2;
            this.buttonMultiDelete.Text = "Törlés";
            this.buttonMultiDelete.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.checkBox5);
            this.groupBoxSearch.Controls.Add(this.checkBox4);
            this.groupBoxSearch.Controls.Add(this.checkBox3);
            this.groupBoxSearch.Controls.Add(this.checkBox2);
            this.groupBoxSearch.Controls.Add(this.checkBox1);
            this.groupBoxSearch.Controls.Add(this.textBox6);
            this.groupBoxSearch.Location = new System.Drawing.Point(310, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(427, 67);
            this.groupBoxSearch.TabIndex = 10;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Keresés";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Cég";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(58, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Mappa";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(123, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Tartalom";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(196, 45);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(57, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Dátum";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(259, 45);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(56, 17);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "Leírás";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(6, 46);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(264, 21);
            this.comboBoxCompany.TabIndex = 14;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(6, 86);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(264, 21);
            this.comboBoxCategory.TabIndex = 15;
            // 
            // comboBoxContent
            // 
            this.comboBoxContent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxContent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxContent.FormattingEnabled = true;
            this.comboBoxContent.Location = new System.Drawing.Point(6, 133);
            this.comboBoxContent.Name = "comboBoxContent";
            this.comboBoxContent.Size = new System.Drawing.Size(264, 21);
            this.comboBoxContent.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 577);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxMultioperations);
            this.Controls.Add(this.dataGridViewMainGrid);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonNewDocument);
            this.Controls.Add(this.groupBoxDetails);
            this.Name = "MainForm";
            this.Text = "Document Archives Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainGrid)).EndInit();
            this.groupBoxMultioperations.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Button buttonFileDelete;
        private System.Windows.Forms.Button buttonFileBrows;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNewDocument;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewMainGrid;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBoxMultioperations;
        private System.Windows.Forms.Button buttonMultiDelete;
        private System.Windows.Forms.Button buttonMultiExport;
        private System.Windows.Forms.Button buttonMultiModify;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxContent;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxCompany;
    }
}

