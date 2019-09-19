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
            this.comboBoxContent = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.buttonFileDelete = new System.Windows.Forms.Button();
            this.buttonFileBrows = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewDocument = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewMainGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxMultioperations = new System.Windows.Forms.GroupBox();
            this.buttonMultiDelete = new System.Windows.Forms.Button();
            this.buttonMultiExport = new System.Windows.Forms.Button();
            this.buttonMultiModify = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxContent = new System.Windows.Forms.CheckBox();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.checkBoxCompany = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
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
            // buttonFileDelete
            // 
            this.buttonFileDelete.Location = new System.Drawing.Point(145, 461);
            this.buttonFileDelete.Name = "buttonFileDelete";
            this.buttonFileDelete.Size = new System.Drawing.Size(125, 23);
            this.buttonFileDelete.TabIndex = 13;
            this.buttonFileDelete.Text = "Töröl";
            this.buttonFileDelete.UseVisualStyleBackColor = true;
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 321);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 135);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(6, 222);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(264, 67);
            this.textBoxDescription.TabIndex = 10;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(6, 178);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(264, 20);
            this.textBoxDate.TabIndex = 9;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Leírás:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tartalom:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cég:";
            // 
            // buttonNewDocument
            // 
            this.buttonNewDocument.Location = new System.Drawing.Point(12, 12);
            this.buttonNewDocument.Name = "buttonNewDocument";
            this.buttonNewDocument.Size = new System.Drawing.Size(76, 23);
            this.buttonNewDocument.TabIndex = 1;
            this.buttonNewDocument.Text = "Új";
            this.buttonNewDocument.UseVisualStyleBackColor = true;
            this.buttonNewDocument.Click += new System.EventHandler(this.buttonNewDocument_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(94, 12);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(95, 23);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "Módosítás";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(195, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
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
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(158, 42);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Mégsem";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewMainGrid
            // 
            this.dataGridViewMainGrid.AllowUserToAddRows = false;
            this.dataGridViewMainGrid.AllowUserToDeleteRows = false;
            this.dataGridViewMainGrid.AllowUserToResizeRows = false;
            this.dataGridViewMainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMainGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewMainGrid.Location = new System.Drawing.Point(310, 85);
            this.dataGridViewMainGrid.MultiSelect = false;
            this.dataGridViewMainGrid.Name = "dataGridViewMainGrid";
            this.dataGridViewMainGrid.ReadOnly = true;
            this.dataGridViewMainGrid.RowHeadersVisible = false;
            this.dataGridViewMainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMainGrid.Size = new System.Drawing.Size(779, 480);
            this.dataGridViewMainGrid.TabIndex = 6;
            this.dataGridViewMainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMainGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(415, 20);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
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
            // buttonMultiDelete
            // 
            this.buttonMultiDelete.Location = new System.Drawing.Point(169, 38);
            this.buttonMultiDelete.Name = "buttonMultiDelete";
            this.buttonMultiDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiDelete.TabIndex = 2;
            this.buttonMultiDelete.Text = "Törlés";
            this.buttonMultiDelete.UseVisualStyleBackColor = true;
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
            // buttonMultiModify
            // 
            this.buttonMultiModify.Location = new System.Drawing.Point(6, 38);
            this.buttonMultiModify.Name = "buttonMultiModify";
            this.buttonMultiModify.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiModify.TabIndex = 0;
            this.buttonMultiModify.Text = "Módosítás";
            this.buttonMultiModify.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.label7);
            this.groupBoxSearch.Controls.Add(this.checkBoxDescription);
            this.groupBoxSearch.Controls.Add(this.checkBoxDate);
            this.groupBoxSearch.Controls.Add(this.checkBoxContent);
            this.groupBoxSearch.Controls.Add(this.checkBoxCategory);
            this.groupBoxSearch.Controls.Add(this.checkBoxCompany);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(310, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(427, 67);
            this.groupBoxSearch.TabIndex = 10;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Keresés";
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.AutoSize = true;
            this.checkBoxDescription.Checked = true;
            this.checkBoxDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescription.Location = new System.Drawing.Point(365, 45);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(56, 17);
            this.checkBoxDescription.TabIndex = 13;
            this.checkBoxDescription.Text = "Leírás";
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Checked = true;
            this.checkBoxDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDate.Location = new System.Drawing.Point(302, 45);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDate.TabIndex = 12;
            this.checkBoxDate.Text = "Dátum";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxContent
            // 
            this.checkBoxContent.AutoSize = true;
            this.checkBoxContent.Checked = true;
            this.checkBoxContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxContent.Location = new System.Drawing.Point(229, 45);
            this.checkBoxContent.Name = "checkBoxContent";
            this.checkBoxContent.Size = new System.Drawing.Size(67, 17);
            this.checkBoxContent.TabIndex = 11;
            this.checkBoxContent.Text = "Tartalom";
            this.checkBoxContent.UseVisualStyleBackColor = true;
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.Checked = true;
            this.checkBoxCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCategory.Location = new System.Drawing.Point(164, 45);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCategory.TabIndex = 10;
            this.checkBoxCategory.Text = "Mappa";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompany
            // 
            this.checkBoxCompany.AutoSize = true;
            this.checkBoxCompany.Checked = true;
            this.checkBoxCompany.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompany.Location = new System.Drawing.Point(113, 45);
            this.checkBoxCompany.Name = "checkBoxCompany";
            this.checkBoxCompany.Size = new System.Drawing.Size(45, 17);
            this.checkBoxCompany.TabIndex = 9;
            this.checkBoxCompany.Text = "Cég";
            this.checkBoxCompany.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Keresési kategóriák:";
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
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxMultioperations;
        private System.Windows.Forms.Button buttonMultiDelete;
        private System.Windows.Forms.Button buttonMultiExport;
        private System.Windows.Forms.Button buttonMultiModify;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxContent;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxContent;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Label label7;
    }
}

