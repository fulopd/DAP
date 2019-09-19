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
        private string selectedID = "";

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e) {
            enabledAllDetailsElement(false);
            dc = new DocumentController();
            refreshDataFromDatabase();
            clearAllDetailsValue();
            dataGridViewSetThemes();
        }

        /// <summary>
        /// Táblázat megjelenésének beállításai
        /// </summary>
        private void dataGridViewSetThemes() {
            dataGridViewMainGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMainGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMainGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dataGridViewMainGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
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
            selectedID = "";
        }

        /// <summary>
        /// Részletek beviteli mezőinek szerkeszthetőségét állítja
        /// </summary>
        /// <param name="enabed">true / false</param>
        private void enabledAllDetailsElement(bool enabed) {
            comboBoxCompany.Enabled = enabed;
            comboBoxCategory.Enabled = enabed;
            comboBoxContent.Enabled = enabed;
            textBoxDate.Enabled = enabed;
            textBoxDescription.Enabled = enabed;
        }

        /// <summary>
        /// Visszaállítja a bal felső gombokat alap láthatósági beállításokra
        /// </summary>
        private void buttonsDefaultStatus()
        {
            buttonNewDocument.Enabled = true;
            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;

            buttonCancel.Enabled = false;
            buttonSave.Enabled = false;

            clearAllDetailsValue();
            enabledAllDetailsElement(false);
        }



        private void buttonNewDocument_Click(object sender, EventArgs e) {
            clearAllDetailsValue();
            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;

            buttonCancel.Enabled = true;
            buttonSave.Enabled = true;

            enabledAllDetailsElement(true);

        }
        
        private void buttonModify_Click(object sender, EventArgs e) {
            buttonNewDocument.Enabled = false;
            buttonDelete.Enabled = false;

            buttonCancel.Enabled = true;
            buttonSave.Enabled = true;

            enabledAllDetailsElement(true);
        }
        

        private void buttonSave_Click(object sender, EventArgs e) {

            if (buttonNewDocument.Enabled){
                Document d = new Document(0, comboBoxCompany.Text, comboBoxCategory.Text, comboBoxContent.Text, textBoxDate.Text, textBoxDescription.Text);
                dc.insertNewDocumentIntoDatabase(d);
            }
            else {
                Document d = new Document(Convert.ToInt32(selectedID), comboBoxCompany.Text, comboBoxCategory.Text, comboBoxContent.Text, textBoxDate.Text, textBoxDescription.Text);
                dc.modifySelectedDocumentIntoDatabase(d);
            }

            refreshDataFromDatabase();
            buttonsDefaultStatus();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            buttonsDefaultStatus();
        }


        /// <summary>
        /// Táblázaban kattintott sor elemeit részletekben megjeleníti
        /// Beolvassa kiválasztott elem ID -ját
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMainGrid_CellClick(object sender, DataGridViewCellEventArgs e){
            selectedID = dataGridViewMainGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxCompany.Text = dataGridViewMainGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxCategory.Text = dataGridViewMainGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxContent.Text = dataGridViewMainGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxDate.Text = dataGridViewMainGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxDescription.Text = dataGridViewMainGrid.Rows[e.RowIndex].Cells[6].Value.ToString();          
        }

        
    }
}
