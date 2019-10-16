using DAP.Controller;
using DAP.Model;
using DAP.Repository;
using DAP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Stopwatch stopWatch = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
            stopWatch.Start();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            enabledAllDetailsElement(false);
            dc = new DocumentController();
            MainSearchText();
            dataGridViewSetThemes();
            listViewFiles.CheckBoxes = true;
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Debug.WriteLine("idő: " + ts.TotalMilliseconds);
        }

       
        /// <summary>
        /// Adatbázisból lekéri újra az összes adatot és megjeleníti a képernyőn
        /// </summary>
        private void refreshDataFromDatabase() { //csak MainSearchText ben használd!
            dataGridViewMainGrid.DataSource = dc.getAllDocumentsFromDatabase();
            comboBoxCompany.DataSource = dc.getUnicData("Company");
            comboBoxCategory.DataSource = dc.getUnicData("Category");
            comboBoxContent.DataSource = dc.getUnicData("Content");
            selectedItemsID.Clear();
            checkBoxSelectAll.Checked = false;
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
        /// <param name="enable">true / false</param>
        private void enabledAllDetailsElement(bool enable) {
            comboBoxCompany.Enabled = enable;
            comboBoxCategory.Enabled = enable;
            comboBoxContent.Enabled = enable;           
            
            textBoxDate.ReadOnly = !enable;
            textBoxDescription.ReadOnly = !enable;
        }

        /// <summary>
        /// ID alapján alap (egy kattintás / sárga) kijelölést rárakja az adott sorra)
        /// </summary>
        /// <param name="selectedId">Kijelölni kívánt sor ID -ja</param>
        private void rowSelectLikeIdYellow(int selectedId) {
            
            foreach (DataGridViewRow item in dataGridViewMainGrid.Rows)
            {                
                if (Convert.ToInt32(item.Cells[1].Value) == selectedId)
                {
                    item.Selected = true;
                    dataGridViewMainGrid.FirstDisplayedScrollingRowIndex = dataGridViewMainGrid.SelectedRows[0].Index;
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
            dataGridViewMainGrid.Columns[1].Width = 50;
            dataGridViewMainGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dataGridViewMainGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            
            dataGridViewMainGrid.Columns[0].ReadOnly = false;
            dataGridViewMainGrid.Columns[1].ReadOnly = true;
            dataGridViewMainGrid.Columns[2].ReadOnly = true;
            dataGridViewMainGrid.Columns[3].ReadOnly = true;
            dataGridViewMainGrid.Columns[4].ReadOnly = true;
            dataGridViewMainGrid.Columns[5].ReadOnly = true;
            dataGridViewMainGrid.Columns[6].ReadOnly = true;

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
            catch (Exception e)
            {
                Debug.WriteLine("Hiba: refreshDetailsData: " + e.Message);
            }
        }
        
        /// <summary>
        /// Kijelölés változásra betölti a kijelölt sor adatait az oldalsó details részbe
        /// </summary>
        private void dataGridViewMainGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dataGridViewMainGrid.CurrentRow.Index;
                refreshDetailsData(selectedRowIndex);
            }
            catch (Exception ec)
            {
                Debug.WriteLine("Hiba: dataGridViewMainGrid_CellClick: " + ec.Message);
            }
        }

        /// <summary>
        /// Táblázatban dupla kattintásra kijelöli a kattintott sort
        /// </summary>
        private void dataGridViewMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bool isChecked = Convert.ToBoolean(dataGridViewMainGrid.Rows[e.RowIndex].Cells[0].Value);

                if (!isChecked)
                {
                    dataGridViewMainGrid.Rows[e.RowIndex].Cells[0].Value = true;                    
                }
                else
                {
                    dataGridViewMainGrid.Rows[e.RowIndex].Cells[0].Value = false;                    
                }

            }
        }

        /// <summary>
        /// Első oszlopban lévő checkBox kattintás esemény
        /// </summary>       
        private void dataGridViewMainGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewMainGrid.Columns[0].Index)
            {                
                bool isChecked = Convert.ToBoolean(dataGridViewMainGrid.Rows[e.RowIndex].Cells[0].Value);

                if (dataGridViewMainGrid.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                {                   
                    dataGridViewMainGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
                    selectedItemsID.Add(dataGridViewMainGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                else
                {                  
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
                    //dc.deleteSelectedDocumentIntoDatabase(selectedID);
                    dc.deleteFolder(selectedID);
                    MainSearchText();
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
            int actualId = 0;

            if (buttonNewDocument.Enabled)
            {
                Document d = new Document(0, comboBoxCompany.Text, comboBoxCategory.Text, comboBoxContent.Text, textBoxDate.Text, textBoxDescription.Text);
                actualId = dc.insertNewDocumentIntoDatabase(d);               
            }
            else
            {
                Document d = new Document(Convert.ToInt32(selectedID), comboBoxCompany.Text, comboBoxCategory.Text, comboBoxContent.Text, textBoxDate.Text, textBoxDescription.Text);
                dc.modifySelectedDocumentIntoDatabase(d);
                actualId = Convert.ToInt32(selectedID);
            }

            MainSearchText();
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
            refreshDetailsData(dataGridViewMainGrid.CurrentCell.RowIndex);
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
        private void SearchText(object sender, EventArgs e)
        {
            MainSearchText();
            
        }

        /// <summary>
        /// Kereső mezőben lévő szöveg alapján állítja be a táblázat tartalmát
        /// Ha üres vagy háromnál kevesebb karakter van benne összes adatot kilistázza
        /// </summary>
        private void MainSearchText() {
            string searchText = textBoxSearch.Text;
            List<string> category = getSearchCategoriFromCheckBox();

            if (textBoxSearch.Text.Length > 2)
            {
                dataGridViewMainGrid.DataSource = dc.searchIntoDatabase(searchText, category);
                selectedItemsID.Clear();
            }
            else if (textBoxSearch.Text.Length == 0)
            {
                refreshDataFromDatabase(); //csak itt kell használni
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
        private void buttonMultiDelete_Click(object sender, EventArgs e)
        {
            if (selectedItemsID.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Biztosan törölni akarod az összes kijelölt elemet?\n" +
                    "Az összes feltöltött file is törlésre kerül!\n" +
                    "Kiválasztott elemek száma: " + selectedItemsID.Count, "Törlés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop);
                if (dialog == DialogResult.Yes)
                {
                    dc.deleteSelectedDocumentIntoDatabase(selectedItemsID);
                    MainSearchText();
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

                    //foreach (string item in selectedItemsID)
                    //{
                    //    dc.updateAllSelectedItem(item, columnName, newValue);
                    //}
                    dc.updateAllSelectedItem(selectedItemsID, columnName, newValue);
                    MainSearchText();
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
        private void buttonMultiExport_Click(object sender, EventArgs e)
        {
            if (selectedItemsID.Count > 0)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //hesset sorba rendezése
                    List<string> temp;
                    temp = selectedItemsID.ToList();                   
                    temp = temp.OrderBy(c => int.Parse(c)).ToList();
                    selectedItemsID.Clear();
                    selectedItemsID.UnionWith(temp);
                    //excel export
                    dc.exportExcelSelectedItems(selectedItemsID, saveFileDialog.FileName);

                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// CheckBox true: mindent kijelöl / false: összes kijelölés megszüntet
        /// </summary>       
        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
            {
                foreach (DataGridViewRow item in dataGridViewMainGrid.Rows)
                {
                    selectedItemsID.Add(item.Cells[1].Value.ToString());
                    item.Cells[0].Value = true;
                    item.DefaultCellStyle.BackColor = Color.YellowGreen;
                }
            }
            else
            {
                foreach (DataGridViewRow item in dataGridViewMainGrid.Rows)
                {
                    selectedItemsID.Remove(item.Cells[1].Value.ToString());
                    item.Cells[0].Value = false;
                    item.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        #endregion

        #region Adatbeviteli mezők        
        private void textBoxDate_KeyDown(object sender, KeyEventArgs e)
        {            
            char a = (char)e.KeyData;

            if (Char.IsDigit(a))
            {
                if (e.KeyCode != Keys.Back)
                {
                    TextBox t = (TextBox)sender;
                    string seperator = ".";
                    switch (textBoxDate.Text.Length)
                    {
                        case 4:
                            if (e.KeyValue != 190)
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
                            //t.Text += a;
                            break;
                    }
                    t.SelectionStart = t.Text.Length;

                }
            }
        }



        #endregion







        private void buttonTest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                Document d = new Document(0, "test", "valami", "Gereblye", "2019.10.08", "Ez is kell, hogy legyen benne");
                dc.insertNewDocumentIntoDatabase(d);
            }

        }

       
    }
}
