using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAP.View
{
    public partial class MultiUpdateForm : Form
    {
        List<string> unicCompany;
        List<string> unicCategory;
        List<string> unicContent;
        string columnName;

        public MultiUpdateForm(List<string> unicCompany, List<string> unicCategory, List<string> unicContent)
        {
            this.unicCompany = unicCompany;
            this.unicCategory = unicCategory;
            this.unicContent = unicContent;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            
            columnName = comboBoxColumnName.Text;
            if (columnName==string.Empty)
            {
                MessageBox.Show("Nem választottál");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public string getSelectedColumnName() {
            columnName = comboBoxColumnName.Text;
            if (columnName=="Cég")
            {
                return "Company";
            }
            if (columnName == "Mappa")
            {
                return "Category";
            }
            if (columnName == "Tartalom")
            {
                return "Content";
            }
            return null;

        }

        public string getNewValue() {
            return comboBoxNewValue.Text;
        }

        private void comboBoxColumnName_SelectedIndexChanged(object sender, EventArgs e)
        {
            columnName = comboBoxColumnName.Text;
            if (columnName == "Cég")
            {
                comboBoxNewValue.DataSource = unicCompany;
            }
            if (columnName == "Mappa")
            {
                comboBoxNewValue.DataSource = unicCategory;
            }
            if (columnName == "Tartalom")
            {
                comboBoxNewValue.DataSource = unicContent;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
