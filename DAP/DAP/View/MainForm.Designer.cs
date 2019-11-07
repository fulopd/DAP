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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.backgroundWorkerMultiModify = new System.ComponentModel.BackgroundWorker();
            this.timerSearchDelayStatus = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerExport = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerMultiDelete = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.comboBoxContent = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.buttonFileDelete = new System.Windows.Forms.Button();
            this.buttonFileBrows = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonNewDocument = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxContent = new System.Windows.Forms.CheckBox();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.checkBoxCompany = new System.Windows.Forms.CheckBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxMultioperations = new System.Windows.Forms.GroupBox();
            this.labelNumberOfSelectedIds = new System.Windows.Forms.Label();
            this.labelNumberOfRows = new System.Windows.Forms.Label();
            this.labelSplash = new System.Windows.Forms.Label();
            this.buttonMultiDelete = new System.Windows.Forms.Button();
            this.buttonMultiExport = new System.Windows.Forms.Button();
            this.buttonMultiModify = new System.Windows.Forms.Button();
            this.dataGridViewMainGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelMain = new System.Windows.Forms.Panel();
            this.timerSearchDelay = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxMultioperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainGrid)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.FileName = "export";
            this.saveFileDialog.Filter = "Excel file | *.xlsx";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(320, 90);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSelectAll.TabIndex = 21;
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // backgroundWorkerMultiModify
            // 
            this.backgroundWorkerMultiModify.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMultiModify_DoWork);
            this.backgroundWorkerMultiModify.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMultiModify_RunWorkerCompleted);
            // 
            // timerSearchDelayStatus
            // 
            this.timerSearchDelayStatus.Interval = 20;
            this.timerSearchDelayStatus.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backgroundWorkerExport
            // 
            this.backgroundWorkerExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerExport_DoWork);
            this.backgroundWorkerExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerExport_RunWorkerCompleted);
            // 
            // backgroundWorkerMultiDelete
            // 
            this.backgroundWorkerMultiDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMultiDelete_DoWork);
            this.backgroundWorkerMultiDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMultiDelete_RunWorkerCompleted);
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
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(12, 43);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(195, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.comboBoxContent);
            this.groupBoxDetails.Controls.Add(this.comboBoxCategory);
            this.groupBoxDetails.Controls.Add(this.comboBoxCompany);
            this.groupBoxDetails.Controls.Add(this.buttonFileDelete);
            this.groupBoxDetails.Controls.Add(this.buttonFileBrows);
            this.groupBoxDetails.Controls.Add(this.listViewFiles);
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
            this.groupBoxDetails.TabIndex = 4;
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
            this.comboBoxContent.TabIndex = 8;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(6, 86);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(264, 21);
            this.comboBoxCategory.TabIndex = 7;
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(6, 46);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(264, 21);
            this.comboBoxCompany.TabIndex = 6;
            // 
            // buttonFileDelete
            // 
            this.buttonFileDelete.Enabled = false;
            this.buttonFileDelete.Location = new System.Drawing.Point(145, 461);
            this.buttonFileDelete.Name = "buttonFileDelete";
            this.buttonFileDelete.Size = new System.Drawing.Size(125, 23);
            this.buttonFileDelete.TabIndex = 12;
            this.buttonFileDelete.Text = "Töröl";
            this.buttonFileDelete.UseVisualStyleBackColor = true;
            this.buttonFileDelete.Click += new System.EventHandler(this.buttonFileDelete_Click);
            // 
            // buttonFileBrows
            // 
            this.buttonFileBrows.Enabled = false;
            this.buttonFileBrows.Location = new System.Drawing.Point(9, 461);
            this.buttonFileBrows.Name = "buttonFileBrows";
            this.buttonFileBrows.Size = new System.Drawing.Size(125, 23);
            this.buttonFileBrows.TabIndex = 11;
            this.buttonFileBrows.Text = "Tallóz";
            this.buttonFileBrows.UseVisualStyleBackColor = true;
            this.buttonFileBrows.Click += new System.EventHandler(this.buttonFileBrows_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LargeImageList = this.imageList;
            this.listViewFiles.Location = new System.Drawing.Point(9, 321);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(264, 135);
            this.listViewFiles.SmallImageList = this.imageList;
            this.listViewFiles.TabIndex = 11;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewFiles_ItemChecked);
            this.listViewFiles.DoubleClick += new System.EventHandler(this.listViewFiles_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 245;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(6, 222);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(264, 67);
            this.textBoxDescription.TabIndex = 10;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(6, 178);
            this.textBoxDate.MaxLength = 10;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(264, 20);
            this.textBoxDate.TabIndex = 9;
            this.textBoxDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDate_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 305);
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
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(94, 13);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(95, 23);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "Módosítás";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonNewDocument
            // 
            this.buttonNewDocument.Location = new System.Drawing.Point(12, 13);
            this.buttonNewDocument.Name = "buttonNewDocument";
            this.buttonNewDocument.Size = new System.Drawing.Size(76, 23);
            this.buttonNewDocument.TabIndex = 1;
            this.buttonNewDocument.Text = "Új";
            this.buttonNewDocument.UseVisualStyleBackColor = true;
            this.buttonNewDocument.Click += new System.EventHandler(this.buttonNewDocument_Click);
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
            this.groupBoxSearch.Location = new System.Drawing.Point(310, 13);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(418, 67);
            this.groupBoxSearch.TabIndex = 13;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Keresés";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(318, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 10);
            this.panel1.TabIndex = 22;
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
            // checkBoxDescription
            // 
            this.checkBoxDescription.AutoSize = true;
            this.checkBoxDescription.Checked = true;
            this.checkBoxDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescription.Location = new System.Drawing.Point(357, 45);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(56, 17);
            this.checkBoxDescription.TabIndex = 19;
            this.checkBoxDescription.Text = "Leírás";
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            this.checkBoxDescription.CheckedChanged += new System.EventHandler(this.SearchText);
            this.checkBoxDescription.TextChanged += new System.EventHandler(this.SearchText);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Checked = true;
            this.checkBoxDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDate.Location = new System.Drawing.Point(296, 45);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDate.TabIndex = 18;
            this.checkBoxDate.Text = "Dátum";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.SearchText);
            this.checkBoxDate.TextChanged += new System.EventHandler(this.SearchText);
            // 
            // checkBoxContent
            // 
            this.checkBoxContent.AutoSize = true;
            this.checkBoxContent.Checked = true;
            this.checkBoxContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxContent.Location = new System.Drawing.Point(223, 45);
            this.checkBoxContent.Name = "checkBoxContent";
            this.checkBoxContent.Size = new System.Drawing.Size(67, 17);
            this.checkBoxContent.TabIndex = 17;
            this.checkBoxContent.Text = "Tartalom";
            this.checkBoxContent.UseVisualStyleBackColor = true;
            this.checkBoxContent.CheckedChanged += new System.EventHandler(this.SearchText);
            this.checkBoxContent.TextChanged += new System.EventHandler(this.SearchText);
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.Checked = true;
            this.checkBoxCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCategory.Location = new System.Drawing.Point(159, 45);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCategory.TabIndex = 16;
            this.checkBoxCategory.Text = "Mappa";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            this.checkBoxCategory.CheckedChanged += new System.EventHandler(this.SearchText);
            this.checkBoxCategory.TextChanged += new System.EventHandler(this.SearchText);
            // 
            // checkBoxCompany
            // 
            this.checkBoxCompany.AutoSize = true;
            this.checkBoxCompany.Checked = true;
            this.checkBoxCompany.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompany.Location = new System.Drawing.Point(111, 45);
            this.checkBoxCompany.Name = "checkBoxCompany";
            this.checkBoxCompany.Size = new System.Drawing.Size(45, 17);
            this.checkBoxCompany.TabIndex = 15;
            this.checkBoxCompany.Text = "Cég";
            this.checkBoxCompany.UseVisualStyleBackColor = true;
            this.checkBoxCompany.CheckedChanged += new System.EventHandler(this.SearchText);
            this.checkBoxCompany.TextChanged += new System.EventHandler(this.SearchText);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(8, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(399, 20);
            this.textBoxSearch.TabIndex = 13;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.SearchText);
            // 
            // groupBoxMultioperations
            // 
            this.groupBoxMultioperations.Controls.Add(this.labelNumberOfSelectedIds);
            this.groupBoxMultioperations.Controls.Add(this.labelNumberOfRows);
            this.groupBoxMultioperations.Controls.Add(this.labelSplash);
            this.groupBoxMultioperations.Controls.Add(this.buttonMultiDelete);
            this.groupBoxMultioperations.Controls.Add(this.buttonMultiExport);
            this.groupBoxMultioperations.Controls.Add(this.buttonMultiModify);
            this.groupBoxMultioperations.Location = new System.Drawing.Point(734, 13);
            this.groupBoxMultioperations.Name = "groupBoxMultioperations";
            this.groupBoxMultioperations.Size = new System.Drawing.Size(355, 67);
            this.groupBoxMultioperations.TabIndex = 20;
            this.groupBoxMultioperations.TabStop = false;
            this.groupBoxMultioperations.Text = "Tömeges műveletek";
            // 
            // labelNumberOfSelectedIds
            // 
            this.labelNumberOfSelectedIds.AutoSize = true;
            this.labelNumberOfSelectedIds.Location = new System.Drawing.Point(139, 1);
            this.labelNumberOfSelectedIds.Name = "labelNumberOfSelectedIds";
            this.labelNumberOfSelectedIds.Size = new System.Drawing.Size(68, 13);
            this.labelNumberOfSelectedIds.TabIndex = 25;
            this.labelNumberOfSelectedIds.Text = "Selected IDs";
            // 
            // labelNumberOfRows
            // 
            this.labelNumberOfRows.AutoSize = true;
            this.labelNumberOfRows.Location = new System.Drawing.Point(9, 19);
            this.labelNumberOfRows.Name = "labelNumberOfRows";
            this.labelNumberOfRows.Size = new System.Drawing.Size(82, 13);
            this.labelNumberOfRows.TabIndex = 24;
            this.labelNumberOfRows.Text = "NumberOfRows";
            // 
            // labelSplash
            // 
            this.labelSplash.AutoSize = true;
            this.labelSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSplash.Location = new System.Drawing.Point(252, 31);
            this.labelSplash.Name = "labelSplash";
            this.labelSplash.Size = new System.Drawing.Size(0, 31);
            this.labelSplash.TabIndex = 23;
            // 
            // buttonMultiDelete
            // 
            this.buttonMultiDelete.Location = new System.Drawing.Point(180, 38);
            this.buttonMultiDelete.Name = "buttonMultiDelete";
            this.buttonMultiDelete.Size = new System.Drawing.Size(80, 23);
            this.buttonMultiDelete.TabIndex = 13;
            this.buttonMultiDelete.Text = "Törlés";
            this.buttonMultiDelete.UseVisualStyleBackColor = true;
            this.buttonMultiDelete.Click += new System.EventHandler(this.buttonMultiDelete_Click);
            // 
            // buttonMultiExport
            // 
            this.buttonMultiExport.Location = new System.Drawing.Point(94, 38);
            this.buttonMultiExport.Name = "buttonMultiExport";
            this.buttonMultiExport.Size = new System.Drawing.Size(80, 23);
            this.buttonMultiExport.TabIndex = 22;
            this.buttonMultiExport.Text = "Export";
            this.buttonMultiExport.UseVisualStyleBackColor = true;
            this.buttonMultiExport.Click += new System.EventHandler(this.buttonMultiExport_Click);
            // 
            // buttonMultiModify
            // 
            this.buttonMultiModify.Location = new System.Drawing.Point(8, 38);
            this.buttonMultiModify.Name = "buttonMultiModify";
            this.buttonMultiModify.Size = new System.Drawing.Size(80, 23);
            this.buttonMultiModify.TabIndex = 21;
            this.buttonMultiModify.Text = "Módosítás";
            this.buttonMultiModify.UseVisualStyleBackColor = true;
            this.buttonMultiModify.Click += new System.EventHandler(this.buttonMultiModify_Click);
            // 
            // dataGridViewMainGrid
            // 
            this.dataGridViewMainGrid.AllowUserToAddRows = false;
            this.dataGridViewMainGrid.AllowUserToDeleteRows = false;
            this.dataGridViewMainGrid.AllowUserToResizeRows = false;
            this.dataGridViewMainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMainGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewMainGrid.Location = new System.Drawing.Point(310, 85);
            this.dataGridViewMainGrid.MultiSelect = false;
            this.dataGridViewMainGrid.Name = "dataGridViewMainGrid";
            this.dataGridViewMainGrid.RowHeadersVisible = false;
            this.dataGridViewMainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMainGrid.Size = new System.Drawing.Size(779, 480);
            this.dataGridViewMainGrid.TabIndex = 6;
            this.dataGridViewMainGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMainGrid_CellDoubleClick);
            this.dataGridViewMainGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMainGrid_CellValueChanged);
            this.dataGridViewMainGrid.SelectionChanged += new System.EventHandler(this.dataGridViewMainGrid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.checkBoxSelectAll);
            this.panelMain.Controls.Add(this.dataGridViewMainGrid);
            this.panelMain.Controls.Add(this.groupBoxMultioperations);
            this.panelMain.Controls.Add(this.groupBoxSearch);
            this.panelMain.Controls.Add(this.buttonNewDocument);
            this.panelMain.Controls.Add(this.buttonModify);
            this.panelMain.Controls.Add(this.groupBoxDetails);
            this.panelMain.Controls.Add(this.buttonDelete);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1101, 577);
            this.panelMain.TabIndex = 22;
            // 
            // timerSearchDelay
            // 
            this.timerSearchDelay.Interval = 1000;
            this.timerSearchDelay.Tick += new System.EventHandler(this.timerSearchDelay_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 577);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Document Archives Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxMultioperations.ResumeLayout(false);
            this.groupBoxMultioperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainGrid)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMultiModify;
        private System.Windows.Forms.Timer timerSearchDelayStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExport;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMultiDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.ComboBox comboBoxContent;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Button buttonFileDelete;
        private System.Windows.Forms.Button buttonFileBrows;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonNewDocument;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxContent;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxCompany;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxMultioperations;
        private System.Windows.Forms.Label labelSplash;
        private System.Windows.Forms.Button buttonMultiDelete;
        private System.Windows.Forms.Button buttonMultiExport;
        private System.Windows.Forms.Button buttonMultiModify;
        private System.Windows.Forms.DataGridView dataGridViewMainGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Timer timerSearchDelay;
        private System.Windows.Forms.Label labelNumberOfRows;
        private System.Windows.Forms.Label labelNumberOfSelectedIds;
        private System.Windows.Forms.Panel panel1;
    }
}

