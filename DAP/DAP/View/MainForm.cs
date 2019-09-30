using DAP.Controller;
using DAP.Model;
using DAP.Repository;
using DAP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private HashSet<string> selectedItemsID = new HashSet<string>(); 

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e) {
            enabledAllDetailsElement(false);
            dc = new DocumentController();
            refreshDataFromDatabase();           
            dataGridViewSetThemes();
            listViewFiles.CheckBoxes = true;
        }

       
        /// <summary>
        /// Adatbázisból lekéri újra az összes adatot és megjeleníti a képernyőn
        /// </summary>
        private void refreshDataFromDatabase() {
            dataGridViewMainGrid.DataSource = dc.getAllDocumentsFromDatabase();
            comboBoxCompany.DataSource = dc.getUnicData("Company");
            comboBoxCategory.DataSource = dc.getUnicData("Category");
            comboBoxContent.DataSource = dc.getUnicData("Content");
            selectedItemsID.Clear();            
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
            listViewFiles.Items.Clear();           
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
            
            textBoxDate.ReadOnly = !enabed;
            textBoxDescription.ReadOnly = !enabed;
        }

        /// <summary>
        /// ID alapján alap (egy kattintás / sárga kijelölést rárakja az adott sorra
        /// </summary>
        /// <param name="selectedId">Kijelölni kívánt sor ID -ja</param>
        private void rowSelectLikeIdYellow(string selectedId) {
            
            foreach (DataGridViewRow item in dataGridViewMainGrid.Rows)
            {                
                if ((string)item.Cells[1].Value == selectedId)
                {
                    item.Selected = true;
                    refreshDetailsData(item.Index);
                }                
            }
        }


        #region DataGridView beállításai
        /// <summary>
        /// Táblázat megjelenésének beállításai
        /// </summary>
        private void dataGridViewSetThemes()
        {
            dataGridViewMainGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMainGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMainGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dataGridViewMainGrid.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridViewMainGrid.Columns[1].HeaderText = "Id";
            dataGridViewMainGrid.Columns[2].HeaderText = "Cég";
            dataGridViewMainGrid.Columns[3].HeaderText = "Mappa";
            dataGridViewMainGrid.Columns[4].HeaderText = "Tartalom";
            dataGridViewMainGrid.Columns[5].HeaderText = "Dátum";
            dataGridViewMainGrid.Columns[6].HeaderText = "Rövid leírás";
            
        }

        /// <summary>
        /// Kijelölt sor index alapján lekéri ID -t és befrissíti az oldalsó details elemeket
        /// </summary>
        /// <param name="selectedRowIndex"></param>
        private void refreshDetailsData(int selectedRowIndex)
        {
            try
            {
                selectedID = dataGridViewMainGrid.Rows[selectedRowIndex].Cells[1].Value.ToString();               
                comboBoxCompany.Text = dataGridViewMainGrid.Rows[selectedRowIndex].Cells[2].Value.ToString();
                comboBoxCategory.Text = dataGridViewMainGrid.Rows[selectedRowIndex].Cells[3].Value.ToString();
                comboBoxContent.Text = dataGridViewMainGrid.Rows[selectedRowIndex].Cells[4].Value.ToString();
                textBoxDate.Text = dataGridViewMainGrid.Rows[selectedRowIndex].Cells[5].Value.ToString();
                textBoxDescription.Text = dataGridViewMainGrid.Rows[selectedRowIndex].Cells[6].Value.ToString();
                getFileListInListView(selectedID);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Táblázaban kattintott sor elemeit részletekben megjeleníti
        /// Beolvassa kiválasztott elem ID -ját
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMainGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRowIndex = e.RowIndex;
                refreshDetailsData(selectedRowIndex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Kijelölés változásra betölti a kijelölt sor adatait az oldalsó details részbe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMainGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dataGridViewMainGrid.CurrentRow.Index;
                refreshDetailsData(selectedRowIndex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Táblázatban dupla kattintásra kijelöli a kattintott sort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool isChecked = Convert.ToBoolean(dataGridViewMainGrid.Rows[e.RowIndex].Cells[0].Value);

                if (!isChecked)
                {
                    dataGridViewMainGrid.Rows[e.RowIndex].Cells[0].Value = true;
                    dataGridViewMainGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
                    selectedItemsID.Add(dataGridViewMainGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                else
                {
                    dataGridViewMainGrid.Rows[e.RowIndex].Cells[0].Value = false;
                    dataGridViewMainGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    selectedItemsID.Remove(dataGridViewMainGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
        } 
        #endregion
        
        #region Bal felső gombok
        //Új
        private void buttonNewDocument_Click(object sender, EventArgs e)
        {
            clearAllDetailsValue();
            dataGridViewMainGrid.Enabled = false;
            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;

            buttonCancel.Enabled = true;
            buttonSave.Enabled = true;

            enabledAllDetailsElement(true);

            buttonFileBrows.Enabled = true;
            buttonFileDelete.Enabled = true;

            selectedID = "0";
            dc.deleteFolder(selectedID);

        }
        //Módosít
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (selectedID != "")
            {
                dataGridViewMainGrid.Enabled = false;

                buttonNewDocument.Enabled = false;
                buttonDelete.Enabled = false;

                buttonCancel.Enabled = true;
                buttonSave.Enabled = true;

                buttonFileBrows.Enabled = true;
                buttonFileDelete.Enabled = true;

                enabledAllDetailsElement(true);
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Töröl
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedID != "")
            {

                DialogResult dialog = MessageBox.Show("Biztosan törölni akarod?\n" +
                    "Az összes feltöltött file is törlésre kerül!\n" +
                    "ID:= " + selectedID, "Törlés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop);
                if (dialog == DialogResult.Yes)
                {
                    dc.deleteSelectedDocumentIntoDatabase(selectedID);
                    dc.deleteFolder(selectedID);
                    refreshDataFromDatabase();
                    clearAllDetailsValue();
                }
                else if (dialog == DialogResult.No)
                {

                }

            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Mentés
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string actualId = "";

            if (buttonNewDocument.Enabled)
            {
                Document d = new Document(0, comboBoxCompany.Text, comboBoxCategory.Text, comboBoxContent.Text, textBoxDate.Text, textBoxDescription.Text);
                actualId = Convert.ToString(dc.insertNewDocumentIntoDatabase(d));               
            }
            else
            {
                Document d = new Document(Convert.ToInt32(selectedID), comboBoxCompany.Text, comboBoxCategory.Text, comboBoxContent.Text, textBoxDate.Text, textBoxDescription.Text);
                dc.modifySelectedDocumentIntoDatabase(d);
                actualId = Convert.ToString(d.getID());
            }

            refreshDataFromDatabase();            
            buttonsDefaultStatus();
            rowSelectLikeIdYellow(actualId);
        }
        //Mégsem
        private void buttonCancel_Click(object sender, EventArgs e)
        {

            if (selectedID == "0")
            {
                dc.deleteFolder(selectedID);
            }
            buttonsDefaultStatus();
        }

        /// <summary>
        /// Visszaállítja a bal felső gombokat alap láthatósági beállításokra
        /// </summary>
        private void buttonsDefaultStatus()
        {
            dataGridViewMainGrid.Enabled = true;
            buttonNewDocument.Enabled = true;
            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;

            buttonCancel.Enabled = false;
            buttonSave.Enabled = false;

            buttonFileBrows.Enabled = false;
            buttonFileDelete.Enabled = false;

            clearAllDetailsValue();
            enabledAllDetailsElement(false);
        }

        #endregion

        #region Keresés
        /// <summary>
        /// Kipipált kategóriákból csinál egy string listát
        /// A listában szereplő kategóriákban lehet majd keresni
        /// </summary>
        /// <returns></returns>
        private List<string> getSearchCategoriFromCheckBox()
        {
            List<string> category = new List<string>();

            if (checkBoxCompany.Checked)
            {
                category.Add("Company");
            }
            if (checkBoxCategory.Checked)
            {
                category.Add("Category");
            }
            if (checkBoxContent.Checked)
            {
                category.Add("Content");
            }
            if (checkBoxDate.Checked)
            {
                category.Add("Date");
            }
            if (checkBoxDescription.Checked)
            {
                category.Add("Description");
            }

            return category;
        }

        /// <summary>
        /// Keresés az adatbázisban billentyű leütésenként.
        /// Harmadik karakter leütésétől kezd keresni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text;
            List<string> category = getSearchCategoriFromCheckBox();

            if (textBoxSearch.Text.Length > 2)
            {
                dataGridViewMainGrid.DataSource = dc.searchIntoDatabase(searchText, category);
                selectedItemsID.Clear();
            }
            else
            {
                refreshDataFromDatabase();
            }
        }

        #endregion
        
        #region File műveletek
        /// <summary>
        /// ID alapján kilistázza a hozzá tartozo fileok listáját listView -ba
        /// </summary>
        /// <param name="id"></param>
        private void getFileListInListView(string id)
        {
            listViewFiles.Items.Clear();

            DirectoryInfo dir = dc.getAllFilesById(id);

            if (dir != null)
            {
                foreach (FileInfo item in dir.GetFiles())
                {
                    string ext = item.Extension;
                    if (!imageList.Images.Keys.Contains(ext))
                    {
                        imageList.Images.Add(ext, Icon.ExtractAssociatedIcon(item.FullName));
                    }
                    int index = imageList.Images.Keys.IndexOf(ext);
                    ListViewItem elem = new ListViewItem();
                    elem.Text = item.Name;
                    elem.ImageIndex = index;
                    listViewFiles.Items.Add(elem);
                }
            }
        }

        /// <summary>
        /// ID alpján feltölti a kiválasztott filokat.
        /// Ha nem létezik még a mappa létrehozza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFileBrows_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dc.uplodeFilesById(selectedID, openFileDialog.FileNames, openFileDialog.SafeFileNames);
            }
            getFileListInListView(selectedID);
        }

        /// <summary>
        /// Csatolt fileok listájában checkBox kattitási esemény
        /// beszínezi a kipipált sort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFiles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.BackColor = Color.Yellow;
            }
            else
            {
                e.Item.BackColor = Color.White;
            }
        }

        /// <summary>
        /// ChechkBoxal megjelölt sorokhoz tartozó fileok törlése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFileDelete_Click(object sender, EventArgs e)
        {
            int counter = 0;

            if (listViewFiles.Items.Count > 0)
            {
                foreach (ListViewItem item in listViewFiles.Items)
                {
                    if (item.Checked)
                    {
                        counter++;
                    }
                }
                if (counter > 0)
                {
                    DialogResult dialog = MessageBox.Show("A kijelölt eleme(ek)\n" +
                        "Végleges törlésre kerül(nek)!\n" +
                        "\nBiztosan törölni akarja?", "Csatolt fileok törlése!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Stop);
                    if (dialog == DialogResult.Yes)
                    {
                        foreach (ListViewItem item in listViewFiles.Items)
                        {
                            if (item.Checked)
                            {
                                dc.deleteFile(selectedID, item.Text);
                            }
                        }
                    }
                    else if (dialog == DialogResult.No)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            getFileListInListView(selectedID);
        }

        /// <summary>
        /// Dupla kattintára megnyitja a kiválasztott filet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listViewFiles.SelectedItems;

                ListViewItem lvItem = items[0];
                items[0].Checked = false;
                dc.openFile(selectedID, lvItem.Text);

            }
        }


        #endregion
        
        #region Tömeges műveletek
        /// <summary>
        /// Kijelölt elemek törlése az adatbázisból
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiDelete_Click(object sender, EventArgs e)
        {
            if (selectedItemsID.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Biztosan törölni akarod az összes kijelölt filet?\n" +
                    "Az összes feltöltött file is törlésre kerül!\n" +
                    "Kiválasztott fileok száma: " + selectedItemsID.Count, "Törlés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop);
                if (dialog == DialogResult.Yes)
                {
                    foreach (string item in selectedItemsID)
                    {
                        dc.deleteSelectedDocumentIntoDatabase(item);
                        dc.deleteFolder(item);
                    }
                    refreshDataFromDatabase();
                    clearAllDetailsValue();
                    
                }
                else if (dialog == DialogResult.No)
                {

                }

            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        /// <summary>
        /// Tömeges módosítás
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiModify_Click(object sender, EventArgs e)
        {
            if (selectedItemsID.Count > 0)
            {
                List<string> unicCompany = dc.getUnicData("Company");
                List<string> unicCategory = dc.getUnicData("Category");
                List<string> unicContent = dc.getUnicData("Content");

                MultiUpdateForm muf = new MultiUpdateForm(unicCompany, unicCategory, unicContent);

                if (muf.ShowDialog() == DialogResult.OK)
                {   
                    string columnName = muf.getSelectedColumnName();
                    string newValue = muf.getNewValue();

                    foreach (string item in selectedItemsID)
                    {
                        dc.updateAllSelectedItem(item, columnName, newValue);
                    }
                    refreshDataFromDatabase();
                    clearAllDetailsValue();                    
                }                
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        /// <summary>
        /// Export excel file -ba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiExport_Click(object sender, EventArgs e)
        {
            if (selectedItemsID.Count > 0)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dc.exportExcelSelectedItems(selectedItemsID, saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Adatbeviteli mezők
        private void textBoxDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
            { 
                TextBox t = (TextBox)sender;
                string seperator = ".";
                switch (textBoxDate.Text.Length)
                {
                    case 4:
                        if (e.KeyValue!=190)
                        {
                            t.Text += seperator;
                        }                        
                        break;
                    case 7:
                        if (e.KeyValue != 190)
                        {
                            t.Text += seperator;
                        }
                        break;
                    default:                        
                        if (e.KeyValue == 190)
                        {                            
                           e.Handled = false;
                        }
                        break;
                }
                t.SelectionStart = t.Text.Length;
                
            }
        }





        #endregion

        

       
    }
}
