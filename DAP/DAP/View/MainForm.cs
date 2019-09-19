using DAP.Controller;
using DAP.Model;
using DAP.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAP
{
    public partial class MainForm : Form
    {
        
        private DocumentController dc;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e) {
            dc = new DocumentController();
            refreshDataFromDatabase();
        }

        /// <summary>
        /// Adatbázisból lekéri újra az összes adatot és megjeleníti a képernyőn
        /// </summary>
        private void refreshDataFromDatabase() {
            dataGridViewMainGrid.DataSource = dc.getAllDocumentsFromDatabase();
            comboBoxCompany.DataSource = dc.getUnicCompany("Company");
            comboBoxCategory.DataSource = dc.getUnicCompany("Category");
            comboBoxContent.DataSource = dc.getUnicCompany("Content");
        }
        
        /// <summary>
        /// Törli a részletek box összes mezőjének tartalmát
        /// </summary>
        private void clearAllDetailsValue() {
            comboBoxCompany.Text = string.Empty;
            comboBoxCategory.Text = string.Empty;
            comboBoxContent.Text = string.Empty;
            textBoxDate.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            Document d = new Document(0,comboBoxCompany.Text, comboBoxCategory.Text, comboBoxContent.Text, textBoxDate.Text, textBoxDescription.Text);
            dc.insertNewDocumentIntoDatabase(d);
            refreshDataFromDatabase();
            clearAllDetailsValue();
        }
    }
}
