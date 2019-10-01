namespace DAP.View
{
    partial class MultiUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiUpdateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColumnName = new System.Windows.Forms.ComboBox();
            this.comboBoxNewValue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módosítani kívánt oszlop:";
            // 
            // comboBoxColumnName
            // 
            this.comboBoxColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnName.FormattingEnabled = true;
            this.comboBoxColumnName.Items.AddRange(new object[] {
            "Cég",
            "Mappa",
            "Tartalom"});
            this.comboBoxColumnName.Location = new System.Drawing.Point(15, 41);
            this.comboBoxColumnName.Name = "comboBoxColumnName";
            this.comboBoxColumnName.Size = new System.Drawing.Size(233, 21);
            this.comboBoxColumnName.TabIndex = 1;
            this.comboBoxColumnName.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumnName_SelectedIndexChanged);
            // 
            // comboBoxNewValue
            // 
            this.comboBoxNewValue.FormattingEnabled = true;
            this.comboBoxNewValue.Location = new System.Drawing.Point(15, 102);
            this.comboBoxNewValue.Name = "comboBoxNewValue";
            this.comboBoxNewValue.Size = new System.Drawing.Size(233, 21);
            this.comboBoxNewValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Új érték:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 153);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(173, 153);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Mégsem";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MultiUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 193);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNewValue);
            this.Controls.Add(this.comboBoxColumnName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiUpdateForm";
            this.Text = "MultiUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxColumnName;
        private System.Windows.Forms.ComboBox comboBoxNewValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}